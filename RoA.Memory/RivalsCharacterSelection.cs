using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Memory
{
    public class RivalsCharacterSelection
    {
        public string Character { get; set; }
        public RivalsSkin Skin { get; set; }
        public string SlotState { get; set;  }

        public RivalsCharacterSelection()
        {
            Character = "UNKNOWN";
            Skin = new RivalsSkin();
            SlotState = "HMN";
        }
    }

    public class RivalsSkin
    {
        public string SkinDescription { get; set; }
        public int SkinIndex { get; set; }


        public RivalsSkin()
        {
            SkinDescription = "UNKNOWN";
        }
    }
}
