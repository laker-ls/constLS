using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstLS.Memory.Offsets.GameServers
{
    public class cloudy : BaseOffsets //1C - offset GA
    {
        public const Int32
            baseAddress = 0x00C38B6C,
            gameAddress = 0x00C392CC;

        public struct self
        {
            public const Int32
                structure = 0x34,

                HP = 0x4A8,
                MP = 0x4AC,
                maxHP = 0x4F0,
                maxMP = 0x4F4,
                name = 0x688,
                classID = 0x00;
        }

        public struct mob
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

        public struct call
        {
            public const Int32
                packet = 0x006F55E0,
                skill = 0x00475740,
                target = 0x006E8060;
        }
    }
}
