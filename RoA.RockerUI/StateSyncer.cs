using Newtonsoft.Json;
using RoA.Logic;
using RoA.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.RockerUI
{
    public class StateSyncer
    {
        private MemoryReader _memoryReader;
        public GameState gameState;
        public StateSyncer(MemoryReader memoryReader)
        {
            _memoryReader = memoryReader;
            gameState = new GameState();
        }

        public bool Sync()
        {
            GameState newState = new GameState();
            newState.P1Character = SyncCharacter(1);
            newState.P2Character = SyncCharacter(2);
            newState.TourneySet = SyncTourneySet();

            if (IsStateDifferent(newState))
            {
                gameState = newState;
                return true;
            }
            else
            {
                return false;
            }
        }

        private RivalsCharacterSelection SyncCharacter(int iPlayerNum)
        {
            if (iPlayerNum != 1 && iPlayerNum != 2) return null;
            RivalsCharacterSelection character = new RivalsCharacterSelection();
            character.Skin = new RivalsSkin();

            double dCharacterIndex = 1;
            double dSkinIndex = 0;

            switch (iPlayerNum)
            {
                case 1:
                    dCharacterIndex = (double)_memoryReader.ReadItem(ePointerItem.P1_CHARACTER_INDEX);
                    dSkinIndex = (double)_memoryReader.ReadItem(ePointerItem.P1_SKIN_INDEX);
                    break;
                case 2:
                    dCharacterIndex = (double)_memoryReader.ReadItem(ePointerItem.P2_CHARACTER_INDEX);
                    dSkinIndex = (double)_memoryReader.ReadItem(ePointerItem.P2_SKIN_INDEX);
                    break;
            }
            character.Skin.SkinIndex = (int)dSkinIndex;

            switch (dCharacterIndex)
            {
                case -1:
                    character.Character = "ADDRESS_ERROR";
                    break;
                case 0:
                    character.Character = "NONE";
                    break;
                case 1:
                    character.Character = "RANDOM";
                    break;
                case 2:
                    character.Character = "ZETTERBURN";
                    break;
                case 3:
                    character.Character = "ORCANE";
                    break;
                case 4:
                    character.Character = "WRASTOR";
                    break;
                case 5:
                    character.Character = "KRAGG";
                    break;
                case 6:
                    character.Character = "FORSBURN";
                    break;
                case 7:
                    character.Character = "MAYPUL";
                    break;
                case 9:
                    character.Character = "ETALUS";
                    break;
                case 10:
                    character.Character = "ORI";
                    break;
                case 11:
                    character.Character = "RANNO";
                    break;
                case 12:
                    character.Character = "CLAIREN";
                    break;
                case 13:
                    character.Character = "SYLVANOS";
                    break;
                case 14:
                    character.Character = "ELLIANA";
                    break;
                case 15:
                    character.Character = "SHOVEL_KNIGHT";
                    break;
                case 16:
                    character.Character = "MOLLO";
                    break;
                case 17:
                    character.Character = "HODAN";
                    break;
                case 18:
                    character.Character = "POMME";
                    break;
                case 19:
                    character.Character = "OLYMPIA";
                    break;
                default:
                    character.Character = "ABSA";
                    break;
            }

            return character;
        }

        private RivalsTourneySet SyncTourneySet()
        {
            RivalsTourneySet returnSet = new RivalsTourneySet();
            returnSet.InMatch = (int)(((double)_memoryReader.ReadItem(ePointerItem.IN_MATCH))) == 1;
            returnSet.P1GameCount = (int)((double)_memoryReader.ReadItem(ePointerItem.P1_GAME_COUNT));
            returnSet.P2GameCount = (int)((double)_memoryReader.ReadItem(ePointerItem.P2_GAME_COUNT));

            double dTourneyCount = (double)_memoryReader.ReadItem(ePointerItem.TOURNEY_MODE_FIRST_TO);
            switch (dTourneyCount)
            {
                case 1:
                    returnSet.TourneyModeFirstTo = 1;
                    break;
                case 2:
                    returnSet.TourneyModeFirstTo = 3;
                    break;
                case 3:
                    returnSet.TourneyModeFirstTo = 5;
                    break;
                case 4:
                    returnSet.TourneyModeFirstTo = 7;
                    break;
                case 5:
                    returnSet.TourneyModeFirstTo = 9;
                    break;
                default:
                    returnSet.TourneyModeFirstTo = -1;
                    break;
            }

            return returnSet;
        }

        private bool IsStateDifferent(GameState newState)
        {
            if (gameState.P1Character.Character != newState.P1Character.Character ||
                gameState.P1Character.Skin.SkinIndex != newState.P1Character.Skin.SkinIndex ||
                gameState.P2Character.Character != newState.P2Character.Character ||
                gameState.P2Character.Skin.SkinIndex != newState.P2Character.Skin.SkinIndex ||
                gameState.TourneySet.InMatch != newState.TourneySet.InMatch ||
                gameState.TourneySet.P1GameCount != newState.TourneySet.P1GameCount ||
                gameState.TourneySet.P2GameCount != newState.TourneySet.P2GameCount ||
                gameState.TourneySet.TourneyModeFirstTo != newState.TourneySet.TourneyModeFirstTo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
