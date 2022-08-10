using Newtonsoft.Json;
using RoA.Points;
using RoA.Points.PointCollections;
using RoA.Points.PointObjects;
using RoA.Points.PointScreens;
using RoA.Screen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoA.ScreenTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCoords_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Color colorToFind = ColorTranslator.FromHtml("#4CFF00");
                txtBox.Text = String.Empty;

                List<Point> points = ScreenTools.MatchCoordsFromBitmap(openFileDialog.FileName, colorToFind);
                if (points != null && points.Count > 0)
                {
                    string s = "";
                    foreach (var point in points)
                    {
                        s += $"new Point({point.X}, {point.Y})," + Environment.NewLine;
                    }
                    txtBox.Text = s;
                }
            }
        }

        PS_LocalVersusCSS localVersusCSSScreen;
        PS_StageSelect stageSelectScreen;
        PS_LocalVersusMatch localVersusMatchScreen;
        PS_Pause pauseScreen;
        PS_LocalVersusSettings localVersusSettings;
        PO_CSSSlot slot1;
        PO_CSSSlot slot2;

        ScreenSyncer syncer;
        ScreenState prevScreenState;

        private void btnCheckMatch_Click(object sender, EventArgs e)
        {
            localVersusCSSScreen = new PS_LocalVersusCSS();
            stageSelectScreen = new PS_StageSelect();
            localVersusMatchScreen = new PS_LocalVersusMatch();
            pauseScreen = new PS_Pause();
            localVersusSettings = new PS_LocalVersusSettings();
            slot1 = new PO_CSSSlot(1);
            slot2 = new PO_CSSSlot(2);

            syncer = new ScreenSyncer();
            backgroundWorker.RunWorkerAsync();
            bgwSyncer.RunWorkerAsync();
        }

        private void bgwSyncer_DoWork(object sender, DoWorkEventArgs e)
        {
            prevScreenState = null;

            while (true)
            {
                Bitmap screen = ScreenTools.CaptureFromScreen(new Rectangle(0, 0, 2560, 1440), new Size(1920, 1080));

                var newScreenState = syncer.Sync(screen, prevScreenState);

                bgwSyncer.ReportProgress(0, JsonConvert.SerializeObject(newScreenState, Formatting.Indented));

                prevScreenState = newScreenState;

                Thread.Sleep(50);

                screen.Dispose();
            }
        }

        private void bgwSyncer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            txtJSON.Text = e.UserState.ToString();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Bitmap screen = ScreenTools.CaptureFromScreen(new Rectangle(0, 0, 2560, 1440), new Size(1920, 1080));

                Dictionary<string, double> dctOrdering = new Dictionary<string, double>();

                double dblTourney = ScreenTools.GetMatchingPercentage(screen, PC_TourneyModeText.Group);
                string sTourney = $"Tourney: {string.Format("{0:N2}%", dblTourney)}" + Environment.NewLine;
                dctOrdering[sTourney] = dblTourney;

                double dblVersus = ScreenTools.GetMatchingPercentage(screen, PC_VersusModeText.Group);
                string sVersus = $"Versus: {string.Format("{0:N2}%", dblVersus)}" + Environment.NewLine;
                dctOrdering[sVersus] = dblVersus;

                double dblCharacters = ScreenTools.GetMatchingPercentage(screen, PC_CSSCharacterNames.Group);
                string sCharacters = $"Characters: {string.Format("{0:N2}%", dblCharacters)}" + Environment.NewLine;
                dctOrdering[sCharacters] = dblCharacters;

                double dblP1Hud = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P1Hud());
                string sP1Hud = $"P1 Hud: {string.Format("{0:N2}%", dblP1Hud)}" + Environment.NewLine;
                dctOrdering[sP1Hud] = dblP1Hud;

                double dblP2Hud = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P2Hud());
                string sP2Hud = $"P2 Hud: {string.Format("{0:N2}%", dblP2Hud)}" + Environment.NewLine;
                dctOrdering[sP2Hud] = dblP2Hud;

                double dblPurpleBanner = ScreenTools.GetMatchingPercentage(screen, PC_PurpleBanner.Group);
                string sPurpleBanner = $"Purple Banner: {string.Format("{0:N2}%", dblPurpleBanner)}" + Environment.NewLine;
                dctOrdering[sPurpleBanner] = dblPurpleBanner;

                double dblSSBigPreview = ScreenTools.GetMatchingPercentage(screen, PC_StageSelectBigPreview.Group);
                string sSSBigPreview = $"SS Big Preview: {string.Format("{0:N2}%", dblSSBigPreview)}" + Environment.NewLine;
                dctOrdering[sSSBigPreview] = dblSSBigPreview;

                double dblSSHamburger = ScreenTools.GetMatchingPercentage(screen, PC_StageSelectHamburger.Group);
                string sSSHamburger = $"SS Hamburger: {string.Format("{0:N2}%", dblSSHamburger)}" + Environment.NewLine;
                dctOrdering[sSSHamburger] = dblSSHamburger;

                double dblPauseMenu = ScreenTools.GetMatchingPercentage(screen, PC_PauseMenu.Group);
                string sPauseMenu = $"Pause Menu: {string.Format("{0:N2}%", dblPauseMenu)}" + Environment.NewLine;
                dctOrdering[sPauseMenu] = dblPauseMenu;

                double dblVersusModeSettings = ScreenTools.GetMatchingPercentage(screen, PC_VersusModeSettings.Group);
                string sVersusModeSettings = $"Versus Mode Settings: {string.Format("{0:N2}%", dblVersusModeSettings)}" + Environment.NewLine;
                dctOrdering[sVersusModeSettings] = dblVersusModeSettings;

                string sGroupsOutput = "";

                foreach (var pair in dctOrdering.OrderByDescending(k => k.Value))
                {
                    sGroupsOutput += pair.Key;
                }
                backgroundWorker.ReportProgress(0, sGroupsOutput);

                string sScreensOutput = "";

                sScreensOutput += "Local Versus CSS: " + localVersusCSSScreen.IsActive(screen).ToString() + Environment.NewLine;
                sScreensOutput += "Stage Select: " + stageSelectScreen.IsActive(screen).ToString() + Environment.NewLine;
                sScreensOutput += "Local Versus Match: " + localVersusMatchScreen.IsActive(screen).ToString() + Environment.NewLine;
                sScreensOutput += "Pause Screen: " + pauseScreen.IsActive(screen).ToString() + Environment.NewLine;
                sScreensOutput += "Local Versus Settings: " + localVersusSettings.IsActive(screen).ToString() + Environment.NewLine;
                sScreensOutput += "Slot 1: " + slot1.GetSlotType(screen).ToString() + Environment.NewLine;
                sScreensOutput += "Slot 2: " + slot2.GetSlotType(screen).ToString() + Environment.NewLine;
                sScreensOutput += "Slot 1 Character: " + slot1.GetSlotCharacter(screen).ToString() + Environment.NewLine;
                sScreensOutput += "Slot 2 Character: " + slot2.GetSlotCharacter(screen).ToString() + Environment.NewLine;

                backgroundWorker.ReportProgress(1, sScreensOutput);

                Thread.Sleep(50);
                screen.Dispose();
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                txtBox.Text = e.UserState.ToString();
            }
            else if (e.ProgressPercentage == 1)
            {
                txtScreensBox.Text = e.UserState.ToString();
            }
        }

        private void btnTwoImages_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Unedited image";
            openFileDialog1.Title = "Edited image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtJSON.Text = ScreenTools.GetCodeStringFromBitmaps(openFileDialog.FileName, openFileDialog1.FileName);
                }
            }
        }
    }
}
