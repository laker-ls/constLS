using System;
using ConstLS.Memory.Offsets;

namespace ConstLS.Memory.Parameters.RawParameters
{
    
    class MobRawParameters
    {
        public struct Coordinates { public float x, y, z; }

        private ClientMemory pwClient;
        private Int32 currentMobWID;

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
                    Int32 mobWID = pwClient.read.as4byte(this.Mob(i) + Offset.mob.worldID);
                    Int32 mobType = pwClient.read.as4byte(this.Mob(i) + Offset.mob.type);
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
            rawCoordinates.x = pwClient.read.asFloat(this.Mob() + Offset.mob.x);
            rawCoordinates.y = pwClient.read.asFloat(this.Mob() + Offset.mob.y);
            rawCoordinates.z = pwClient.read.asFloat(this.Mob() + Offset.mob.z);
            return rawCoordinates;
        }

        public Int32 lvl() { return pwClient.read.as4byte(this.Mob() + Offset.mob.lvl); }
        public Int32 HP() { return pwClient.read.as4byte(this.Mob() + Offset.mob.HP); }
        public Int32 HPmax() { return pwClient.read.as4byte(this.Mob() + Offset.mob.maxHP); }
        public float distance() { return pwClient.read.asFloat(this.Mob() + Offset.mob.distance); }
        public Int32 worldID() { return pwClient.read.as4byte(this.Mob() + Offset.mob.worldID); }
        public bool attack() { return pwClient.read.asBoolean(this.Mob() + Offset.mob.attack); }

        protected Int32 rawType() { return pwClient.read.as4byte(this.Mob() + Offset.mob.type); }
        protected Int32 rawFeature() { return pwClient.read.as4byte(this.Mob() + Offset.mob.feature); }
        protected Int32 rawAction() { return pwClient.read.as4byte(this.Mob() + Offset.mob.action); }

        public bool isExist()
        {
            this.setCurrent();
            if (this.currentMobWID != -1) {
                return true;
            }
            return false;
        }

        protected Int32 Mob(Int32 number = 999)
        {
            if (number == 999) {
                number = this.currentMobWID;
            }
            Int32 buffer;
            buffer = pwClient.read.as4byte(Offset.gameAddress);
            buffer = pwClient.read.as4byte(buffer + Offset.mob.structure1);
            buffer = pwClient.read.as4byte(buffer + Offset.mob.structure2);
            buffer = pwClient.read.as4byte(buffer + Offset.mob.structure3);
            buffer = pwClient.read.as4byte(buffer + number * 0x4);
            if (buffer != 0) {
                return pwClient.read.as4byte(buffer + 0x4);
            }
            return 0;
        }
    }
}
