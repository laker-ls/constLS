using System;
using ConstLS.Memory;
using ConstLS.Memory.Offsets;

namespace ConstLS.Unit.Parameters
{
    
    class MobParameters : BaseParameters
    {
        public MobParameters(ClientMemory pwClient) : base(pwClient) {}

        public Int32 mobType(Int32 number)
        {
            Int32 buffer = this.Mob(number);
            if (buffer != 0) {
                buffer = pwClient.read.as4byte(buffer + Offset.mob.type);
            }
            return buffer;
        }

        public Int32 mobWorldID(Int32 number)
        {
            Int32 buffer = this.Mob(number);
            if (buffer != 0) {
                buffer = pwClient.read.as4byte(buffer + Offset.mob.worldID);
            }
            return buffer;
        }

        public string name(Int32 number)
        {
            Int32 buffer = this.Mob(number);
            string name = "";
            if (buffer != 0) {
                buffer = pwClient.read.as4byte(buffer + Offset.mob.name);
                name = pwClient.read.asString(buffer + 0x0, 256);
            }
            return name;
        }

        public float distance(Int32 number)
        {
            Int32 buffer = this.Mob(number);
            float result = 0;
            if (buffer != 0) {
                buffer = pwClient.read.as4byte(buffer + Offset.mob.distance);
                result = pwClient.read.asFloat(buffer + 0x225);
            }
            return result;
        }

        public Coordinates mobCoordination(int number)
        {
            Coordinates coordinate = new Coordinates();
            coordinate.x = 0; coordinate.y = 0; coordinate.z = 0;

            Int32 buffer = this.Mob(number);
            if (buffer != 0) {
                coordinate.x = pwClient.read.asFloat(buffer + Offset.mob.x);
                coordinate.y = pwClient.read.asFloat(buffer + Offset.mob.y);
                coordinate.z = pwClient.read.asFloat(buffer + Offset.mob.z);
            }

            return this.convertCoordinatesInGameFormat(coordinate);
        }

        public float searchDistance()
        {
            float result = 999;
            int number = this.mobNumber();
            if (number != -1) {
                result = this.distance(number);
            }

            return result;
        }

        public string searchName()
        {
            string name = "";
            int number = this.mobNumber();
            if (number != -1) {
                name = this.name(number);
            }
            return name;
        }

        public int worldID()
        {
            int WID = 0;
            int number = this.mobNumber();
            if (number != -1) {
                WID = this.mobWorldID(number);
            }
            return WID;
        }

        public string mobSearch()
        {
            Coordinates coords;
            coords.x = 0; coords.y = 0; coords.z = 0;
            int number = this.mobNumber();
            if (number != -1) {
                coords = this.mobCoordination(number);
            }
            return "x - " + coords.x.ToString() + " // y - " + coords.y.ToString() + " // z - " + coords.z.ToString();
        }

        private int mobNumber()
        {
            int number = -1;
            for (int i = 0; i < 768; i++) {
                if (this.mobWorldID(i) != 0) {
                    if (this.mobType(i) == 6) {
                        number = i;
                        break;
                    }
                }
            }
            return number;
        }

        private Int32 Mob(Int32 number)
        {
            Int32 buffer;
            buffer = pwClient.read.as4byte(Offset.gameAddress);
            int[] structureMobs = { Offset.mob.structure1, Offset.mob.structure2, Offset.mob.structure3};
            foreach (Int32 offset in structureMobs) {
                buffer = pwClient.read.as4byte(buffer + offset);
            }
            buffer = pwClient.read.as4byte(buffer + number * 0x4);
            if (buffer != 0) {
                buffer = pwClient.read.as4byte(buffer + 0x4);
            }
            return buffer;
        }
    }
}
