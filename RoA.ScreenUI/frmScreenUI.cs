using RoA.Points;
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

namespace RoA.ScreenUI
{
    public partial class frmScreenUI : Form
    {
        public frmScreenUI()
        {
            InitializeComponent();
        }

        private void bgwSync_DoWork(object sender, DoWorkEventArgs e)
        {
            ScreenSyncer syncer = new ScreenSyncer();

            while (true)
            {
                try
                {
                    Bitmap screen = ScreenTools.CaptureFromScreen(new Rectangle(0, 0, 2560, 1440), new Size(1920, 1080));
                    var stateResultsTuple = syncer.Sync(screen);

                    bool changesOccurred = stateResultsTuple.Item1;
                    ScreenState currentState = stateResultsTuple.Item2;

                    if (changesOccurred)
                    {
                        bgwSync.ReportProgress(0, currentState);
                    }

                    screen.Dispose();
                    Thread.Sleep(250);
                }
                catch (Exception) { }
            }
        }

        private void bgwSync_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                UpdateFormLabels((ScreenState)e.UserState);
            }
        }

        private void UpdateFormLabels(ScreenState s)
        {
            if (!String.IsNullOrEmpty(s.P1SlotType)) grpPlayer1.Text = $"Player 1 ({s.P1SlotType})";
            if (!String.IsNullOrEmpty(s.P2SlotType)) grpPlayer2.Text = $"Player 2 ({s.P2SlotType})";
            if (!String.IsNullOrEmpty(s.P3SlotType)) grpPlayer3.Text = $"Player 3 ({s.P3SlotType})";
            if (!String.IsNullOrEmpty(s.P4SlotType)) grpPlayer4.Text = $"Player 4 ({s.P4SlotType})";

            lblP1Character.Text = s.P1Character;
            lblP2Character.Text = s.P2Character;
            lblP3Character.Text = s.P3Character;
            lblP4Character.Text = s.P4Character;

            lblP1Stocks.Text = s.P1Stock;
            lblP2Stocks.Text = s.P2Stock;
            lblP3Stocks.Text = s.P3Stock;
            lblP4Stocks.Text = s.P4Stock;

            lblP1Games.Text = s.P1GameCount;
            lblP2Games.Text = s.P2GameCount;
            lblP3Games.Text = s.P3GameCount;
            lblP4Games.Text = s.P4GameCount;

            lblBestOf.Text = s.TourneyBestOf;
            lblStocks.Text = s.Stock;
            lblTime.Text = s.Time;
            lblInMatch.Text = s.InMatch.ToString();
        }

        private void frmScreenUI_Load(object sender, EventArgs e)
        {
            bgwSync.RunWorkerAsync();
        }
    }
}
