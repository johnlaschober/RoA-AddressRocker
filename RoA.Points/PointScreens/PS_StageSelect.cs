using System;
using System.Drawing;
using RoA.Points.PointCollections;

namespace RoA.Points.PointScreens
{
    public class PS_StageSelect : IPS
    {
        public bool IsActive(Bitmap screen)
        {
            double purpleBanner = ScreenTools.GetMatchingPercentage(screen, PC_PurpleBanner.Group);
            if (purpleBanner < 30) return false;

            double musicButton = ScreenTools.GetMatchingPercentage(screen, PC_StageSelectMusicButton.Group);

            if (musicButton <= 50) return false;

            double stageSelectBigPreview = ScreenTools.GetMatchingPercentage(screen, PC_StageSelectBigPreview.Group);
            double stageSelectHamburger = ScreenTools.GetMatchingPercentage(screen, PC_StageSelectHamburger.Group);

            return (((stageSelectBigPreview + stageSelectHamburger) / 2) > 80);
        }
    }
}
