using System;

namespace ConstLS.Memory.Offsets.GameServers
{
    class pw_pvp : IGameServerOffset
    {
        public string serverName() { return "pw_pvp"; }
        public Int32 baseAddress() { return 0xA591E0; }
        public Int32 gameAddress() { return 0xA59ACC; }

        public Int32 self_structure() { return 0x00; }
        public Int32 self_x() { return 0x00; }
        public Int32 self_z() { return 0x00; }
        public Int32 self_y() { return 0x00; }
        public Int32 self_skillFlag() { return 0x00; }
        public Int32 self_buffs() { return 0x00; }
        public Int32 self_worldID() { return 0x00; }
        public Int32 self_HP() { return 0x00; }
        public Int32 self_MP() { return 0x00; }
        public Int32 self_maxHP() { return 0x00; }
        public Int32 self_maxMP() { return 0x00; }
        public Int32 self_name() { return 0x00; }
        public Int32 self_classID() { return 0x00; }
        public Int32 self_targetWID() { return 0x00; }
        public Int32 self_activePetId() { return 0x00; }

        public Int32 mob_structure1() { return 0x00; }
        public Int32 mob_structure2() { return 0x00; }
        public Int32 mob_structure3() { return 0x00; }
        public Int32 mob_x() { return 0x00; }
        public Int32 mob_z() { return 0x00; }
        public Int32 mob_y() { return 0x00; }
        public Int32 mob_type() { return 0x00; }
        public Int32 mob_worldID() { return 0x00; }
        public Int32 mob_lvl() { return 0x00; }
        public Int32 mob_HP() { return 0x00; }
        public Int32 mob_maxHP() { return 0x00; }
        public Int32 mob_feature() { return 0x00; }
        public Int32 mob_distance() { return 0x00; }
        public Int32 mob_action() { return 0x00; }
        public Int32 mob_attack() { return 0x00; }

        public Int32 call_packet() { return 0x0063F890; }
        public Int32 call_skill() { return 0x005CC230; }
        public Int32 call_target() { return 0x00632150; }
        public Int32 call_assist() { return 0x00000000; }
        public Int32 call_walk1() { return 0x00000000; }
        public Int32 call_walk2() { return 0x00000000; }
        public Int32 call_walk3() { return 0x00000000; }
    }
}
