using System;

namespace ConstLS.Memory.Offsets.GameServers
{
    class pw_pvp : BaseOffsets
    {
        new public const Int32 
            baseAddress = 0xA591E0, 
            gameAddress = 0xA59ACC;

        new public struct self
        {
            public const Int32
                structure = 0x34,

                HP = 0x00,
                MP = 0x00,
                maxHP = 0x00,
                maxMP = 0x00,
                name = 0x00,
                classID = 0x00;
        }

        new public struct mob
        {
            public const Int32
                structure1 = 0x00,
                structure2 = 0x00,
                structure3 = 0x00,

                x = 0x00,
                z = 0x00,
                y = 0x00,
                type = 0x00,
                worldID = 0x00,
                distance = 0x00,
                name = 0x00;
        }

        new public struct call
        {
            public const Int32
                packet = 0x0063F890,
                skill = 0x005CC230,
                target = 0x00632150;
        }
    }
}
