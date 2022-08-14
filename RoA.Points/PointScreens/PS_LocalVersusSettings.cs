using System;
using System.Drawing;
using RoA.Points.PointCollections;
using RoA.Points.PointObjects;

namespace RoA.Points.PointScreens
{
    public class PS_LocalVersusSettings : IPS
    {
        public PO_SettingsNumber tourneyBestOfNumber;
        public PO_SettingsNumber stockNumber;
        public PO_SettingsNumber timeNumber;

        public PS_LocalVersusSettings()
        {
            tourneyBestOfNumber = new PO_SettingsNumber(new Point(1144, 242));
            stockNumber = new PO_SettingsNumber(new Point(1144, 298));
            timeNumber = new PO_SettingsNumber(new Point(1144, 354));
        }

        public bool IsActive(Bitmap screen)
        {
            double characters = ScreenTools.GetMatchingPercentage(screen, PC_CSSCharacterNames.Group);

            if (characters > 70) return false;

            double settings = ScreenTools.GetMatchingPercentage(screen, PC_VersusModeSettings.Group);

            return settings > 80;
        }
    }
}
