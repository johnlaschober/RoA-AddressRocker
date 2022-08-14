using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Screen
{
    public class PlayerState
    {
        public int playerNum;
        public string character;
        public string slotType;

        public PlayerState(int playerNum, string character, string slotType)
        {
            this.playerNum = playerNum;
            this.character = character;
            this.slotType = slotType;
        }
    }
}
