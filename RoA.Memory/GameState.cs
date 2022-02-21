using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Memory
{
    public class GameState
    {
        public RivalsCharacterSelection P1Character { get; set; }
        public RivalsCharacterSelection P2Character { get; set; }
        public RivalsTourneySet TourneySet { get; set; }
        public GameState()
        {
            P1Character = new RivalsCharacterSelection();
            P2Character = new RivalsCharacterSelection();
            TourneySet = new RivalsTourneySet();
        }
    }
}
