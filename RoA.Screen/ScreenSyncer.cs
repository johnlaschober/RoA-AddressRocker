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

        public ScreenSyncer()
        {
            screens = new Screens();
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
                if (screens.localCSS.isTournamentMode == null || prevState.ScreenName == "LOCAL SETTINGS")
                {
                    screens.localCSS.UpdateSettings(screen);
                    newState.IsTournamentMode = screens.localCSS.isTournamentMode.ToString();
                    newState.TourneyBestOf = screens.localCSS.GetTourneyModeBestOf(screen);
                }

                newState.ScreenName = "LOCAL CSS";
                newState.P1Character = screens.localCSS.slot_p1.GetSlotCharacter(screen);
                newState.P1SlotType = screens.localCSS.slot_p1.GetSlotType(screen);
                newState.P2Character = screens.localCSS.slot_p2.GetSlotCharacter(screen);
                newState.P2SlotType = screens.localCSS.slot_p2.GetSlotType(screen);

                if (newState.P1Character == "UNKNOWN")
                {
                    newState.P1Character = prevState.P1Character;
                    newState.P1SlotType = prevState.P1SlotType;
                }
                if (newState.P2Character == "UNKNOWN")
                {
                    newState.P2Character = prevState.P2Character;
                    newState.P2SlotType = prevState.P2SlotType;
                }
            }
            else if (screens.localSettings.IsActive(screen))
            {
                newState.ScreenName = "LOCAL SETTINGS";

                newState.TourneyBestOf = screens.localSettings.tourneyBestOfNumber.GetNumber(screen);
                newState.Stock = screens.localSettings.stockNumber.GetNumber(screen);
                newState.Time = screens.localSettings.timeNumber.GetNumber(screen);

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
                    p1MatchState = new PlayerState(1, newState.P1Character, newState.P1SlotType);
                    p2MatchState = new PlayerState(2, newState.P2Character, newState.P2SlotType);

                    List<PlayerState> gamePlayers = new List<PlayerState>() { p1MatchState, p2MatchState };

                    gameState = new GameState(stockSetting, gamePlayers);
                }

                newState.ScreenName = "LOCAL MATCH";

                if (gameState != null)
                {
                    gameState.Sync(screen);
                    newState.P1Stock = gameState.dctPlayerHuds[p1MatchState].GetStockCount().ToString();
                    newState.P2Stock = gameState.dctPlayerHuds[p2MatchState].GetStockCount().ToString();
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
}
