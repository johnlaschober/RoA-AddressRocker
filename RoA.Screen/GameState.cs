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

            foreach (var player in this.players)
            {
                dctPlayerHuds[player] = new PO_MatchPlayerHud(player.playerNum, player.slotType == "CPU");
            }
        }

        public void Sync(Bitmap screen)
        {
            if (updateHuds)
            {
                var dblGAME = ScreenTools.GetMatchingPercentage(screen, PC_GAME.Group);

                foreach (var player in players)
                {
                    dctPlayerHuds[player].UpdateInfo(screen, dblGAME);

                    if (player.playerNum == 1)
                    {
                        Console.WriteLine($"{DateTime.UtcNow}: {player.playerNum}: stocks:{dctPlayerHuds[player].GetStockCount()}");
                    }
                }

                int playersWithNoStocks = 0;
                foreach (var player in players)
                {
                    if (dctPlayerHuds[player].GetStockCount() <= 0)
                    {
                        playersWithNoStocks++;
                    }
                }
                if (playersWithNoStocks >= players.Count - 1)
                {
                    updateHuds = false;
                }
            }
        }
    }
}
