using RoA.Screen.State.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Screen.State.External
{
    public class ExternalScreenState
    {
        public string ScreenName = "";
        public List<ExternalRivalsCharacterSelection> Characters = new List<ExternalRivalsCharacterSelection>();
        public ExternalRivalsTourneySet TourneySet { get; set; }

        public ExternalScreenState(ScreenState screenState)
        {
            this.ScreenName = screenState.ScreenName;
            this.TourneySet = new ExternalRivalsTourneySet(screenState);

            Characters.Add(new ExternalRivalsCharacterSelection(1, screenState.P1Character, screenState.TourneySet));
            Characters.Add(new ExternalRivalsCharacterSelection(2, screenState.P2Character, screenState.TourneySet));
            Characters.Add(new ExternalRivalsCharacterSelection(3, screenState.P3Character, screenState.TourneySet));
            Characters.Add(new ExternalRivalsCharacterSelection(4, screenState.P4Character, screenState.TourneySet));
        }
    }
}
