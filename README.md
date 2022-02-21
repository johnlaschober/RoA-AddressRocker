# RoA-AddressRocker
Applet to read match data out of Rivals of Aether. A small WinForms application will be run and configured on the machine running Rivals. The configured save location will continuously write a `RoAState.json` file when a change is detected.

### Note for Users
Pointer addresses will need to be updated each time a new game version is released. `GameVersion` objects can be created in the `PointerDirectory` static class to check the running Rivals executable's MD5 hash to determine what pointer addresses to use.

### Current tracked items in `ePointerItem` (as of game version 2.1.1.0)
- P1_CHARACTER_INDEX
- P2_CHARACTER_INDEX
- P1_SKIN_INDEX
- P2_SKIN_INDEX
- P1_GAME_COUNT
- P2_GAME_COUNT
- IN_MATCH
- TOURNEY_MODE_FIRST_TO

### Building
You will need to add back in the git ignored `PointerDirectory.cs` file located in the `RoA.Memory` project. `PointerDirectory` will hold the pointer addresses for the tracked game memory values, such as P1_CHARACTER_INDEX, P1_GAME_COUNT, etc

```
using System;
using System.Collections.Generic;

namespace RoA.Memory
{
    public static class PointerDirectory
    {
        public static List<GameVersion> GameVersions
        {
            get
            {
                List<GameVersion> returnVersions = new List<GameVersion>();

                GameVersion v2_1_1_0 = new GameVersion()
                {
                    Version = "2.1.1.0",
                    BaseOffset = 0x00000000,
                    ExecutableMD5 = "XXXXXXXXXXXXXXXXXXXX",
                    PointerItems = new List<PointerItem>()
                    {
                        new PointerItem()
                        {
                            PointerType = ePointerItem.P1_CHARACTER_INDEX,
                            PointerAddresses = new List<Int32>() { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 }
                        },
                        new PointerItem()
                        {
                            PointerType = ePointerItem.P2_CHARACTER_INDEX,
                            PointerAddresses = new List<Int32>() { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 }
                        }
                };
                returnVersions.Add(v2_1_1_0);

                return returnVersions;
            }
        }
    }
}

```