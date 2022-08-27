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
            if (pause > 80) return true;

            double dblTimer1 = ScreenTools.GetMatchingPercentage(screen, PC_MatchTimerSingleDigits.PauseGroup);
            if (dblTimer1 >= 90) return true;

            double dblTimer2 = ScreenTools.GetMatchingPercentage(screen, PC_MatchTimerDoubleDigits.PauseGroup);
            if (dblTimer2 >= 90) return true;

            return false;
        }
    }
}
