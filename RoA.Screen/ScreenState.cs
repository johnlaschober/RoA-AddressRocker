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
        public string P3Character = "";
        public string P4Character = "";

        public string P1SlotType = "";
        public string P2SlotType = "";
        public string P3SlotType = "";
        public string P4SlotType = "";

        public string TourneyBestOf = "";
        public string Stock = "";
        public string Time = "";
        public bool InMatch = false;

        public string P1Stock = "";
        public string P2Stock = "";
        public string P3Stock = "";
        public string P4Stock = "";

        public string P1GameCount = "";
        public string P2GameCount = "";
        public string P3GameCount = "";
        public string P4GameCount = "";

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
                P3Character = this.P3Character,
                P3SlotType = this.P3SlotType,
                P4Character = this.P4Character,
                P4SlotType = this.P4SlotType,
                TourneyBestOf = this.TourneyBestOf,
                Stock = this.Stock,
                Time = this.Time,
                P1Stock = this.P1Stock,
                P2Stock = this.P2Stock,
                P3Stock = this.P3Stock,
                P4Stock = this.P4Stock,
                IsTournamentMode = this.IsTournamentMode,
                InMatch = this.InMatch,
                P1GameCount = this.P1GameCount,
                P2GameCount = this.P2GameCount,
                P3GameCount = this.P3GameCount,
                P4GameCount = this.P4GameCount
            };

            return copiedState;
        }
    }
}
