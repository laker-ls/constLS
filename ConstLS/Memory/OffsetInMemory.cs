using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstLS.Memory
{
    struct OffsetInMemory
    {
        public const Int32 GameAddress = 0x9B4594,
            /** Основные структуры */
            structurePersonage = 0x20,

            /** Свойства персонажа */
            HP = 0x46C,
            MP = 0x470,
            maxHP = 0x4A4,
            maxMP = 0x4A8,
            playerName = 0x608,
            classID = 0x610,

            /** Свойства моба */
            mobX = 0x3C,
            mobZ = 0x40,
            mobY = 0x44,
            mobType = 0xB4,
            mobWorldID = 0x11C,
            mobDist = 0x000, // не нашёл оффсета
            mobName = 0x24C;

        public static Int32[] structureMobs()
        {
            return new Int32[] { 0x8, 0x24, 0x18 };
        }
    }
}
