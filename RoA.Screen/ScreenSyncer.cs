using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoA.Points.PointScreens;
using RoA.Points.PointObjects;
using Newtonsoft.Json;
using RoA.Screen.State.Internal;

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

            if (screens.localMenu.IsActive(screen))
            {
                newState.ScreenName = "LOCAL CSS";
                newState.TourneySet.InMatch = "false";

                newState.TourneySet.P1GameCount = "0";
                newState.TourneySet.P2GameCount = "0";
                newState.TourneySet.P3GameCount = "0";
                newState.TourneySet.P4GameCount = "0";

                setState = new SetState();
            }
            else if (screens.localCSS.IsActive(screen))
            {
                if (screens.localCSS.isTournamentMode == null || newState.TourneySet.Stocks == "" || prevState.ScreenName == "LOCAL SETTINGS")
                {
                    screens.localCSS.UpdateSettings(screen);
                    newState.TourneySet.TourneyModeBestOf = screens.localCSS.GetTourneyModeBestOf(screen);
                    newState.TourneySet.Stocks = screens.localCSS.GetStockCount(screen);
                    newState.TourneySet.Time = screens.localCSS.GetTime(screen, newState.TourneySet.Stocks);

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
                    switch (newState.TourneySet.TourneyModeBestOf)
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
                    newState.TourneySet.P1GameCount = "0";
                    newState.TourneySet.P2GameCount = "0";
                    newState.TourneySet.P3GameCount = "0";
                    newState.TourneySet.P4GameCount = "0";
                }

                newState.ScreenName = "LOCAL CSS";
                newState.TourneySet.InMatch = "false";

                if (screens.localCSS.ShouldUpdateCharacters(screen))
                {
                    newState.P1Character.SlotState = screens.localCSS.slot_p1.GetSlotType(screen);
                    newState.P2Character.SlotState = screens.localCSS.slot_p2.GetSlotType(screen);
                    newState.P3Character.SlotState = screens.localCSS.slot_p3.GetSlotType(screen);
                    newState.P4Character.SlotState = screens.localCSS.slot_p4.GetSlotType(screen);

                    if (newState.P1Character.SlotState == "OFF") {
                        newState.P1Character.Character = "";
                    }
                    else {
                        string p1Character = screens.localCSS.slot_p1.GetSlotCharacter(screen);
                        if (p1Character != "UNKNOWN") newState.P1Character.Character = p1Character;
                    }

                    if (newState.P2Character.SlotState == "OFF"){
                        newState.P2Character.Character = "";
                    }
                    else{
                        string p2Character = screens.localCSS.slot_p2.GetSlotCharacter(screen);
                        if (p2Character != "UNKNOWN") newState.P2Character.Character = p2Character;
                    }

                    if (newState.P3Character.SlotState == "OFF"){
                        newState.P3Character.Character = "";
                    }
                    else{
                        string p3Character = screens.localCSS.slot_p3.GetSlotCharacter(screen);
                        if (p3Character != "UNKNOWN") newState.P3Character.Character = p3Character;
                    }

                    if (newState.P4Character.SlotState == "OFF"){
                        newState.P4Character.Character = "";
                    }
                    else{
                        string p4Character = screens.localCSS.slot_p4.GetSlotCharacter(screen);
                        if (p4Character != "UNKNOWN") newState.P4Character.Character = p4Character;
                    }
                }
            }
            else if (screens.localSettings.IsActive(screen))
            {
                newState.ScreenName = "LOCAL SETTINGS";

                newState.TourneySet.TourneyModeBestOf = screens.localSettings.tourneyBestOfNumber.GetNumber(screen);
                newState.TourneySet.Stocks = screens.localSettings.stockNumber.GetNumber(screen);
                newState.TourneySet.Time = screens.localSettings.timeNumber.GetNumber(screen);
                
                newState.TourneySet.InMatch = "false";

                int.TryParse(newState.TourneySet.Stocks, out stockSetting);
            }
            else if (screens.stageSelect.IsActive(screen))
            {
                newState.ScreenName = "STAGE SELECT";
                newState.TourneySet.InMatch = "false";
            }
            else if (screens.localMatch.IsActive(screen))
            {
                if (prevState.ScreenName == "LOCAL CSS" || prevState.ScreenName == "STAGE SELECT")
                {
                    p1MatchState = new PlayerState(1, newState.P1Character.Character, newState.P1Character.SlotState);
                    p2MatchState = new PlayerState(2, newState.P2Character.Character, newState.P2Character.SlotState);
                    p3MatchState = new PlayerState(3, newState.P3Character.Character, newState.P3Character.SlotState);
                    p4MatchState = new PlayerState(4, newState.P4Character.Character, newState.P4Character.SlotState);

                    List<PlayerState> gamePlayers = new List<PlayerState>();

                    if (p1MatchState.slotType != "OFF" && p1MatchState.slotType != "") gamePlayers.Add(p1MatchState);
                    if (p2MatchState.slotType != "OFF" && p2MatchState.slotType != "") gamePlayers.Add(p2MatchState);
                    if (p3MatchState.slotType != "OFF" && p3MatchState.slotType != "") gamePlayers.Add(p3MatchState);
                    if (p4MatchState.slotType != "OFF" && p4MatchState.slotType != "") gamePlayers.Add(p4MatchState);

                    newState.P1Character.Stocks = "";
                    newState.P2Character.Stocks = "";
                    newState.P3Character.Stocks = "";
                    newState.P4Character.Stocks = "";

                    gameState = new GameState(stockSetting, gamePlayers);
                }

                newState.ScreenName = "LOCAL MATCH";
                newState.TourneySet.InMatch = "true";

                if (gameState != null)
                {
                    gameState.Sync(screen, ref setState);
                    if (gameState.dctPlayerHuds.ContainsKey(p1MatchState)) newState.P1Character.Stocks = gameState.dctPlayerHuds[p1MatchState].GetStockCount().ToString();
                    if (gameState.dctPlayerHuds.ContainsKey(p2MatchState)) newState.P2Character.Stocks = gameState.dctPlayerHuds[p2MatchState].GetStockCount().ToString();
                    if (gameState.dctPlayerHuds.ContainsKey(p3MatchState)) newState.P3Character.Stocks = gameState.dctPlayerHuds[p3MatchState].GetStockCount().ToString();
                    if (gameState.dctPlayerHuds.ContainsKey(p4MatchState)) newState.P4Character.Stocks = gameState.dctPlayerHuds[p4MatchState].GetStockCount().ToString();

                    if (gameState.dctPlayerHuds.ContainsKey(p1MatchState))
                    {
                        var damage = gameState.dctPlayerHuds[p1MatchState].GetDamage(screen).ToString();
                        if (!string.IsNullOrEmpty(damage)) newState.P1Character.Damage = damage.ToString();
                    }
                    if (gameState.dctPlayerHuds.ContainsKey(p2MatchState))
                    {
                        var damage = gameState.dctPlayerHuds[p2MatchState].GetDamage(screen).ToString();
                        if (!string.IsNullOrEmpty(damage)) newState.P2Character.Damage = damage.ToString();
                    }
                    if (gameState.dctPlayerHuds.ContainsKey(p3MatchState))
                    {
                        var damage = gameState.dctPlayerHuds[p3MatchState].GetDamage(screen).ToString();
                        if (!string.IsNullOrEmpty(damage)) newState.P3Character.Damage = damage.ToString();
                    }
                    if (gameState.dctPlayerHuds.ContainsKey(p4MatchState))
                    {
                        var damage = gameState.dctPlayerHuds[p4MatchState].GetDamage(screen).ToString();
                        if (!string.IsNullOrEmpty(damage)) newState.P4Character.Damage = damage.ToString();
                    }

                    if (setState != null)
                    {
                        newState.TourneySet.P1GameCount = setState.P1GameCount.ToString();
                        newState.TourneySet.P2GameCount = setState.P2GameCount.ToString();
                        newState.TourneySet.P3GameCount = setState.P3GameCount.ToString();
                        newState.TourneySet.P4GameCount = setState.P4GameCount.ToString();
                    }
                    else
                    {
                        newState.TourneySet.P1GameCount = "0";
                        newState.TourneySet.P2GameCount = "0";
                        newState.TourneySet.P3GameCount = "0";
                        newState.TourneySet.P4GameCount = "0";
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
                newState.TourneySet.InMatch = "true";
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
        public PS_LocalMenu localMenu;

        public Screens()
        {
            localCSS = new PS_LocalVersusCSS();
            stageSelect = new PS_StageSelect();
            localMatch = new PS_LocalVersusMatch();
            pause = new PS_Pause();
            localSettings = new PS_LocalVersusSettings();
            localMenu = new PS_LocalMenu();
        }
    }
}
