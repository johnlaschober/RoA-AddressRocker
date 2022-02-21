using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Memory
{
    public class GameVersion
    {
        public string Version { get; set; }
        public string ExecutableMD5 { get; set; }
        public List<PointerItem> PointerItems { get; set; }
    }

    public class PointerItem
    {
        public ePointerItem PointerType { get; set; }
        public Int32 BaseOffset { get; set; }
        public List<Int32> PointerAddresses { get; set; }
    }
}
