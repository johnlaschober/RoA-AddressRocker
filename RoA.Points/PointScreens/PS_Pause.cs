using System;
using System.Drawing;
using RoA.Points.PointCollections;

namespace RoA.Points.PointScreens
{
    public class PS_Pause : IPS
    {
        public bool IsActive(Bitmap screen)
        {
            double p1Hud = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P1Hud());
            double p2Hud = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P2Hud());

            if (((p1Hud + p2Hud) / 2) > 90) return false;

            double pause = ScreenTools.GetMatchingPercentage(screen, PC_PauseMenu.Group);

            return pause > 80;
        }
    }
}
