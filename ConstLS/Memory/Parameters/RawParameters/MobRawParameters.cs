using System;
using ConstLS.Memory.Offsets;

namespace ConstLS.Memory.Parameters.RawParameters
{
    
    class MobRawParameters
    {
        public struct Coordinates { public float x, y, z; }

        public Int32 currentMobWID = -1;
        private ClientMemory pwClient;

        public MobRawParameters(ClientMemory clientMemory)
        {
            this.pwClient = clientMemory;
        }

        public void setCurrent(Int32 needWID)
        {
            this.currentMobWID = -1;
            for (int i = 0; i < 768; i++) {
                Int32 randomMob = this.Mob(i);
                if (randomMob != 0) {
                    Int32 mobWID = pwClient.read.as4byte(this.Mob(i) + Offset.get().mob_worldID());
                    Int32 mobType = pwClient.read.as4byte(this.Mob(i) + Offset.get().mob_type());
                    if (mobWID == needWID && mobType == 6) {
                        this.currentMobWID = i;
                        break;
                    }
                }
            }
        }

        public Coordinates coordinateRaw()
        {
            Coordinates rawCoordinates = new Coordinates();
            rawCoordinates.x = pwClient.read.asFloat(this.Mob() + Offset.get().mob_x());
            rawCoordinates.y = pwClient.read.asFloat(this.Mob() + Offset.get().mob_y());
            rawCoordinates.z = pwClient.read.asFloat(this.Mob() + Offset.get().mob_z());
            return rawCoordinates;
        }

        public Int32 lvl() { return pwClient.read.as4byte(this.Mob() + Offset.get().mob_lvl()); }
        public Int32 HP() { return pwClient.read.as4byte(this.Mob() + Offset.get().mob_HP()); }
        public Int32 HPmax() { return pwClient.read.as4byte(this.Mob() + Offset.get().mob_maxHP()); }
        public float distance() { return pwClient.read.asFloat(this.Mob() + Offset.get().mob_distance()); }
        public bool attack() { return pwClient.read.asBoolean(this.Mob() + Offset.get().mob_attack()); }

        protected Int32 rawWorldID() { return pwClient.read.as4byte(this.Mob() + Offset.get().mob_worldID()); }
        protected Int32 rawType() { return pwClient.read.as4byte(this.Mob() + Offset.get().mob_type()); }
        protected Int32 rawFeature() { return pwClient.read.as4byte(this.Mob() + Offset.get().mob_feature()); }
        protected Int32 rawAction() { return pwClient.read.as4byte(this.Mob() + Offset.get().mob_action()); }

        protected Int32 Mob(Int32 number = 999)
        {
            if (number == 999) {
                number = this.currentMobWID;
            }
            Int32 buffer;
            buffer = pwClient.read.as4byte(Offset.get().gameAddress());
            buffer = pwClient.read.as4byte(buffer + Offset.get().mob_structure1());
            buffer = pwClient.read.as4byte(buffer + Offset.get().mob_structure2());
            buffer = pwClient.read.as4byte(buffer + Offset.get().mob_structure3());
            buffer = pwClient.read.as4byte(buffer + number * 0x4);
            if (buffer != 0) {
                return pwClient.read.as4byte(buffer + 0x4);
            }
            return 0;
        }
    }
}
