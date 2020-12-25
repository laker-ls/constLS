using System;

namespace ConstLS.Memory.Offsets.GameServers
{
    public class cloudy : IGameServerOffset
    {
        public string serverName() { return "cloudy"; }
        public Int32 baseAddress() { return 0x00C38B6C; }
        public Int32 gameAddress() { return 0x00C392CC; }

        public Int32 self_structure() { return 0x34; }
        public Int32 self_x() { return 0x7C; }
        public Int32 self_z() { return 0x80; }
        public Int32 self_y() { return 0x84; }
        public Int32 self_skillFlag() { return 0xE0; }
        public Int32 self_buffs() { return 0x00; }
        public Int32 self_worldID() { return 0x494; }
        public Int32 self_HP() { return 0x4A8; }
        public Int32 self_MP() { return 0x4AC; }
        public Int32 self_maxHP() { return 0x4F0; }
        public Int32 self_maxMP() { return 0x4F4; }
        public Int32 self_name() { return 0x688; }
        public Int32 self_classID() { return 0x690; }
        public Int32 self_targetWID() { return 0xC88; }
        public Int32 self_activePetId() { return 0x7CC; }

        public Int32 mob_structure1() { return 0x1C; }
        public Int32 mob_structure2() { return 0x24; }
        public Int32 mob_structure3() { return 0x1C; }
        public Int32 mob_x() { return 0x03C; }
        public Int32 mob_z() { return 0x040; }
        public Int32 mob_y() { return 0x044; }
        public Int32 mob_type() { return 0x0B4; }
        public Int32 mob_worldID() { return 0x120; }
        public Int32 mob_lvl() { return 0x128; }
        public Int32 mob_HP() { return 0x130; }
        public Int32 mob_maxHP() { return 0x178; }
        public Int32 mob_feature() { return 0x268; }
        public Int32 mob_distance() { return 0x298; }
        public Int32 mob_action() { return 0x2DC; }
        public Int32 mob_attack() { return 0x2C8; }

        public Int32 call_packet() { return 0x006F55E0; }
        public Int32 call_skill() { return 0x00475740; }
        public Int32 call_target() { return 0x006E8060; }
        public Int32 call_assist() { return 0x00725750; }
        public Int32 call_walk1() { return 0x00484690; }
        public Int32 call_walk2() { return 0x004889B0; }
        public Int32 call_walk3() { return 0x00484B00; }
    }
}
