using RoA.Screen.State.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Screen.State.External
{
    public class ExternalRivalsTourneySet
    {
        public bool InMatch { get; set; } = false;
        public int TourneyModeBestOf { get; set; } = 0;
        public int Stocks { get; set; } = 0;
        public int Time { get; set; } = 0;

        public ExternalRivalsTourneySet(ScreenState ss)
        {
            bool f = false;
            int s = 0;

            bool.TryParse(ss.TourneySet.InMatch, out f);
            this.InMatch = f;

            int.TryParse(ss.TourneySet.TourneyModeBestOf, out s);
            this.TourneyModeBestOf = s;
            int.TryParse(ss.TourneySet.Stocks, out s);
            this.Stocks = s;
            int.TryParse(ss.TourneySet.Time, out s);
            this.Time = s;
        }
    }
}
