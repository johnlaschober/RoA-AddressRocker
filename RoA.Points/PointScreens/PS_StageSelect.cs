using System;
using System.Drawing;
using RoA.Points.PointCollections;
using RoA.Screen;

namespace RoA.Points.PointScreens
{
    public class PS_StageSelect : IPS
    {
        public bool IsActive(Bitmap screen)
        {
            double purpleBanner = ScreenTools.GetMatchingPercentage(screen, PC_PurpleBanner.Group);
            if (purpleBanner < 30) return false;

            double p1Hud = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P1Hud());
            double p2Hud = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P2Hud());

            if (((p1Hud + p2Hud) / 2) < 90) return false;

            double stageSelectBigPreview = ScreenTools.GetMatchingPercentage(screen, PC_StageSelectBigPreview.Group);
            double stageSelectHamburger = ScreenTools.GetMatchingPercentage(screen, PC_StageSelectHamburger.Group);

            return (((stageSelectBigPreview + stageSelectHamburger) / 2) > 80);
        }
    }
}
