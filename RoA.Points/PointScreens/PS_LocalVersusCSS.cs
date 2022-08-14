using System;
using System.Drawing;
using RoA.Points.PointCollections;
using RoA.Points.PointObjects;

namespace RoA.Points.PointScreens
{
    public class PS_LocalVersusCSS : IPS
    {
        public PO_CSSSlot slot_p1;
        public PO_CSSSlot slot_p2;

        public bool? isTournamentMode = null;
        private PO_SettingsNumber numTourneyModeBestOf;

        public PS_LocalVersusCSS()
        {
            slot_p1 = new PO_CSSSlot(1);
            slot_p2 = new PO_CSSSlot(2);
            numTourneyModeBestOf = new PO_SettingsNumber(new Point(890, 48), false);
        }

        public bool IsActive(Bitmap screen)
        {
            double purpleBanner = ScreenTools.GetMatchingPercentage(screen, PC_PurpleBanner.Group);
            if (purpleBanner < 30) return false;

            double versusModeText = ScreenTools.GetMatchingPercentage(screen, PC_VersusModeText.Group);
            double tourneyModeText = ScreenTools.GetMatchingPercentage(screen, PC_TourneyModeText.Group);
            if (versusModeText < 30 && tourneyModeText < 30) return false;

            double musicButton = ScreenTools.GetMatchingPercentage(screen, PC_StageSelectMusicButton.Group);

            return musicButton < 50;
        }

        public void UpdateSettings(Bitmap screen)
        {
            isTournamentMode = ScreenTools.GetMatchingPercentage(screen, PC_TourneyModeIcon.Group) > 70;
        }

        public string GetTourneyModeBestOf(Bitmap screen)
        {
            if (isTournamentMode != null && isTournamentMode == true)
            {
                return numTourneyModeBestOf.GetNumber(screen);
            }
            else
            {
                return "";
            }
        }
    }
}
