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
            newState.TourneySet = SyncTourneySet();
            if (gameState.P1Character.Character == "UNKNOWN" || gameState.P1Character.Character == "RANDOM" || !newState.TourneySet.InMatch)
            {
                newState.P1Character = SyncCharacter(1, gameState.P1Character);
            }
            else
            {
                newState.P1Character = gameState.P1Character;
            }

            if (gameState.P2Character.Character == "UNKNOWN" || gameState.P2Character.Character == "RANDOM" || !newState.TourneySet.InMatch)
            {
                newState.P2Character = SyncCharacter(2, gameState.P2Character);
            }
            else
            {
                newState.P2Character = gameState.P2Character;
            }

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

        private RivalsCharacterSelection SyncCharacter(int iPlayerNum, RivalsCharacterSelection cs)
        {
            if (iPlayerNum != 1 && iPlayerNum != 2) return null;
            RivalsCharacterSelection character = new RivalsCharacterSelection();
            character.Skin = new RivalsSkin();
            if (cs != null && cs.Character != null)
            {
                character.Character = cs.Character;
            }
            if (cs != null && cs.Skin != null)
            {
                character.Skin = new RivalsSkin()
                {
                    SkinDescription = cs.Skin.SkinDescription,
                };
            }

            double dCharacterIndex = 0;
            double dSkinIndex = 0;
            double dSlotActive = 0;
            double dSlotCPU = 0;

            switch (iPlayerNum)
            {
                case 1:
                    dCharacterIndex = (double)_memoryReader.ReadItem(ePointerItem.P1_CHARACTER_INDEX);
                    dSkinIndex = (double)_memoryReader.ReadItem(ePointerItem.P1_SKIN_INDEX);
                    dSlotActive = (double)_memoryReader.ReadItem(ePointerItem.P1_SLOT_ACTIVE);
                    dSlotCPU = (double)_memoryReader.ReadItem(ePointerItem.P1_IS_CPU);
                    break;
                case 2:
                    dCharacterIndex = (double)_memoryReader.ReadItem(ePointerItem.P2_CHARACTER_INDEX);
                    dSkinIndex = (double)_memoryReader.ReadItem(ePointerItem.P2_SKIN_INDEX);
                    dSlotActive = (double)_memoryReader.ReadItem(ePointerItem.P2_SLOT_ACTIVE);
                    dSlotCPU = (double)_memoryReader.ReadItem(ePointerItem.P2_IS_CPU);
                    break;
            }

            dCharacterIndex = Clamp(dCharacterIndex, 0, 30); // Clamping in case we get some crazy values due to a bad pointer
            dSkinIndex = Clamp(dSkinIndex, 0, 30);
            dSlotActive = Clamp(dSlotActive, 0, 30);
            dSlotCPU = Clamp(dSlotCPU, 0, 30);

            character.SlotState = eCharacterSlotState.HMN.ToString();

            if (dSlotActive == 1 && dSlotCPU == 0)
            {
                character.SlotState = eCharacterSlotState.HMN.ToString();
            }
            if (dSlotActive == 1 && dSlotCPU == 1)
            {
                character.SlotState = eCharacterSlotState.CPU.ToString();
            }
            if (dSlotActive == 0)
            {
                character.SlotState = eCharacterSlotState.OFF.ToString();
            }

            switch (dCharacterIndex)
            {
                case -1:
                    character.Character = "UNKNOWN";
                    character.Skin.SkinDescription = "";
                    character.Skin.SkinIndex = 0;
                    break;
                case 0:
                    break;
                case 1:
                    character.Character = "RANDOM";
                    character.Skin.SkinDescription = "";
                    character.Skin.SkinIndex = 0;
                    break;
                case 2:
                    character.Character = "ZETTERBURN";
                    character.Skin.SkinDescription = ((eZetterburnSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 3:
                    character.Character = "ORCANE";
                    character.Skin.SkinDescription = ((eOrcaneSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 4:
                    character.Character = "WRASTOR";
                    character.Skin.SkinDescription = ((eWrastorSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 5:
                    character.Character = "KRAGG";
                    character.Skin.SkinDescription = ((eKraggSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 6:
                    character.Character = "FORSBURN";
                    character.Skin.SkinDescription = ((eForsburnSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 7:
                    character.Character = "MAYPUL";
                    character.Skin.SkinDescription = ((eMaypulSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 9:
                    character.Character = "ETALUS";
                    character.Skin.SkinDescription = ((eEtalusSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 10:
                    character.Character = "ORI AND SEIN";
                    character.Skin.SkinDescription = ((eOriSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 11:
                    character.Character = "RANNO";
                    character.Skin.SkinDescription = ((eRannoSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 12:
                    character.Character = "CLAIREN";
                    character.Skin.SkinDescription = ((eClairenSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 13:
                    character.Character = "SYLVANOS";
                    character.Skin.SkinDescription = ((eSylvanosSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 14:
                    character.Character = "ELLIANA";
                    character.Skin.SkinDescription = ((eEllianaSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 15:
                    character.Character = "SHOVEL KNIGHT";
                    character.Skin.SkinDescription = ((eShovelKnightSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 16:
                    character.Character = "MOLLO";
                    character.Skin.SkinDescription = ((eMolloSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 17:
                    character.Character = "HODAN";
                    character.Skin.SkinDescription = ((eHodanSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 18:
                    character.Character = "POMME";
                    character.Skin.SkinDescription = ((ePommeSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                case 19:
                    character.Character = "OLYMPIA";
                    character.Skin.SkinDescription = ((eOlympiaSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
                    break;
                default:
                    character.Character = "ABSA";
                    character.Skin.SkinDescription = ((eAbsaSkins)(dSkinIndex)).ToString();
                    character.Skin.SkinIndex = (int)dSkinIndex;
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

            double dTourneyCount = (double)_memoryReader.ReadItem(ePointerItem.TOURNEY_MODE_BEST_OF);
            switch (dTourneyCount)
            {
                case 1:
                    returnSet.TourneyModeBestOf = 1;
                    break;
                case 2:
                    returnSet.TourneyModeBestOf = 3;
                    break;
                case 3:
                    returnSet.TourneyModeBestOf = 5;
                    break;
                case 4:
                    returnSet.TourneyModeBestOf = 7;
                    break;
                case 5:
                    returnSet.TourneyModeBestOf = 9;
                    break;
                default:
                    returnSet.TourneyModeBestOf = -1;
                    break;
            }

            return returnSet;
        }

        private bool IsStateDifferent(GameState newState)
        {
            if (gameState.P1Character.Character != newState.P1Character.Character ||
                gameState.P1Character.Skin.SkinDescription != newState.P1Character.Skin.SkinDescription ||
                gameState.P1Character.SlotState != newState.P1Character.SlotState ||
                gameState.P2Character.Character != newState.P2Character.Character ||
                gameState.P2Character.Skin.SkinDescription != newState.P2Character.Skin.SkinDescription ||
                gameState.P2Character.SlotState != newState.P2Character.SlotState ||
                gameState.TourneySet.InMatch != newState.TourneySet.InMatch ||
                gameState.TourneySet.P1GameCount != newState.TourneySet.P1GameCount ||
                gameState.TourneySet.P2GameCount != newState.TourneySet.P2GameCount ||
                gameState.TourneySet.TourneyModeBestOf != newState.TourneySet.TourneyModeBestOf)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private double Clamp(double value, double min, double max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
