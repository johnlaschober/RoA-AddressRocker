using Newtonsoft.Json;
using RoA.Logic;
using RoA.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RoA.AddressTestUI
{
    public partial class frmAddressTest : Form
    {
        public frmAddressTest()
        {
            InitializeComponent();
            cmbPointerType.DataSource = Enum.GetValues(typeof(ePointerItem));
        }

        private void frmAddressTest_Shown(object sender, EventArgs e)
        {
            bgwSync.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Process gameProcess = null;
            string calculatedMD5 = "";
            GameVersion foundVersion = null;

            while (true)
            {
                try
                {
                    try
                    {
                        gameProcess = Process.GetProcessesByName(Constants.ExecutableName).FirstOrDefault();
                    }
                    catch (Exception) { }

                    if (gameProcess != null)
                    {
                        using (var md5Logic = MD5.Create())
                        {
                            using (var stream = File.OpenRead(gameProcess.MainModule.FileName))
                            {
                                calculatedMD5 = BitConverter.ToString(md5Logic.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    bgwSync.ReportProgress(0, "DISCONNECTED");
                    gameProcess = null;
                }

                if (!string.IsNullOrEmpty(calculatedMD5))
                {
                    GameVersionToTest.SetupGameVersion();
                    GameVersion gVersion = GameVersionToTest.VersionToTest;
                    if (gVersion.ExecutableMD5 == calculatedMD5)
                    {
                        foundVersion = gVersion;

                        bgwSync.ReportProgress(-1, foundVersion.PointerItems);
                    }
                }

                if (gameProcess != null && foundVersion != null)
                {
                    MemoryReader reader = new MemoryReader(gameProcess, foundVersion);

                    bgwSync.ReportProgress(0, "CONNECTED " + reader._gameVersion.Version);

                    while (gameProcess != null && !gameProcess.HasExited)
                    {
                        foreach (PointerItem p in foundVersion.PointerItems)
                        {
                            try
                            {
                                TestSync(p, reader);
                            }
                            catch (Exception) { }
                        }
                    }
                    if (gameProcess == null)
                    {
                        bgwSync.ReportProgress(0, "DISCONNECTED");
                    }
                }
                else
                {
                    bgwSync.ReportProgress(0, "DISCONNECTED");
                }
                Thread.Sleep(5000);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == -1)
            {
                dgvTest.DataSource = e.UserState;
            }
            else if (e.ProgressPercentage == 0)
            {
                lblProcessStatus.Text = e.UserState.ToString();
            }
            else if (e.ProgressPercentage == 1)
            {
                dgvTest.Refresh();
            }
        }

        private void TestSync(PointerItem p, MemoryReader reader)
        {
            double dFound = reader.ReadGameMakerDouble(p);
            if (p.Value != dFound)
            {
                GameVersionToTest.VersionToTest.PointerItems.Where(x => x.PointerAddresses == p.PointerAddresses).ToList().FirstOrDefault().Value = dFound;
                bgwSync.ReportProgress(1, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog brws = new SaveFileDialog())
            {
                brws.FileName = "RoAAddressTest.json";
                brws.Filter = "json file (*.json)|*.json";
                if (brws.ShowDialog() == DialogResult.Cancel) return;

                try
                {
                    string json = JsonConvert.SerializeObject(dgvTest.DataSource, Formatting.Indented);
                    File.WriteAllText(brws.FileName, json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving JSON file: " + ex.Message.ToString(), "Error");
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CheatTable));
            using (StringReader reader = new StringReader(txtCheatEngineXML.Text))
            {
                List<PointerItem> convertedPointers = new List<PointerItem>();

                var test = (CheatTable)serializer.Deserialize(reader);
                foreach (var entry in test.CheatEntries.CheatEntry)
                {
                    PointerItem pi = new PointerItem();
                    pi.BaseOffset = Convert.ToInt32(entry.Address.Split('+').Last(), 16);
                    foreach (var cheatOffset in entry.Offsets.Offset)
                    {
                        pi.PointerAddresses.Add(Convert.ToInt32(cheatOffset, 16));
                    }
                    pi.PointerType = (ePointerItem)cmbPointerType.SelectedItem;
                    convertedPointers.Add(pi);
                }

                string outputText = "";

                foreach (PointerItem i in convertedPointers)
                {
                    //new PointerItem()
                    //{
                    //    PointerType = ePointerItem.P1_CHARACTER_INDEX,
                    //    BaseOffset = 0x057E3EB8,
                    //    PointerAddresses = new List<Int32>() { 0x10, 0x4, 0x64, 0x30, 0x324, 0x10, 0x2C }
                    //},

                    List<string> intsToHex = new List<string>();

                    foreach (var hex in i.PointerAddresses)
                    {
                        intsToHex.Add("0x" + hex.ToString("X"));
                    }

                    string sPointer = i.PointerType.ToString();
                    string sBaseOffset = "0x" + i.BaseOffset.ToString("X");
                    string sIntsToHex = String.Join(", ", intsToHex);

                    string sTmp = String.Format(
@"new PointerItem()
<<
    PointerType = ePointerItem.{0},
    BaseOffset = {1},
    PointerAddresses = new List<Int32>() << {2} >>
>>, ", sPointer, sBaseOffset, sIntsToHex);

                    outputText += System.Environment.NewLine + sTmp.Replace("<<", "{").Replace(">>", "}");
                }

                outputText = outputText.TrimEnd(',');

                txtCheatEngineXML.Text = outputText;
            }
        }
    }
}
