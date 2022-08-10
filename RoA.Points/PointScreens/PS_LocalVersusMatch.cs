using System;
using System.Drawing;
using RoA.Points.PointCollections;

namespace RoA.Points.PointScreens
{
    public class PS_LocalVersusMatch : IPS
    {
        public bool IsActive(Bitmap screen)
        {
            double purpleBanner = ScreenTools.GetMatchingPercentage(screen, PC_PurpleBanner.Group);
            if (purpleBanner > 80) return false;

            double p1Hud = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P1Hud());
            double p2Hud = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P2Hud());

            return (((p1Hud + p2Hud) / 2) > 90);
        }
    }
}
