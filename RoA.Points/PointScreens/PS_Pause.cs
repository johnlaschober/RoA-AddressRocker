using System;
using System.Drawing;
using RoA.Points.PointCollections;

namespace RoA.Points.PointScreens
{
    public class PS_Pause : IPS
    {
        public bool IsActive(Bitmap screen)
        {
            double pause = ScreenTools.GetMatchingPercentage(screen, PC_PauseMenu.Group);

            return pause > 80;
        }
    }
}
