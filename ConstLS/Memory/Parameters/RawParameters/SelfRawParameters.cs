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
            rawCoordinates.x = pwClient.read.asFloat(this.Personage() + Offset.self.x);
            rawCoordinates.y = pwClient.read.asFloat(this.Personage() + Offset.self.y);
            rawCoordinates.z = pwClient.read.asFloat(this.Personage() + Offset.self.z);
            return rawCoordinates;
        }


        public String name() {
            int buffer = pwClient.read.as4byte(this.Personage() + Offset.self.name);            
            return pwClient.read.asString(buffer + 0, 32);
        }
        public Int32 id() { return pwClient.read.as4byte(this.Personage() + Offset.self.worldID); }
        public Int32 HP() { return pwClient.read.as4byte(this.Personage() + Offset.self.HP); }
        public Int32 HPmax() { return pwClient.read.as4byte(this.Personage() + Offset.self.maxHP); }
        public Int32 MP() { return pwClient.read.as4byte(this.Personage() + Offset.self.MP); }
        public Int32 MPmax() { return pwClient.read.as4byte(this.Personage() + Offset.self.maxMP); }
        public Int32 targetWID() { return pwClient.read.as4byte(this.Personage() + Offset.self.targetWID); }
        public Int32 petOfDruidWID() { return pwClient.read.as4byte(this.Personage() + Offset.self.activePetId); }

        protected Int32 type() { return pwClient.read.as4byte(this.Personage() + Offset.self.classID); }

        public Int32 Personage() {
            int buffer = pwClient.read.as4byte(Offset.gameAddress);
            return pwClient.read.as4byte(buffer + Offset.self.structure);
        }
    }
}
