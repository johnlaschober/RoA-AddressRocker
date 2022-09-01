using RoA.Screen.State.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Screen.State.External
{
    public class ExternalRivalsCharacterSelection
    {
        public string Character { get; set; } = "";
        public int SlotNumber { get; set; } = 0;
        public string SlotState { get; set; } = "";
        public int Stocks { get; set; } = 0;
        public int Damage { get; set; } = 0;
        public int GameCount { get; set; } = 0;

        public ExternalRivalsCharacterSelection(int SlotNumber, RivalsCharacterSelection rivals, RivalsTourneySet set)
        {
            this.Character = rivals.Character;
            this.SlotState = rivals.SlotState;
            int s = 0;
            int.TryParse(rivals.Stocks, out s);
            this.Stocks = s;
            int.TryParse(rivals.Damage, out s);
            this.Damage = s;

            this.SlotNumber = SlotNumber;

            switch (this.SlotNumber)
            {
                case 1:
                    int.TryParse(set.P1GameCount, out s);
                    break;
                case 2:
                    int.TryParse(set.P2GameCount, out s);
                    break;
                case 3:
                    int.TryParse(set.P3GameCount, out s);
                    break;
                case 4:
                    int.TryParse(set.P4GameCount, out s);
                    break;
                default:
                    s = 0;
                    break;
            }
            this.GameCount = s;
        }
    }
}
