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
        public string P1SlotType = "";
        public string P2Character = "";
        public string P2SlotType = "";

        public string TourneyBestOf = "";
        public string Stock = "";
        public string Time = "";

        public string P1Stock = "";
        public string P1Shaking = "";
        public string P2Stock = "";
        public string P2Shaking = "";

        public string IsTournamentMode = "";

        public ScreenState GetCopy()
        {
            ScreenState copiedState = new ScreenState()
            {
                ScreenName = this.ScreenName,
                P1Character = this.P1Character,
                P1SlotType = this.P1SlotType,
                P2Character = this.P2Character,
                P2SlotType = this.P2SlotType,
                TourneyBestOf = this.TourneyBestOf,
                Stock = this.Stock,
                Time = this.Time,
                P1Stock = this.P1Stock,
                P1Shaking = this.P1Shaking,
                P2Stock = this.P2Stock,
                P2Shaking = this.P2Shaking,
                IsTournamentMode = this.IsTournamentMode
            };

            return copiedState;
        }
    }
}
