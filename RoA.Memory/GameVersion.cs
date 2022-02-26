using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Memory
{
    public class GameVersion
    {
        public GameVersion()
        {
            PointerItems = new List<PointerItem>();
        }

        public string Version { get; set; }
        public string ExecutableMD5 { get; set; }
        public List<PointerItem> PointerItems { get; set; }
    }

    public class PointerItem
    {
        public PointerItem()
        {
            PointerAddresses = new List<int>();
            Working = true;
        }

        public ePointerItem PointerType { get; set; }
        public Int32 BaseOffset { get; set; }
        public List<Int32> PointerAddresses { get; set; }
        // Properties for AddressTest project DataGridView
        public bool Working { get; set; }
        public double Value { get; set; }
    }
}
