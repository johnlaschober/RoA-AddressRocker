using Newtonsoft.Json;
using RoA.AddressRocker;
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
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoA.RockerUI
{
    public partial class frmRockerUI : Form
    {
        ConfigurationFile configFile;

        private string _rockerConfigPath;

        public frmRockerUI()
        {
            InitializeComponent();
        }

        private void frmRockerUI_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);
            lblRockerVersion.Text = String.Format("v{0}", info.ProductVersion);

            string rockerPath = Path.GetDirectoryName(assembly.Location);
            _rockerConfigPath = String.Format("{0}\\RockerConfig.json", rockerPath);
            if (!File.Exists(_rockerConfigPath))
            {
                try
                {
                    ConfigurationFile configFile = new ConfigurationFile();
                    configFile.Save(_rockerConfigPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not create RocketConfig.json configuration file: " + ex.Message.ToString(), "Error");
                }
            }
            else
            {
                try
                {
                    string configText = File.ReadAllText(_rockerConfigPath);
                    configFile = JsonConvert.DeserializeObject<ConfigurationFile>(configText);

                    txtSaveLocation.Text = configFile.StateSavePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading in RocketConfig.json file: " + ex.Message.ToString(), "Error");
                }
            }
        }

        private void frmRockerUI_Shown(object sender, EventArgs e)
        {
            bgwSync.RunWorkerAsync();
        }

        private void bgwSync_DoWork(object sender, DoWorkEventArgs e)
        {
            Process gameProcess = null;
            string calculatedMD5 = "";

            while (true)
            {
                try
                {
                    gameProcess = Process.GetProcessesByName(Constants.ExecutableName).FirstOrDefault();
                    using (var md5Logic = MD5.Create())
                    {
                        using (var stream = File.OpenRead(gameProcess.MainModule.FileName))
                        {
                            calculatedMD5 = BitConverter.ToString(md5Logic.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
                        }
                    }
                }
                catch (Exception)
                {
                    bgwSync.ReportProgress(0, "DISCONNECTED");
                    gameProcess = null;
                }

                if (gameProcess != null)
                {
                    MemoryReader reader = new MemoryReader(gameProcess, PointerDirectory.GameVersions.Where(x => x.ExecutableMD5 == calculatedMD5).ToList().First());
                    StateSyncer syncer = new StateSyncer(reader);

                    bgwSync.ReportProgress(0, "CONNECTED " + reader._gameVersion.Version);

                    while (gameProcess != null)
                    {
                        try
                        {
                            if (syncer.Sync())
                            {
                                bgwSync.ReportProgress(1, syncer.gameState);
                                WriteStateToFile(syncer.gameState);
                            }
                        }
                        catch (Exception)
                        {

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

        private void WriteStateToFile(GameState state)
        {
            try
            {
                string json = JsonConvert.SerializeObject(state);
                File.WriteAllText(configFile.StateSavePath, json);
            }
            catch (Exception)
            {
                // Silently error, don't want to muck up game.
            }
        }

        private void bgwSync_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                lblProcessStatus.Text = e.UserState.ToString();
                if (e.UserState.ToString() == "DISCONNECTED") Disconnected();
            }
            else if (e.ProgressPercentage == 1)
            {
                GameState state = (GameState)e.UserState;
                lblCharacter1.Text = state.P1Character.Character;
                lblSkin1.Text = state.P1Character.Skin.SkinIndex.ToString();
                lblCharacter2.Text = state.P2Character.Character;
                lblSkin2.Text = state.P2Character.Skin.SkinIndex.ToString();
                lblInMatch.Text = state.TourneySet.InMatch.ToString();
                lblFirstTo.Text = state.TourneySet.TourneyModeFirstTo.ToString();
                lblGames1.Text = state.TourneySet.P1GameCount.ToString();
                lblGames2.Text = state.TourneySet.P2GameCount.ToString();
            }
        }

        private void Disconnected()
        {
            lblCharacter1.Text = "???";
            lblSkin1.Text =      "???";
            lblCharacter2.Text = "???";
            lblSkin2.Text =      "???";
            lblInMatch.Text =    "???";
            lblFirstTo.Text =    "???";
            lblGames1.Text =     "???";
            lblGames2.Text =     "???";
        }

        private void btnSaveDirectory_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog brws = new SaveFileDialog())
            {
                brws.FileName = "RoAState.json";
                brws.Filter = "json file (*.json)|*.json";
                if (brws.ShowDialog() == DialogResult.Cancel) return;

                string sPrevLocation = configFile.StateSavePath;
                configFile.StateSavePath = brws.FileName;

                try
                {
                    configFile.Save(_rockerConfigPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving RockerConfig.json file: " + ex.Message.ToString(), "Error");
                    configFile.StateSavePath = sPrevLocation;
                }
                txtSaveLocation.Text = configFile.StateSavePath;
            }
        }
    }
}
