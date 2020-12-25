using System;
using ConstLS.Memory.Offsets;

namespace ConstLS.Memory.Parameters.RawParameters
{
    class SelfRawParameters
    {
        public struct Coordinates { public float x, y, z; }

        private ClientMemory pwClient;

        public SelfRawParameters(ClientMemory clientMemory)
        {
            this.pwClient = clientMemory;
        }

        public Coordinates coordinateRaw()
        {
            Coordinates rawCoordinates = new Coordinates();
            rawCoordinates.x = pwClient.read.asFloat(this.Personage() + Offset.get().self_x());
            rawCoordinates.y = pwClient.read.asFloat(this.Personage() + Offset.get().self_y());
            rawCoordinates.z = pwClient.read.asFloat(this.Personage() + Offset.get().self_z());
            return rawCoordinates;
        }


        public String name() {
            int buffer = pwClient.read.as4byte(this.Personage() + Offset.get().self_name());            
            return pwClient.read.asString(buffer + 0, 32);
        }
        public Int32 id() { return pwClient.read.as4byte(this.Personage() + Offset.get().self_worldID()); }
        public Int32 HP() { return pwClient.read.as4byte(this.Personage() + Offset.get().self_HP()); }
        public Int32 HPmax() { return pwClient.read.as4byte(this.Personage() + Offset.get().self_maxHP()); }
        public Int32 MP() { return pwClient.read.as4byte(this.Personage() + Offset.get().self_MP()); }
        public Int32 MPmax() { return pwClient.read.as4byte(this.Personage() + Offset.get().self_maxMP()); }
        public Int32 targetWID() { return pwClient.read.as4byte(this.Personage() + Offset.get().self_targetWID()); }
        public Int32 petOfDruidWID() { return pwClient.read.as4byte(this.Personage() + Offset.get().self_activePetId()); }

        protected Int32 type() { return pwClient.read.as4byte(this.Personage() + Offset.get().self_classID()); }

        public Int32 Personage() {
            int buffer = pwClient.read.as4byte(Offset.get().gameAddress());
            if (buffer != 0) {
                return pwClient.read.as4byte(buffer + Offset.get().self_structure());
            }
            return 0;
        }
    }
}
