using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Screen.State.Internal
{
    public class ScreenState
    {
        public string ScreenName = "";
        public RivalsCharacterSelection P1Character { get; set; }
        public RivalsCharacterSelection P2Character { get; set; }
        public RivalsCharacterSelection P3Character { get; set; }
        public RivalsCharacterSelection P4Character { get; set; }
        public RivalsTourneySet TourneySet { get; set; }

        public ScreenState()
        {
            ScreenName = "";
            P1Character = new RivalsCharacterSelection();
            P2Character = new RivalsCharacterSelection();
            P3Character = new RivalsCharacterSelection();
            P4Character = new RivalsCharacterSelection();
            TourneySet = new RivalsTourneySet();
        }

        public ScreenState GetCopy()
        {
            ScreenState copiedState = new ScreenState()
            {
                P1Character = new RivalsCharacterSelection
                {
                    Character = this.P1Character.Character,
                    Damage = this.P1Character.Damage,
                    SlotState = this.P1Character.SlotState,
                    Stocks = this.P1Character.Stocks
                },
                P2Character = new RivalsCharacterSelection
                {
                    Character = this.P2Character.Character,
                    Damage = this.P2Character.Damage,
                    SlotState = this.P2Character.SlotState,
                    Stocks = this.P2Character.Stocks
                },
                P3Character = new RivalsCharacterSelection
                {
                    Character = this.P3Character.Character,
                    Damage = this.P3Character.Damage,
                    SlotState = this.P3Character.SlotState,
                    Stocks = this.P3Character.Stocks
                },
                P4Character = new RivalsCharacterSelection
                {
                    Character = this.P4Character.Character,
                    Damage = this.P4Character.Damage,
                    SlotState = this.P4Character.SlotState,
                    Stocks = this.P4Character.Stocks
                },
                TourneySet = new RivalsTourneySet
                {
                    InMatch = this.TourneySet.InMatch,
                    Stocks = this.TourneySet.Stocks,
                    Time = this.TourneySet.Time,
                    TourneyModeBestOf = this.TourneySet.TourneyModeBestOf,
                    P1GameCount = this.TourneySet.P1GameCount,
                    P2GameCount = this.TourneySet.P2GameCount,
                    P3GameCount = this.TourneySet.P3GameCount,
                    P4GameCount = this.TourneySet.P4GameCount
                },
                ScreenName = this.ScreenName
            };

            return copiedState;
        }
    }
}
