using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstLS.Memory
{
    struct Offset
    {
        public const int GA = 0x5B4594;

        public struct Personage
        {
            public const int self = 0x20,
                HP = 0x46C,
                MP = 0x470,
                maxHP = 0x4A4,
                maxMP = 0x4A8,
                type = 0x4AC;
        }
    }
}
