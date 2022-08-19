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
        PlayerState p3MatchState;
        PlayerState p4MatchState;
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
                if (screens.localCSS.isTournamentMode == null || newState.Stock == "" || prevState.ScreenName == "LOCAL SETTINGS")
                {
                    screens.localCSS.UpdateSettings(screen);
                    newState.IsTournamentMode = screens.localCSS.isTournamentMode.ToString();
                    newState.TourneyBestOf = screens.localCSS.GetTourneyModeBestOf(screen);
                    newState.Stock = screens.localCSS.GetStockCount(screen);
                    newState.Time = screens.localCSS.GetTime(screen, newState.Stock);
                }

                newState.ScreenName = "LOCAL CSS";

                if (screens.localCSS.ShouldUpdateCharacters(screen))
                {
                    newState.P1Character = screens.localCSS.slot_p1.GetSlotCharacter(screen);
                    newState.P1SlotType = screens.localCSS.slot_p1.GetSlotType(screen);
                    newState.P2Character = screens.localCSS.slot_p2.GetSlotCharacter(screen);
                    newState.P2SlotType = screens.localCSS.slot_p2.GetSlotType(screen);
                    newState.P3Character = screens.localCSS.slot_p3.GetSlotCharacter(screen);
                    newState.P3SlotType = screens.localCSS.slot_p3.GetSlotType(screen);
                    newState.P4Character = screens.localCSS.slot_p4.GetSlotCharacter(screen);
                    newState.P4SlotType = screens.localCSS.slot_p4.GetSlotType(screen);
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
                    p3MatchState = new PlayerState(3, newState.P3Character, newState.P3SlotType);
                    p4MatchState = new PlayerState(4, newState.P4Character, newState.P4SlotType);

                    List<PlayerState> gamePlayers = new List<PlayerState>();

                    if (p1MatchState.slotType != "OFF" && p1MatchState.slotType != "") gamePlayers.Add(p1MatchState);
                    if (p2MatchState.slotType != "OFF" && p2MatchState.slotType != "") gamePlayers.Add(p2MatchState);
                    if (p3MatchState.slotType != "OFF" && p3MatchState.slotType != "") gamePlayers.Add(p3MatchState);
                    if (p4MatchState.slotType != "OFF" && p4MatchState.slotType != "") gamePlayers.Add(p4MatchState);

                    gameState = new GameState(stockSetting, gamePlayers);
                }

                newState.ScreenName = "LOCAL MATCH";

                if (gameState != null)
                {
                    gameState.Sync(screen);
                    if (gameState.dctPlayerHuds.ContainsKey(p1MatchState)) newState.P1Stock = gameState.dctPlayerHuds[p1MatchState].GetStockCount().ToString();
                    if (gameState.dctPlayerHuds.ContainsKey(p2MatchState)) newState.P2Stock = gameState.dctPlayerHuds[p2MatchState].GetStockCount().ToString();
                    if (gameState.dctPlayerHuds.ContainsKey(p3MatchState)) newState.P3Stock = gameState.dctPlayerHuds[p3MatchState].GetStockCount().ToString();
                    if (gameState.dctPlayerHuds.ContainsKey(p4MatchState)) newState.P4Stock = gameState.dctPlayerHuds[p4MatchState].GetStockCount().ToString();
                }
                else if (gameState == null)
                {
                    // Need to call local match to find players and set up a new game state
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
