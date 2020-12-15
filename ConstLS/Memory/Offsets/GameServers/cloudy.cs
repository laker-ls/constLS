using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstLS.Memory.Offsets.GameServers
{
    public class cloudy : BaseOffsets //1C - offset GA
    {
        new public const Int32
            baseAddress = 0x00C38B6C,
            gameAddress = 0x00C392CC;

        new public struct self
        {
            public const Int32
                structure = 0x34,

                x = 0x00,
                z = 0x00,
                y = 0x00,
                buffs = 0x00,
                HP = 0x4A8,
                MP = 0x4AC,
                maxHP = 0x4F0,
                maxMP = 0x4F4,
                name = 0x688,
                classID = 0x00;
        }

        new public struct mob
        {
            public const Int32
                structure1 = 0x1C,
                structure2 = 0x24,
                structure3 = 0x1C,

                x = 0x03C,
                z = 0x040,
                y = 0x044,
                type = 0x0B4,
                worldID = 0x120,
                HP = 0x130,
                maxHP = 0x178,
                feature = 0x268,
                distance = 0x298;
        }

        new public struct call
        {
            public const Int32
                packet = 0x006F55E0,
                skill = 0x00475740,
                target = 0x006E8060,
                assist = 0x00725750;
        }
    }
}
