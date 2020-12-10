using System;
using ConstLS.Memory;

namespace ConstLS.Parameters
{
    
    class MobParameters : ParametersBase
    {
        public MobParameters(ClientMemory pwClient) : base(pwClient) {}

        public Int32 mobType(Int32 number)
        {
            Int32 buffer = this.Mob(number);
            if (buffer != 0) {
                buffer = pwClient.read.as4byte(buffer + OffsetInMemory.mobType);
            }
            return buffer;
        }

        public Int32 mobWorldID(Int32 number)
        {
            Int32 buffer = this.Mob(number);
            if (buffer != 0) {
                buffer = pwClient.read.as4byte(buffer + OffsetInMemory.mobWorldID);
            }
            return buffer;
        }

        public string name(Int32 number)
        {
            Int32 buffer = this.Mob(number);
            string name = "";
            if (buffer != 0) {
                buffer = pwClient.read.as4byte(buffer + OffsetInMemory.mobName);
                name = pwClient.read.asString(buffer + 0x0, 256);
            }
            return name;
        }

        public float distance(Int32 number)
        {
            Int32 buffer = this.Mob(number);
            float result = 0;
            if (buffer != 0) {
                buffer = pwClient.read.as4byte(buffer + OffsetInMemory.mobDist);
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
                coordinate.x = pwClient.read.asFloat(buffer + OffsetInMemory.mobX);
                coordinate.y = pwClient.read.asFloat(buffer + OffsetInMemory.mobY);
                coordinate.z = pwClient.read.asFloat(buffer + OffsetInMemory.mobZ);
            }

            return this.convertCoordinatesInGameFormat(coordinate);
        }

        public float searchDistance()
        {
            int number = -1;
            float result = 999;

            for (int i = 0; i < 768; i++) {
                if (this.mobWorldID(i) != 0) {
                    if (this.mobType(i) == 6) {
                        number = i;
                        break;
                    }
                }
            }
            if (number != -1) {
                result = this.distance(number);
            }

            return result;
        }

        public string searchName()
        {
            int number = -1;
            string name = "";

            for (int i = 0; i < 768; i++) {
                if (this.mobWorldID(i) != 0) {
                    if (this.mobType(i) == 6) {
                        number = i;
                        break;
                    }
                }
            }
            if (number != -1) {
                name = this.name(number);
            }

            return name;
        }

        public string mobSearch()
        {
            int number = -1;
            Coordinates coords = this.mobCoordination(number);

            for (int i = 0; i < 768; i++) {
                if (this.mobWorldID(i) != 0) {
                    if (this.mobType(i) == 6) {
                        number = i;
                        break;
                    }
                }
            }
            if (number != -1) {
                coords = this.mobCoordination(number);
            }

            return "x - " + coords.x.ToString() + " // y - " + coords.y.ToString() + " // z - " + coords.z.ToString();
        }

        private Int32 Mob(Int32 number)
        {
            Int32 buffer;
            buffer = pwClient.read.as4byte(OffsetInMemory.GameAddress);
            foreach (Int32 offset in OffsetInMemory.structureMobs()) {
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
