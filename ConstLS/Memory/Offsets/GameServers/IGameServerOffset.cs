using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstLS.Memory.Offsets.GameServers
{
    interface IGameServerOffset
    {
        /** Параметры клиента. */
        string serverName();
        Int32 baseAddress(); //1C - offset to GA
        Int32 gameAddress();

        /** Структура персонажа. */
        Int32 self_structure();
        Int32 self_x();
        Int32 self_z();
        Int32 self_y();
        Int32 self_skillFlag();
        Int32 self_buffs();
        Int32 self_worldID();
        Int32 self_HP();
        Int32 self_MP();
        Int32 self_maxHP();
        Int32 self_maxMP();
        Int32 self_name();
        Int32 self_classID();
        Int32 self_targetWID();
        Int32 self_activePetId();

        /** Структура мобов */
        Int32 mob_structure1();
        Int32 mob_structure2();
        Int32 mob_structure3();

        Int32 mob_x();
        Int32 mob_z();
        Int32 mob_y();
        Int32 mob_type();
        Int32 mob_worldID();
        Int32 mob_lvl();
        Int32 mob_HP();
        Int32 mob_maxHP();
        Int32 mob_feature();
        Int32 mob_distance();
        Int32 mob_action();
        Int32 mob_attack();

        /** Адреса функций игрового клиента. */
        Int32 call_packet();
        Int32 call_skill();
        Int32 call_target();
        Int32 call_assist();
        Int32 call_walk1();
        Int32 call_walk2();
        Int32 call_walk3();
    }
}
