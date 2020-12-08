using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstLS
{
    struct Offset
    {
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
