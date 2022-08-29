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

            double overtime = ScreenTools.GetMatchingPercentage(screen, PC_Overtime.Group);
            if (overtime >= 100) return true;

            double staticTimerDouble = ScreenTools.GetMatchingPercentage(screen, PC_MatchTimerDoubleDigits.Group);
            double staticTimerSingle = ScreenTools.GetMatchingPercentage(screen, PC_MatchTimerSingleDigits.Group);

            return (staticTimerDouble >= 100 || staticTimerSingle >= 100);
        }
    }
}
