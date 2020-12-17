using System;
using ConstLS.Memory.Offsets;

namespace ConstLS.Memory.Parameters.RawParameters
{
    
    class MobRawParameters
    {
        public struct Coordinates { public float x, y, z; }

        private ClientMemory pwClient;
        private Int32 numberOfMobInTarget;

        public MobRawParameters(ClientMemory clientMemory)
        {
            this.pwClient = clientMemory;
        }

        public Coordinates coordinateRaw()
        {
            Coordinates rawCoordinates = new Coordinates();
            rawCoordinates.x = pwClient.read.asFloat(this.Mob() + Offset.mob.x);
            rawCoordinates.y = pwClient.read.asFloat(this.Mob() + Offset.mob.y);
            rawCoordinates.z = pwClient.read.asFloat(this.Mob() + Offset.mob.z);
            return rawCoordinates;
        }

        public Int32 HP() { return pwClient.read.as4byte(this.Mob() + Offset.mob.HP); }
        public Int32 maxHP() { return pwClient.read.as4byte(this.Mob() + Offset.mob.maxHP); }
        public float distance() { return pwClient.read.asFloat(this.Mob() + Offset.mob.distance); }
        public Int32 worldID() { return pwClient.read.as4byte(this.Mob() + Offset.mob.worldID); }
        public Int32 type() { return pwClient.read.as4byte(this.Mob() + Offset.mob.type); }

        public void mobSearchByWid(Int32 needWID)
        {
            this.numberOfMobInTarget = -1;
            for (int i = 0; i < 768; i++) {
                Int32 mobWID = pwClient.read.as4byte(this.Mob(i) + Offset.mob.worldID);
                Int32 mobType = pwClient.read.as4byte(this.Mob(i) + Offset.mob.type);
                if (mobWID == needWID && mobType == 6) {
                    this.numberOfMobInTarget = i;
                    break;
                }
            }
        }

        private Int32 Mob(Int32 number = 999)
        {
            if (number == 999) {
                number = this.numberOfMobInTarget;
            }
            Int32 buffer;
            buffer = pwClient.read.as4byte(Offset.gameAddress);
            buffer = pwClient.read.as4byte(buffer + Offset.mob.structure1);
            buffer = pwClient.read.as4byte(buffer + Offset.mob.structure2);
            buffer = pwClient.read.as4byte(buffer + Offset.mob.structure3);
            buffer = pwClient.read.as4byte(buffer + number * 0x4);
            buffer = pwClient.read.as4byte(buffer + 0x4);
            return buffer;
        }
    }
}
