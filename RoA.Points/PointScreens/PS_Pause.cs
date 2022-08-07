using System;
using System.Drawing;
using RoA.Points.PointCollections;
using RoA.Screen;

namespace RoA.Points.PointScreens
{
    public class PS_Pause : IPS
    {
        public bool IsActive(Bitmap screen)
        {
            double p1Hud = ScreenTools.GetMatchingPercentage(screen, PC_P1Hud.Group);
            double p2Hud = ScreenTools.GetMatchingPercentage(screen, PC_P2Hud.Group);

            if (((p1Hud + p2Hud) / 2) > 90) return false;

            double pause = ScreenTools.GetMatchingPercentage(screen, PC_PauseMenu.Group);

            return pause > 80;
        }
    }
}
