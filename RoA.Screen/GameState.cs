using RoA.Points;
using RoA.Points.PointCollections;
using RoA.Points.PointObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Screen
{
    public class GameState
    {
        private int startingStockCount;
        private List<PlayerState> players;

        public Dictionary<PlayerState, PO_MatchPlayerHud> dctPlayerHuds;

        private bool updateHuds = true;

        public GameState(int startingStockCount, List<PlayerState> players)
        {
            this.startingStockCount = startingStockCount;
            this.players = players;
            this.updateHuds = true;

            dctPlayerHuds = new Dictionary<PlayerState, PO_MatchPlayerHud>();

            int slotPosition = 1;
            foreach (var player in this.players)
            {
                dctPlayerHuds[player] = new PO_MatchPlayerHud(player.playerNum, player.slotType == "CPU", slotPosition, this.players.Count);
                slotPosition++;
            }
        }

        public void Sync(Bitmap screen, ref SetState setState)
        {
            if (updateHuds)
            {
                var dblGAME = ScreenTools.GetMatchingPercentage(screen, PC_GAME.Group);
                var dblSet = ScreenTools.GetMatchingPercentage(screen, PC_GameAndSet.Group);

                foreach (var player in players)
                {
                    dctPlayerHuds[player].UpdateInfo(screen, dblGAME, dblSet);
                }

                if (ScreenTools.GetMatchingPercentage(screen, PC_TIME.Group) >= 100)
                {
                    // TIMEout
                    int winnerPlayerNum = -1;

                    // Need to get all players with max tied stock counts
                    int maxStock = -1;
                    foreach (var player in players)
                    {
                        if (dctPlayerHuds[player].GetStockCount() > maxStock) maxStock = dctPlayerHuds[player].GetStockCount();
                    }

                    List<PlayerState> tiedPlayers = new List<PlayerState>();
                    foreach (var player in players)
                    {
                        if (dctPlayerHuds[player].GetStockCount() == maxStock)
                        {
                            tiedPlayers.Add(player);
                        }
                    }

                    // Need to pick the player with the least percent as the winner
                    int leastPercentage = 1000;
                    int leastPlayerNum = -1;
                    foreach (var player in tiedPlayers)
                    {
                        var damage = dctPlayerHuds[player].GetDamage(screen);
                        int damageInt;
                        if (int.TryParse(damage, out damageInt))
                        {
                            if (damageInt < leastPercentage)
                            {
                                leastPercentage = damageInt;
                                leastPlayerNum = player.playerNum;
                            }
                        }
                    }

                    if (leastPlayerNum != -1)
                    {
                        winnerPlayerNum = leastPlayerNum;
                    }

                    updateHuds = false;
                    UpdateGameCount(winnerPlayerNum, ref setState);
                }
                else
                {
                    int playersWithNoStocks = 0;
                    int winnerPlayerNum = -1;
                    foreach (var player in players)
                    {
                        if (dctPlayerHuds[player].GetStockCount() <= 0)
                        {
                            playersWithNoStocks++;
                        }
                        else
                        {
                            winnerPlayerNum = player.playerNum;
                        }
                    }

                    if (playersWithNoStocks >= players.Count - 1)
                    {
                        updateHuds = false;
                        UpdateGameCount(winnerPlayerNum, ref setState);
                    }
                }
            }
        }

        private void UpdateGameCount(int winnerPlayerNum, ref SetState setState)
        {
            if (setState != null)
            {
                switch (winnerPlayerNum)
                {
                    case 1:
                        setState.P1GameCount++;
                        break;
                    case 2:
                        setState.P2GameCount++;
                        break;
                    case 3:
                        setState.P3GameCount++;
                        break;
                    case 4:
                        setState.P4GameCount++;
                        break;
                }
            }
        }
    }
}
