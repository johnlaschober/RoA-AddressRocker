using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoA.Points.PointScreens;
using RoA.Points.PointObjects;
using Newtonsoft.Json;

namespace RoA.Screen
{
    public class ScreenSyncer
    {
        private Screens screens;

        public ScreenState prevState;
        public GameState gameState = null;
        public SetState setState = null;

        public ScreenSyncer()
        {
            screens = new Screens();
        }

        PlayerState p1MatchState;
        PlayerState p2MatchState;
        PlayerState p3MatchState;
        PlayerState p4MatchState;
        int stockSetting = 99;

        public (bool, ScreenState) Sync(Bitmap screen)
        {
            ScreenState newState;
            newState = prevState == null ? new ScreenState() : prevState.GetCopy();

            if (screens.localCSS.IsActive(screen))
            {
                if (screens.localCSS.isTournamentMode == null || newState.Stock == "" || prevState.ScreenName == "LOCAL SETTINGS")
                {
                    screens.localCSS.UpdateSettings(screen);
                    newState.IsTournamentMode = screens.localCSS.isTournamentMode.ToString();
                    newState.TourneyBestOf = screens.localCSS.GetTourneyModeBestOf(screen);
                    newState.Stock = screens.localCSS.GetStockCount(screen);
                    newState.Time = screens.localCSS.GetTime(screen, newState.Stock);

                    if (screens.localCSS.isTournamentMode != null &&
                        (bool)screens.localCSS.isTournamentMode == true && 
                        setState == null)
                    {
                        setState = new SetState();
                    }
                    else if (screens.localCSS.isTournamentMode != null &&
                        (bool)screens.localCSS.isTournamentMode == false)
                    {
                        setState = null;
                    }
                }

                bool resetSet = false;
                if (setState != null)
                {
                    switch (newState.TourneyBestOf)
                    {
                        case "1":
                            if (setState.GetMaxWin() >= 1)
                            {
                                setState.Reset();
                                resetSet = true;
                            }
                            break;
                        case "3":
                            if (setState.GetMaxWin() >= 2)
                            {
                                setState.Reset();
                                resetSet = true;
                            }
                            break;
                        case "5":
                            if (setState.GetMaxWin() >= 3)
                            {
                                setState.Reset();
                                resetSet = true;
                            }
                            break;
                        case "7":
                            if (setState.GetMaxWin() >= 4)
                            {
                                setState.Reset();
                                resetSet = true;
                            }
                            break;
                        case "9":
                            if (setState.GetMaxWin() >= 5)
                            {
                                setState.Reset();
                                resetSet = true;
                            }
                            break;
                    }
                }

                if (resetSet)
                {
                    newState.P1GameCount = "0";
                    newState.P2GameCount = "0";
                    newState.P3GameCount = "0";
                    newState.P4GameCount = "0";
                }

                newState.ScreenName = "LOCAL CSS";
                newState.InMatch = false;

                if (screens.localCSS.ShouldUpdateCharacters(screen))
                {
                    newState.P1SlotType = screens.localCSS.slot_p1.GetSlotType(screen);
                    newState.P2SlotType = screens.localCSS.slot_p2.GetSlotType(screen);
                    newState.P3SlotType = screens.localCSS.slot_p3.GetSlotType(screen);
                    newState.P4SlotType = screens.localCSS.slot_p4.GetSlotType(screen);

                    if (newState.P1SlotType == "OFF") {
                        newState.P1Character = "";
                    }
                    else {
                        string p1Character = screens.localCSS.slot_p1.GetSlotCharacter(screen);
                        if (p1Character != "UNKNOWN") newState.P1Character = p1Character;
                    }

                    if (newState.P2SlotType == "OFF"){
                        newState.P2Character = "";
                    }
                    else{
                        string p2Character = screens.localCSS.slot_p2.GetSlotCharacter(screen);
                        if (p2Character != "UNKNOWN") newState.P2Character = p2Character;
                    }

                    if (newState.P3SlotType == "OFF"){
                        newState.P3Character = "";
                    }
                    else{
                        string p3Character = screens.localCSS.slot_p3.GetSlotCharacter(screen);
                        if (p3Character != "UNKNOWN") newState.P3Character = p3Character;
                    }

                    if (newState.P4SlotType == "OFF"){
                        newState.P4Character = "";
                    }
                    else{
                        string p4Character = screens.localCSS.slot_p4.GetSlotCharacter(screen);
                        if (p4Character != "UNKNOWN") newState.P4Character = p4Character;
                    }
                }
            }
            else if (screens.localSettings.IsActive(screen))
            {
                newState.ScreenName = "LOCAL SETTINGS";

                newState.TourneyBestOf = screens.localSettings.tourneyBestOfNumber.GetNumber(screen);
                newState.Stock = screens.localSettings.stockNumber.GetNumber(screen);
                newState.Time = screens.localSettings.timeNumber.GetNumber(screen);
                
                newState.InMatch = false;

                int.TryParse(newState.Stock, out stockSetting);
            }
            else if (screens.stageSelect.IsActive(screen))
            {
                newState.ScreenName = "STAGE SELECT";
                newState.InMatch = false;
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

                    newState.P1Stock = "";
                    newState.P2Stock = "";
                    newState.P3Stock = "";
                    newState.P4Stock = "";

                    gameState = new GameState(stockSetting, gamePlayers);
                }

                newState.ScreenName = "LOCAL MATCH";
                newState.InMatch = true;

                if (gameState != null)
                {
                    gameState.Sync(screen, setState);
                    if (gameState.dctPlayerHuds.ContainsKey(p1MatchState)) newState.P1Stock = gameState.dctPlayerHuds[p1MatchState].GetStockCount().ToString();
                    if (gameState.dctPlayerHuds.ContainsKey(p2MatchState)) newState.P2Stock = gameState.dctPlayerHuds[p2MatchState].GetStockCount().ToString();
                    if (gameState.dctPlayerHuds.ContainsKey(p3MatchState)) newState.P3Stock = gameState.dctPlayerHuds[p3MatchState].GetStockCount().ToString();
                    if (gameState.dctPlayerHuds.ContainsKey(p4MatchState)) newState.P4Stock = gameState.dctPlayerHuds[p4MatchState].GetStockCount().ToString();

                    if (setState != null)
                    {
                        newState.P1GameCount = setState.P1GameCount.ToString();
                        newState.P2GameCount = setState.P2GameCount.ToString();
                        newState.P3GameCount = setState.P3GameCount.ToString();
                        newState.P4GameCount = setState.P4GameCount.ToString();
                    }
                    else
                    {
                        newState.P1GameCount = "";
                        newState.P2GameCount = "";
                        newState.P3GameCount = "";
                        newState.P4GameCount = "";
                    }
                }
                else if (gameState == null)
                {
                    // Need to call local match to find players and set up a new game state
                }
            }
            else if (screens.pause.IsActive(screen))
            {
                newState.ScreenName = "PAUSE";
                newState.InMatch = true;
            }

            var returnTuple = (ChangesOccurred(prevState, newState), newState);
            prevState = newState;

            return returnTuple;
        }

        private bool ChangesOccurred(ScreenState prev, ScreenState current)
        {
            string sPrev = JsonConvert.SerializeObject(prev);
            string sCurrent = JsonConvert.SerializeObject(current);

            return sPrev != sCurrent;
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
