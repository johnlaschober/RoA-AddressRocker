using RoA.Points.PointCollections;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Points.PointObjects
{
    public class PO_MatchPlayerHud
    {
        private int playerNumber = -1;
        private bool isCPU = false;

        private double hudPercent = 100;

        private bool wasShaking = false;

        private int? stockCount = null;
        private bool updateStockCount = true;

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

        private PointCollectionsGroup num0;
        private PointCollectionsGroup num1;
        private PointCollectionsGroup num2;
        private PointCollectionsGroup num3;
        private PointCollectionsGroup num4;
        private PointCollectionsGroup num5;
        private PointCollectionsGroup num6;
        private PointCollectionsGroup num7;
        private PointCollectionsGroup num8;
        private PointCollectionsGroup num9;

        public PO_MatchPlayerHud(int playerNumber, bool isCPU)
        {
            this.playerNumber = playerNumber;
            this.isCPU = isCPU;
            this.updateStockCount = true;

            Point leftStartPoint = new Point(0, 0);
            Point rightStartPoint = new Point(0, 0);
            Point startPoint = new Point(0, 0);

            switch (playerNumber)
            {
                case 1:
                    leftStartPoint = new Point(516, 1032);
                    rightStartPoint = new Point(540, 1032);
                    startPoint = new Point(528, 1032);
                    break;
                case 2:
                    leftStartPoint = new Point(992, 1032);
                    rightStartPoint = new Point(1016, 1032);
                    startPoint = new Point(1004, 1032);
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }

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

            num0 = PointHelper.GetGroupClone(PC_Settings0.Group);
            num1 = PointHelper.GetGroupClone(PC_Settings1.Group);
            num2 = PointHelper.GetGroupClone(PC_Settings2.Group);
            num3 = PointHelper.GetGroupClone(PC_Settings3.Group);
            num4 = PointHelper.GetGroupClone(PC_Settings4.Group);
            num5 = PointHelper.GetGroupClone(PC_Settings5.Group);
            num6 = PointHelper.GetGroupClone(PC_Settings6.Group);
            num7 = PointHelper.GetGroupClone(PC_Settings7.Group);
            num8 = PointHelper.GetGroupClone(PC_Settings8.Group);
            num9 = PointHelper.GetGroupClone(PC_Settings9.Group);

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

            PointHelper.SlideGroup(startPoint, ref num0);
            PointHelper.SlideGroup(startPoint, ref num1);
            PointHelper.SlideGroup(startPoint, ref num2);
            PointHelper.SlideGroup(startPoint, ref num3);
            PointHelper.SlideGroup(startPoint, ref num4);
            PointHelper.SlideGroup(startPoint, ref num5);
            PointHelper.SlideGroup(startPoint, ref num6);
            PointHelper.SlideGroup(startPoint, ref num7);
            PointHelper.SlideGroup(startPoint, ref num8);
            PointHelper.SlideGroup(startPoint, ref num9);
        }

        private string GetStockCountString(Bitmap screen)
        {
            string result = "";

            Dictionary<string, double> dctLeftDigit = new Dictionary<string, double>();
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

            Dictionary<string, double> dctRightDigit = new Dictionary<string, double>();
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

            var matchingLeft = dctLeftDigit.Where(i => i.Value >= 100).ToList();
            var matchingRight = dctRightDigit.Where(i => i.Value >= 100).ToList();

            if (matchingLeft.Count <= 0 && matchingRight.Count <= 0)
            {
                Dictionary<string, double> dctDigit = new Dictionary<string, double>();
                dctDigit["0"] = ScreenTools.GetMatchingPercentage(screen, num0, true);
                dctDigit["1"] = ScreenTools.GetMatchingPercentage(screen, num1, true);
                dctDigit["2"] = ScreenTools.GetMatchingPercentage(screen, num2, true);
                dctDigit["3"] = ScreenTools.GetMatchingPercentage(screen, num3, true);
                dctDigit["4"] = ScreenTools.GetMatchingPercentage(screen, num4, true);
                dctDigit["5"] = ScreenTools.GetMatchingPercentage(screen, num5, true);
                dctDigit["6"] = ScreenTools.GetMatchingPercentage(screen, num6, true);
                dctDigit["7"] = ScreenTools.GetMatchingPercentage(screen, num7, true);
                dctDigit["8"] = ScreenTools.GetMatchingPercentage(screen, num8, true);
                dctDigit["9"] = ScreenTools.GetMatchingPercentage(screen, num9, true);

                var matching = dctDigit.Where(i => i.Value >= 100).ToList();

                if (matching.Count <= 0) return "";

                result += matching.Last().Key;
                return result;
            }
            else
            {
                result += matchingLeft.Last().Key;
                result += matchingRight.Last().Key;
                return result;
            }
        }

        public void UpdateInfo(Bitmap screen, double GAME)
        {
            if (stockCount == null)
            {
                UpdateStockCount(screen);
            }
            else
            {
                var isShaking = IsShaking(screen);
                if (!isShaking && wasShaking)
                {
                    wasShaking = false;
                    UpdateStockCount(screen);
                }
                else if (isShaking && GAME >= 80 && hudPercent < 60)
                {
                    stockCount = 0;
                }
            }
        }

        private void UpdateStockCount(Bitmap screen)
        {
            if (updateStockCount)
            {
                string stockCountString = GetStockCountString(screen);
                if (stockCountString == "")
                {
                    stockCount = null;
                }
                else
                {
                    stockCount = int.Parse(stockCountString);
                }
            }
        }

        public bool IsShaking(Bitmap screen)
        {
            switch (playerNumber)
            {
                case 1:
                    hudPercent = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P1Hud(isCPU));
                    break;
                case 2:
                    hudPercent = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P2Hud(isCPU));
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }

            if (hudPercent < 75)
            {
                wasShaking = true;
                return true;
            }
            return false;
        }

        public int GetStockCount()
        {
            if (stockCount == null) return -1;

            return (int)stockCount;
        }
    }
}
