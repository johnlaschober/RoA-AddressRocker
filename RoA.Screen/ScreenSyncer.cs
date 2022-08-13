using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoA.Points.PointScreens;
using RoA.Points.PointObjects;

namespace RoA.Screen
{
    public class ScreenSyncer
    {
        private Screens screens;
        private Objects objects;

        public ScreenSyncer()
        {
            screens = new Screens();
            objects = new Objects();
        }

        private GameState gameState = null;
        PlayerState p1MatchState;
        PlayerState p2MatchState;
        int stockSetting = 99;

        public ScreenState Sync(Bitmap screen, ScreenState prevState)
        {
            ScreenState newState;

            if (prevState != null)
            {
                newState = prevState.GetCopy();
            }
            else
            {
                newState = new ScreenState();
            }

            if (screens.localCSS.IsActive(screen))
            {
                bool recheckSettings = false;
                if (prevState.ScreenName == "LOCAL SETTINGS")
                {
                    recheckSettings = true;
                }

                newState.ScreenName = "LOCAL CSS";
                newState.P1Character = objects.slot_p1.GetSlotCharacter(screen);
                newState.P2Character = objects.slot_p2.GetSlotCharacter(screen);

                if (newState.P1Character == "UNKNOWN") newState.P1Character = prevState.P1Character;
                if (newState.P2Character == "UNKNOWN") newState.P2Character = prevState.P2Character;
            }
            else if (screens.localSettings.IsActive(screen))
            {
                newState.ScreenName = "LOCAL SETTINGS";

                newState.TourneyBestOf = objects.settings_tourneyBestOfNumber.GetNumber(screen);
                newState.Stock = objects.settings_stockNumber.GetNumber(screen);
                newState.Time = objects.settings_timeNumber.GetNumber(screen);

                int.TryParse(newState.Stock, out stockSetting);
            }
            else if (screens.stageSelect.IsActive(screen))
            {
                newState.ScreenName = "STAGE SELECT";
            }
            else if (screens.localMatch.IsActive(screen))
            {
                if (prevState.ScreenName == "LOCAL CSS" || prevState.ScreenName == "STAGE SELECT")
                {
                    p1MatchState = new PlayerState(1, newState.P1Character);
                    p2MatchState = new PlayerState(2, newState.P2Character);

                    List<PlayerState> gamePlayers = new List<PlayerState>() { p1MatchState, p2MatchState };

                    gameState = new GameState(stockSetting, gamePlayers);
                }

                newState.ScreenName = "LOCAL MATCH";

                if (gameState != null)
                {
                    gameState.Sync(screen);
                    newState.P1Stock = gameState.dctPlayerStocks[p1MatchState].stockCount.ToString();
                    newState.P1Shaking = gameState.dctPlayerStocks[p1MatchState].shaking.ToString();
                    newState.P2Stock = gameState.dctPlayerStocks[p2MatchState].stockCount.ToString();
                    newState.P2Shaking = gameState.dctPlayerStocks[p2MatchState].shaking.ToString();
                }
            }
            else if (screens.pause.IsActive(screen))
            {
                newState.ScreenName = "PAUSE";
            }

            return newState;
        }
    }

    public class Screens
    {
        public PS_LocalVersusCSS localCSS;
        public PS_StageSelect stageSelect;
        public PS_LocalVersusMatch localMatch;
        public PS_Pause pause;
        public PS_LocalVersusSettings localSettings;

        public Screens()
        {
            localCSS = new PS_LocalVersusCSS();
            stageSelect = new PS_StageSelect();
            localMatch = new PS_LocalVersusMatch();
            pause = new PS_Pause();
            localSettings = new PS_LocalVersusSettings();
        }
    }

    public class Objects
    {
        public PO_CSSSlot slot_p1;
        public PO_CSSSlot slot_p2;

        public PO_SettingsNumber settings_tourneyBestOfNumber;
        public PO_SettingsNumber settings_stockNumber;
        public PO_SettingsNumber settings_timeNumber;

        public Objects()
        {
            slot_p1 = new PO_CSSSlot(1);
            slot_p2 = new PO_CSSSlot(2);

            settings_tourneyBestOfNumber = new PO_SettingsNumber(new Point(1144, 242));
            settings_stockNumber = new PO_SettingsNumber(new Point(1144, 298));
            settings_timeNumber = new PO_SettingsNumber(new Point(1144, 354));
        }
    }
}
