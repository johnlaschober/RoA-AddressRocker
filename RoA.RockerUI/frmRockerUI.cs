﻿using Newtonsoft.Json;
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
        private GameVersion foundVersion = null;
        private Process gameProcess = null;


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
                    chkOverrideMD5.Checked = configFile.ShouldOverrideMD5;
                    PopulateMD5Combo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading in RocketConfig.json file: " + ex.Message.ToString(), "Error");
                }
            }
        }

        private void PopulateMD5Combo()
        {
            for (int i = PointerDirectory.GameVersions.Count - 1; i >= 0; i--)
            {
                var v = PointerDirectory.GameVersions[i];
                string newItem = v.Version + " - " + v.ExecutableMD5;
                cmbMD5Override.Items.Add(newItem);
                if (configFile.ShouldOverrideMD5 && newItem.Contains(configFile.OverrideMD5))
                {
                    cmbMD5Override.SelectedItem = newItem;
                }
            }
        }

        private void frmRockerUI_Shown(object sender, EventArgs e)
        {
            bgwSync.RunWorkerAsync();
        }

        private void bgwSync_DoWork(object sender, DoWorkEventArgs e)
        {
            string calculatedMD5 = "";

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
                    if (configFile.ShouldOverrideMD5)
                    {
                        List<GameVersion> foundGameVersions = PointerDirectory.GameVersions.Where(x => x.ExecutableMD5 == configFile.OverrideMD5).ToList();
                        if (foundGameVersions.Count > 0)
                        {
                            foundVersion = foundGameVersions.First();
                        }
                    }
                    else
                    {
                        List<GameVersion> foundGameVersions = PointerDirectory.GameVersions.Where(x => x.ExecutableMD5 == calculatedMD5).ToList();
                        if (foundGameVersions.Count > 0)
                        {
                            foundVersion = foundGameVersions.First();
                        }
                    }
                }

                if (gameProcess != null && foundVersion != null)
                {
                    MemoryReader reader = new MemoryReader(gameProcess, foundVersion);
                    StateSyncer syncer = new StateSyncer(reader);

                    bgwSync.ReportProgress(0, "CONNECTED " + reader._gameVersion.Version);

                    while (gameProcess != null && !gameProcess.HasExited)
                    {
                        try
                        {
                            if (syncer.Sync())
                            {
                                bgwSync.ReportProgress(1, syncer.gameState);
                                WriteStateToFile(syncer.gameState);
                            }
                        }
                        catch (Exception) { }
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
                if (!String.IsNullOrEmpty(configFile.StateSavePath))
                {
                    string json = JsonConvert.SerializeObject(state, Formatting.Indented);
                    File.WriteAllText(configFile.StateSavePath, json);
                }
            }
            catch (Exception) { } // Silently error, don't want to muck up game.
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
                lblSkinDesc1.Text = state.P1Character.Skin.SkinDescription;
                lblSkinIndex1.Text = state.P1Character.Skin.SkinIndex.ToString();
                lblCharacter2.Text = state.P2Character.Character;
                lblSkinDesc2.Text = state.P2Character.Skin.SkinDescription;
                lblSkinIndex2.Text = state.P2Character.Skin.SkinIndex.ToString();
                lblInMatch.Text = state.TourneySet.InMatch.ToString();
                lblBestOf.Text = state.TourneySet.TourneyModeBestOf.ToString();
                lblGames1.Text = state.TourneySet.P1GameCount.ToString();
                lblGames2.Text = state.TourneySet.P2GameCount.ToString();
                grpPlayer1.Text = String.Format("Player 1 ({0})", state.P1Character.SlotState.ToString());
                grpPlayer2.Text = String.Format("Player 2 ({0})", state.P2Character.SlotState.ToString());
            }
        }

        private void Disconnected()
        {
            lblCharacter1.Text = "???";
            lblSkinDesc1.Text =  "???";
            lblSkinIndex1.Text = "???";
            lblCharacter2.Text = "???";
            lblSkinDesc2.Text =  "???";
            lblSkinIndex2.Text = "???";
            lblInMatch.Text =    "???";
            lblBestOf.Text =     "???";
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

        private void cmbMD5Override_SelectedIndexChanged(object sender, EventArgs e)
        {
            foundVersion = null;
            gameProcess = null;

            configFile.OverrideMD5 = cmbMD5Override.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(configFile.OverrideMD5))
            {
                configFile.OverrideMD5 = configFile.OverrideMD5.Substring(configFile.OverrideMD5.IndexOf("- ") + 2);
            }
            try
            {
                configFile.Save(_rockerConfigPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving RockerConfig.json file: " + ex.Message.ToString(), "Error");
            }
        }

        private void chkOverrideMD5_CheckedChanged(object sender, EventArgs e)
        {
            foundVersion = null;
            gameProcess = null;

            cmbMD5Override.Enabled = chkOverrideMD5.Checked;
            configFile.ShouldOverrideMD5 = chkOverrideMD5.Checked;
            try
            {
                configFile.Save(_rockerConfigPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving RockerConfig.json file: " + ex.Message.ToString(), "Error");
            }
        }
    }
}
