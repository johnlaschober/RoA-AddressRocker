using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Screen
{
    public class ScreenState
    {
        // temp shit
        public string ScreenName = "";
        public string P1Character = "";
        public string P2Character = "";

        public ScreenState GetCopy()
        {
            ScreenState copiedState = new ScreenState()
            {
                ScreenName = this.ScreenName,
                P1Character = this.P1Character,
                P2Character = this.P2Character
            };

            return copiedState;
        }
    }
}
