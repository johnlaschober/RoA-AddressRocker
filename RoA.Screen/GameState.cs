using RoA.Points;
using RoA.Points.PointCollections;
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

        public Dictionary<PlayerState, StockState> dctPlayerStocks;

        public GameState(int startingStockCount, List<PlayerState> players)
        {
            this.startingStockCount = startingStockCount;
            this.players = players;

            dctPlayerStocks = new Dictionary<PlayerState, StockState>();
            foreach (var player in this.players)
            {
                dctPlayerStocks[player] = new StockState(this.startingStockCount);
            }
        }

        public void Sync(Bitmap screen)
        {
            foreach (var player in players)
            {
                double hudPercent = 100;

                switch (player.playerNum)
                {
                    case 1:
                        hudPercent = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P1Hud());
                        break;
                    case 2:
                        hudPercent = ScreenTools.GetMatchingPercentage(screen, PC_PlayerMatchHud.P2Hud());
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }

                if (hudPercent < 80 && !dctPlayerStocks[player].shaking)
                {
                    dctPlayerStocks[player].stockCount--;
                    dctPlayerStocks[player].shaking = true;
                }
                else if (hudPercent >= 100 && dctPlayerStocks[player].shaking)
                {
                    dctPlayerStocks[player].shaking = false;
                }

                if (player.playerNum == 1)
                {
                    Console.WriteLine($"{DateTime.UtcNow}: {player.playerNum}: hudPercent:{hudPercent}: stocks:{dctPlayerStocks[player].stockCount}: shaking:{dctPlayerStocks[player].shaking}");
                }
            }
        }
    }

    public class StockState
    {
        public int stockCount;
        public bool shaking = false;

        public StockState(int stockCount)
        {
            this.stockCount = stockCount;
            this.shaking = false;
        }
    }
}
