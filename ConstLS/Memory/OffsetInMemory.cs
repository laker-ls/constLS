using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstLS.Memory
{
    //struct OffsetInMemory
    //{
    //    public const Int32 BaseAddress = 0x009B3EEC, GameAddress = 0x009B4594, //1C - offset GA
    //        structurePersonage = 0x20,

    //        /** Свойства персонажа */
    //        HP = 0x46C,
    //        MP = 0x470,
    //        maxHP = 0x4A4,
    //        maxMP = 0x4A8,
    //        playerName = 0x608,
    //        classID = 0x610,
    //        useSkill = 0x6C4,

    //        /** Свойства моба */
    //        mobX = 0x3C,
    //        mobZ = 0x40,
    //        mobY = 0x44,
    //        mobType = 0xB4,
    //        mobWorldID = 0x11C,
    //        mobDist = 0x000, // не нашёл оффсета
    //        mobName = 0x24C,

    //        /** CallAddress */
    //        callPacket = 0x005D2350,
    //        callUseSkill = 0x005CC230,
    //        callTarget = 0x005CC0C0;

    //    public static Int32[] structureMobs()
    //    {
    //        return new Int32[] { 0x8, 0x24, 0x18 };
    //    }
    //}

    struct OffsetInMemory
    {
        public const Int32 BaseAddress = 0xA591E0, GameAddress = 0xA59ACC, //1C - offset GA
            structurePersonage = 0x34,

            /** Свойства персонажа */
            HP = 0x46C,
            MP = 0x470,
            maxHP = 0x4A4,
            maxMP = 0x4A8,
            playerName = 0x608,
            classID = 0x610,
            useSkill = 0x6C4,

            /** Свойства моба */
            mobX = 0x3C,
            mobZ = 0x40,
            mobY = 0x44,
            mobType = 0xB4,
            mobWorldID = 0x11C,
            mobDist = 0x000, // не нашёл оффсета
            mobName = 0x24C,

            /** CallAddress */
            callPacket = 0x0063F890,
            callUseSkill = 0x005CC230,
            callTarget = 0x00632150;

        public static Int32[] structureMobs()
        {
            return new Int32[] { 0x8, 0x24, 0x18 };
        }
    }
}
