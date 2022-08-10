using System;
using System.Drawing;
using RoA.Points.PointCollections;

namespace RoA.Points.PointScreens
{
    public class PS_LocalVersusCSS : IPS
    {
        public bool IsActive(Bitmap screen)
        {
            double purpleBanner = ScreenTools.GetMatchingPercentage(screen, PC_PurpleBanner.Group);
            if (purpleBanner < 30) return false;

            double versusModeText = ScreenTools.GetMatchingPercentage(screen, PC_VersusModeText.Group);
            double tourneyModeText = ScreenTools.GetMatchingPercentage(screen, PC_TourneyModeText.Group);
            if (versusModeText < 30 && tourneyModeText < 30) return false;

            double charNames = ScreenTools.GetMatchingPercentage(screen, PC_CSSCharacterNames.Group);
            return charNames > 60;
        }
    }
}
