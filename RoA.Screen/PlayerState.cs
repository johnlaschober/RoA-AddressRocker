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

        public PlayerState(int playerNum, string character)
        {
            this.playerNum = playerNum;
            this.character = character;
        }
    }
}
