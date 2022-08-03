using RoA.Points.Points;
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            btnTest.ForeColor = ScreenTools.GetColorFromScreen(new Point(0, 0));
            btnTest.BackColor = btnTest.ForeColor;
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


        private void btnCheckMatch_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Bitmap screen = ScreenTools.CaptureFromScreen(new Rectangle(0, 0, 1920, 1080));

                string txt = 
                    $"Tourney: {string.Format("{0:N2}%", ScreenTools.GetMatchingPercentage(screen, PC_TourneyModeText.Group))}" 
                    + Environment.NewLine 
                    + $"Versus: {string.Format("{0:N2}%", ScreenTools.GetMatchingPercentage(screen, PC_VersusModeText.Group))}"
                    + Environment.NewLine
                    + $"Characters: {string.Format("{0:N2}%", ScreenTools.GetMatchingPercentage(screen, PC_CharacterNamesInCSS.Group))}"
                    + Environment.NewLine
                    + $"P1 Damage HUD: {string.Format("{0:N2}%", ScreenTools.GetMatchingPercentage(screen, PC_P1DamageHud.Group))}"
                    + Environment.NewLine
                    + $"P2 Damage HUd: {string.Format("{0:N2}%", ScreenTools.GetMatchingPercentage(screen, PC_P2DamageHud.Group))}"
                    ;

                backgroundWorker.ReportProgress(0, txt);
                Thread.Sleep(1000);
                screen.Dispose();
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            txtBox.Text = e.UserState.ToString();
        }
    }
}
