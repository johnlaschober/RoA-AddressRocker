using System;
using System.Drawing;
using RoA.Points.PointCollections;

namespace RoA.Points.PointScreens
{
    public class PS_LocalMenu : IPS
    {
        public bool IsActive(Bitmap screen)
        {
            double purpleBanner = ScreenTools.GetMatchingPercentage(screen, PC_PurpleBanner.Group);
            if (purpleBanner < 30) return false;

            double localMenu = ScreenTools.GetMatchingPercentage(screen, PC_LocalMenu.Group);
            if (localMenu > 80) return true;

            return false;
        }
    }
}
