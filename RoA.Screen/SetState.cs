using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Screen
{
    public class SetState
    {
        public int P1GameCount = 0;
        public int P2GameCount = 0;
        public int P3GameCount = 0;
        public int P4GameCount = 0;

        public void Reset()
        {
            P1GameCount = 0;
            P2GameCount = 0;
            P3GameCount = 0;
            P4GameCount = 0;
        }

        public int GetMaxWin()
        {
            List<int> gameCounts = new List<int> { P1GameCount, P2GameCount, P3GameCount, P4GameCount };
            return gameCounts.OrderBy(i => i).ToList().Last();
        }
    }
}
