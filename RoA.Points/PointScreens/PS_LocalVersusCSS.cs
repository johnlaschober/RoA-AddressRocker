using System;
using System.Drawing;
using RoA.Points.PointCollections;
using RoA.Points.PointObjects;

namespace RoA.Points.PointScreens
{
    public class PS_LocalVersusCSS : IPS
    {
        public PO_CSSSlot slot_p1;
        public PO_CSSSlot slot_p2;
        public PO_CSSSlot slot_p3;
        public PO_CSSSlot slot_p4;

        public bool? isTournamentMode = null;
        private PO_SettingsNumber numTourneyModeBestOf;

        private PO_SettingsNumber numStocks_NoTourney;
        private PO_SettingsNumber numStocks_Tourney;

        private PO_SettingsNumber numTime_DoubleDigitStocks_NoTourney;
        private PO_SettingsNumber numTime_DoubleDigitStocks_Tourney;

        private PO_SettingsNumber numTime_SingleDigitStocks_NoTourney;
        private PO_SettingsNumber numTime_SingleDigitStocks_Tourney;

        public PS_LocalVersusCSS()
        {
            slot_p1 = new PO_CSSSlot(1);
            slot_p2 = new PO_CSSSlot(2);
            slot_p3 = new PO_CSSSlot(3);
            slot_p4 = new PO_CSSSlot(4);
            numTourneyModeBestOf = new PO_SettingsNumber(new Point(890, 48), false);

            numStocks_NoTourney = new PO_SettingsNumber(new Point(890, 48), true);
            numStocks_Tourney = new PO_SettingsNumber(new Point(986, 48), true);

            numTime_SingleDigitStocks_NoTourney = new PO_SettingsNumber(new Point(986, 48), true);
            numTime_SingleDigitStocks_Tourney = new PO_SettingsNumber(new Point(1082, 48), true);

            numTime_DoubleDigitStocks_NoTourney = new PO_SettingsNumber(new Point(1006, 48), true);
            numTime_DoubleDigitStocks_Tourney = new PO_SettingsNumber(new Point(1102, 48), true);
        }

        public bool IsActive(Bitmap screen)
        {
            double purpleBanner = ScreenTools.GetMatchingPercentage(screen, PC_PurpleBanner.Group);
            if (purpleBanner < 30) return false;

            double versusModeText = ScreenTools.GetMatchingPercentage(screen, PC_VersusModeText.Group);
            double tourneyModeText = ScreenTools.GetMatchingPercentage(screen, PC_TourneyModeText.Group);
            if (versusModeText < 30 && tourneyModeText < 30) return false;

            double changeRules = ScreenTools.GetMatchingPercentage(screen, PC_ChangeRules.Group);
            if (changeRules > 90) return true;

            double musicButton = ScreenTools.GetMatchingPercentage(screen, PC_StageSelectMusicButton.Group);
            return musicButton < 50;
        }

        public bool ShouldUpdateCharacters(Bitmap screen)
        {
            double characters = ScreenTools.GetMatchingPercentage(screen, PC_CSSCharacterNames.Group);

            return characters > 70;
        }

        public void UpdateSettings(Bitmap screen)
        {
            isTournamentMode = ScreenTools.GetMatchingPercentage(screen, PC_TourneyModeIcon.Group) > 70;
        }

        public string GetTourneyModeBestOf(Bitmap screen)
        {
            if (isTournamentMode != null && isTournamentMode == true)
            {
                return numTourneyModeBestOf.GetNumber(screen);
            }
            else
            {
                return "";
            }
        }

        public string GetStockCount(Bitmap screen)
        {
            if (isTournamentMode != null && (bool)isTournamentMode)
            {
                return numStocks_Tourney.GetNumber(screen);
            }
            else
            {
                return numStocks_NoTourney.GetNumber(screen);
            }
        }

        public string GetTime(Bitmap screen, string stockCount)
        {
            if (isTournamentMode != null && (bool)isTournamentMode)
            {
                if (stockCount.Length > 1)
                {
                    return numTime_DoubleDigitStocks_Tourney.GetNumber(screen);
                }
                else
                {
                    return numTime_SingleDigitStocks_Tourney.GetNumber(screen);
                }
            }
            else
            {
                if (stockCount.Length > 1)
                {
                    return numTime_DoubleDigitStocks_NoTourney.GetNumber(screen);
                }
                else
                {
                    return numTime_SingleDigitStocks_NoTourney.GetNumber(screen);
                }
            }
        }
    }
}
