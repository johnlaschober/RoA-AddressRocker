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
    }

    public class RivalsSkin
    {
        public int SkinIndex { get; set; }
        public string SkinDescription { get; set; }
    }
}
