using RoA.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Binarysharp.MemoryManagement;

namespace RoA.Logic
{
    public class MemoryReader
    {
        private Process _gameProcess = null;
        private ProcessModule _gameModule = null;
        public GameVersion _gameVersion = null;

        public MemoryReader(Process gameProcess, GameVersion version)
        {
            _gameProcess = gameProcess;
            _gameVersion = version;
            foreach (ProcessModule pm in _gameProcess.Modules)
            {
                if (pm.ModuleName == String.Format("{0}.exe", Constants.ExecutableName))
                {
                    _gameModule = pm;
                }
            }
        }

        public object ReadItem(ePointerItem itemToRead)
        {
            switch (itemToRead)
            {
                case ePointerItem.P1_CHARACTER_INDEX:
                    return ReadGameMakerDouble(_gameVersion.PointerItems.Where(x => x.PointerType == ePointerItem.P1_CHARACTER_INDEX).ToList().First());
                case ePointerItem.P2_CHARACTER_INDEX:
                    return ReadGameMakerDouble(_gameVersion.PointerItems.Where(x => x.PointerType == ePointerItem.P2_CHARACTER_INDEX).ToList().First());
                case ePointerItem.P1_SKIN_INDEX:
                    return ReadGameMakerDouble(_gameVersion.PointerItems.Where(x => x.PointerType == ePointerItem.P1_SKIN_INDEX).ToList().First());
                case ePointerItem.P2_SKIN_INDEX:
                    return ReadGameMakerDouble(_gameVersion.PointerItems.Where(x => x.PointerType == ePointerItem.P2_SKIN_INDEX).ToList().First());
                case ePointerItem.P1_GAME_COUNT:
                    return ReadGameMakerDouble(_gameVersion.PointerItems.Where(x => x.PointerType == ePointerItem.P1_GAME_COUNT).ToList().First());
                case ePointerItem.P2_GAME_COUNT:
                    return ReadGameMakerDouble(_gameVersion.PointerItems.Where(x => x.PointerType == ePointerItem.P2_GAME_COUNT).ToList().First());
                case ePointerItem.IN_MATCH:
                    return ReadGameMakerDouble(_gameVersion.PointerItems.Where(x => x.PointerType == ePointerItem.IN_MATCH).ToList().First());
                case ePointerItem.TOURNEY_MODE_FIRST_TO:
                    return ReadGameMakerDouble(_gameVersion.PointerItems.Where(x => x.PointerType == ePointerItem.TOURNEY_MODE_FIRST_TO).ToList().First());
                default:
                    return null;
            }
        }

        private double ReadGameMakerDouble(PointerItem pointerItem)
        {
            try
            {
                using (var sharp = new MemorySharp(_gameProcess.Id))
                {
                    List<Int32> offsets = pointerItem.PointerAddresses;

                    IntPtr _readMe = _gameModule.BaseAddress + pointerItem.BaseOffset;

                    for (int i = offsets.Count - 1; i >= 0; i--)
                    {
                        IntPtr tmp = sharp.Read<IntPtr>(_readMe, false);
                        IntPtr tmp_Ptr = tmp + offsets[i];
                        _readMe = tmp_Ptr;
                    }

                    double d = sharp.Read<double>(_readMe, false);
                    return d;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
