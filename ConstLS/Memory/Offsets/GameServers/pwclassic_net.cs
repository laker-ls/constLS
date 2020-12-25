using System;

namespace ConstLS.Memory.Offsets.GameServers
{
    class pwclassic_net : IGameServerOffset
    {
        public string serverName() { return "pwclassic_net"; }
        public Int32 baseAddress() { return 0x009B3EEC; }
        public Int32 gameAddress() { return 0x009B4594; }

        public Int32 self_structure() { return 0x00; }
        public Int32 self_x() { return 0x00; }
        public Int32 self_z() { return 0x00; }
        public Int32 self_y() { return 0x00; }
        public Int32 self_skillFlag() { return 0x00; }
        public Int32 self_buffs() { return 0x00; }
        public Int32 self_worldID() { return 0x00; }
        public Int32 self_HP() { return 0x46C; }
        public Int32 self_MP() { return 0x470; }
        public Int32 self_maxHP() { return 0x4A4; }
        public Int32 self_maxMP() { return 0x4A8; }
        public Int32 self_name() { return 0x608; }
        public Int32 self_classID() { return 0x610; }
        public Int32 self_targetWID() { return 0x00; }
        public Int32 self_activePetId() { return 0x00; }

        public Int32 mob_structure1() { return 0x08; }
        public Int32 mob_structure2() { return 0x24; }
        public Int32 mob_structure3() { return 0x18; }
        public Int32 mob_x() { return 0x3C; }
        public Int32 mob_z() { return 0x40; }
        public Int32 mob_y() { return 0x44; }
        public Int32 mob_type() { return 0xB4; }
        public Int32 mob_worldID() { return 0x11C; }
        public Int32 mob_lvl() { return 0x00; }
        public Int32 mob_HP() { return 0x00; }
        public Int32 mob_maxHP() { return 0x00; }
        public Int32 mob_feature() { return 0x00; }
        public Int32 mob_distance() { return 0x00; }
        public Int32 mob_action() { return 0x00; }
        public Int32 mob_attack() { return 0x00; }

        public Int32 call_packet() { return 0x005D2350; }
        public Int32 call_skill() { return 0x005CC230; }
        public Int32 call_target() { return 0x005CC0C0; }
        public Int32 call_assist() { return 0x00000000; }
        public Int32 call_walk1() { return 0x00000000; }
        public Int32 call_walk2() { return 0x00000000; }
        public Int32 call_walk3() { return 0x00000000; }
    }
}
