using System;
using System.Drawing;
using RoA.Points.PointCollections;
using RoA.Screen;

namespace RoA.Points.PointScreens
{
    public class PS_LocalVersusSettings : IPS
    {
        public bool IsActive(Bitmap screen)
        {
            double characters = ScreenTools.GetMatchingPercentage(screen, PC_CSSCharacterNames.Group);

            if (characters > 70) return false;

            double settings = ScreenTools.GetMatchingPercentage(screen, PC_VersusModeSettings.Group);

            return settings > 80;
        }
    }
}
