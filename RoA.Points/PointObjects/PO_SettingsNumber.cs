using RoA.Points.PointCollections;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Points.PointObjects
{
    public class PO_SettingsNumber
    {
        private PointCollectionsGroup numDashLeft;
        private PointCollectionsGroup num0Left;
        private PointCollectionsGroup num1Left;
        private PointCollectionsGroup num2Left;
        private PointCollectionsGroup num3Left;
        private PointCollectionsGroup num4Left;
        private PointCollectionsGroup num5Left;
        private PointCollectionsGroup num6Left;
        private PointCollectionsGroup num7Left;
        private PointCollectionsGroup num8Left;
        private PointCollectionsGroup num9Left;

        private PointCollectionsGroup numDashRight;
        private PointCollectionsGroup num0Right;
        private PointCollectionsGroup num1Right;
        private PointCollectionsGroup num2Right;
        private PointCollectionsGroup num3Right;
        private PointCollectionsGroup num4Right;
        private PointCollectionsGroup num5Right;
        private PointCollectionsGroup num6Right;
        private PointCollectionsGroup num7Right;
        private PointCollectionsGroup num8Right;
        private PointCollectionsGroup num9Right;

        private bool doubleDigits = true;

        public PO_SettingsNumber(Point leftStartPoint, bool doubleDigits = true)
        {
            this.doubleDigits = doubleDigits;

            Point rightStartPoint = new Point(leftStartPoint.X + 24, leftStartPoint.Y);

            numDashLeft = PointHelper.GetGroupClone(PC_SettingsDash.Group);
            num0Left = PointHelper.GetGroupClone(PC_Settings0.Group);
            num1Left = PointHelper.GetGroupClone(PC_Settings1.Group);
            num2Left = PointHelper.GetGroupClone(PC_Settings2.Group);
            num3Left = PointHelper.GetGroupClone(PC_Settings3.Group);
            num4Left = PointHelper.GetGroupClone(PC_Settings4.Group);
            num5Left = PointHelper.GetGroupClone(PC_Settings5.Group);
            num6Left = PointHelper.GetGroupClone(PC_Settings6.Group);
            num7Left = PointHelper.GetGroupClone(PC_Settings7.Group);
            num8Left = PointHelper.GetGroupClone(PC_Settings8.Group);
            num9Left = PointHelper.GetGroupClone(PC_Settings9.Group);

            if (doubleDigits)
            {
                numDashRight = PointHelper.GetGroupClone(PC_SettingsDash.Group);
                num0Right = PointHelper.GetGroupClone(PC_Settings0.Group);
                num1Right = PointHelper.GetGroupClone(PC_Settings1.Group);
                num2Right = PointHelper.GetGroupClone(PC_Settings2.Group);
                num3Right = PointHelper.GetGroupClone(PC_Settings3.Group);
                num4Right = PointHelper.GetGroupClone(PC_Settings4.Group);
                num5Right = PointHelper.GetGroupClone(PC_Settings5.Group);
                num6Right = PointHelper.GetGroupClone(PC_Settings6.Group);
                num7Right = PointHelper.GetGroupClone(PC_Settings7.Group);
                num8Right = PointHelper.GetGroupClone(PC_Settings8.Group);
                num9Right = PointHelper.GetGroupClone(PC_Settings9.Group);
            }

            PointHelper.SlideGroup(leftStartPoint, ref numDashLeft);
            PointHelper.SlideGroup(leftStartPoint, ref num0Left);
            PointHelper.SlideGroup(leftStartPoint, ref num1Left);
            PointHelper.SlideGroup(leftStartPoint, ref num2Left);
            PointHelper.SlideGroup(leftStartPoint, ref num3Left);
            PointHelper.SlideGroup(leftStartPoint, ref num4Left);
            PointHelper.SlideGroup(leftStartPoint, ref num5Left);
            PointHelper.SlideGroup(leftStartPoint, ref num6Left);
            PointHelper.SlideGroup(leftStartPoint, ref num7Left);
            PointHelper.SlideGroup(leftStartPoint, ref num8Left);
            PointHelper.SlideGroup(leftStartPoint, ref num9Left);

            if (doubleDigits)
            {
                PointHelper.SlideGroup(rightStartPoint, ref numDashRight);
                PointHelper.SlideGroup(rightStartPoint, ref num0Right);
                PointHelper.SlideGroup(rightStartPoint, ref num1Right);
                PointHelper.SlideGroup(rightStartPoint, ref num2Right);
                PointHelper.SlideGroup(rightStartPoint, ref num3Right);
                PointHelper.SlideGroup(rightStartPoint, ref num4Right);
                PointHelper.SlideGroup(rightStartPoint, ref num5Right);
                PointHelper.SlideGroup(rightStartPoint, ref num6Right);
                PointHelper.SlideGroup(rightStartPoint, ref num7Right);
                PointHelper.SlideGroup(rightStartPoint, ref num8Right);
                PointHelper.SlideGroup(rightStartPoint, ref num9Right);
            }
        }

        public string GetNumber(Bitmap screen)
        {
            string result = "";

            Dictionary<string, double> dctLeftDigit = new Dictionary<string, double>();
            dctLeftDigit["DASH"] = ScreenTools.GetMatchingPercentage(screen, numDashLeft, true);
            dctLeftDigit["0"] = ScreenTools.GetMatchingPercentage(screen, num0Left, true);
            dctLeftDigit["1"] = ScreenTools.GetMatchingPercentage(screen, num1Left, true);
            dctLeftDigit["2"] = ScreenTools.GetMatchingPercentage(screen, num2Left, true);
            dctLeftDigit["3"] = ScreenTools.GetMatchingPercentage(screen, num3Left, true);
            dctLeftDigit["4"] = ScreenTools.GetMatchingPercentage(screen, num4Left, true);
            dctLeftDigit["5"] = ScreenTools.GetMatchingPercentage(screen, num5Left, true);
            dctLeftDigit["6"] = ScreenTools.GetMatchingPercentage(screen, num6Left, true);
            dctLeftDigit["7"] = ScreenTools.GetMatchingPercentage(screen, num7Left, true);
            dctLeftDigit["8"] = ScreenTools.GetMatchingPercentage(screen, num8Left, true);
            dctLeftDigit["9"] = ScreenTools.GetMatchingPercentage(screen, num9Left, true);

            var matchingLeft = dctLeftDigit.Where(i => i.Value >= 100).ToList();
            if (matchingLeft.Count > 0)
            {
                result += matchingLeft.Last().Key;
            }

            if (doubleDigits)
            {
                Dictionary<string, double> dctRightDigit = new Dictionary<string, double>();
                dctRightDigit["DASH"] = ScreenTools.GetMatchingPercentage(screen, numDashRight, true);
                dctRightDigit["0"] = ScreenTools.GetMatchingPercentage(screen, num0Right, true);
                dctRightDigit["1"] = ScreenTools.GetMatchingPercentage(screen, num1Right, true);
                dctRightDigit["2"] = ScreenTools.GetMatchingPercentage(screen, num2Right, true);
                dctRightDigit["3"] = ScreenTools.GetMatchingPercentage(screen, num3Right, true);
                dctRightDigit["4"] = ScreenTools.GetMatchingPercentage(screen, num4Right, true);
                dctRightDigit["5"] = ScreenTools.GetMatchingPercentage(screen, num5Right, true);
                dctRightDigit["6"] = ScreenTools.GetMatchingPercentage(screen, num6Right, true);
                dctRightDigit["7"] = ScreenTools.GetMatchingPercentage(screen, num7Right, true);
                dctRightDigit["8"] = ScreenTools.GetMatchingPercentage(screen, num8Right, true);
                dctRightDigit["9"] = ScreenTools.GetMatchingPercentage(screen, num9Right, true);

                var matchingRight = dctRightDigit.Where(i => i.Value >= 100).ToList();
                if (matchingRight.Count > 0)
                {
                    result += matchingRight.Last().Key;
                }
            }

            return result;
        }
    }
}
