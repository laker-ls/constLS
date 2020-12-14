using System;

namespace ConstLS.Memory.Offsets.GameServers
{
    class pwclassic_net : BaseOffsets
    {
        new public const Int32
            baseAddress = 0x009B3EEC,
            gameAddress = 0x009B4594;

        new public struct self
        {
            public const Int32
                structure = 0x20,

                HP = 0x46C,
                MP = 0x470,
                maxHP = 0x4A4,
                maxMP = 0x4A8,
                name = 0x608,
                classID = 0x610;
        }

        new public struct mob
        {
            public const Int32
                structure1 = 0x08,
                structure2 = 0x24,
                structure3 = 0x18,

                x = 0x3C,
                z = 0x40,
                y = 0x44,
                type = 0xB4,
                worldID = 0x11C,
                distance = 0x00,
                name = 0x24C;
        }

        new public struct call
        {
            public const Int32
                packet = 0x005D2350,
                skill = 0x005CC230,
                target = 0x005CC0C0;
        }
    }
}
