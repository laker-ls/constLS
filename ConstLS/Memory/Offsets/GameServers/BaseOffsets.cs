using System;

namespace ConstLS.Memory.Offsets.GameServers
{
    public class BaseOffsets //1C - offset GA
    {
        public const Int32 
            baseAddress = 0x00000000, 
            gameAddress = 0x00000000; 
        
        public struct self
        {
            public const Int32
                structure = 0x00,

                x = 0x00,
                z = 0x00,
                y = 0x00,
                skillFlag = 0x00,
                buffs = 0x00,
                worldID = 0x00,
                HP = 0x00,
                MP = 0x00,
                maxHP = 0x00,
                maxMP = 0x00,
                name = 0x00,
                classID = 0x00,
                targetWID = 0x00,
                activePetWId = 0x00;
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
                lvl = 0x00,
                HP = 0x00,
                maxHP = 0x00,
                feature = 0x00,
                distance = 0x00,
                action = 0x00,
                attack = 0x0;
        }

        public struct call
        {
            public const Int32
                packet = 0x00000000,
                skill = 0x00000000,
                target = 0x00000000,
                assist = 0x00000000,
                walk1 = 0x00000000,
                walk2 = 0x00000000,
                walk3 = 0x00000000;
        }
    }
}
