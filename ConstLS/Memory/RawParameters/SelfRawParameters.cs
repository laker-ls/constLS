using System;
using ConstLS.Memory;
using ConstLS.Memory.Offsets;
using ConstLS.Memory.Offsets.GameServers;

namespace ConstLS.Memory.RawParameters
{
    class SelfRawParameters : IRawParameters
    {
        ClientMemory pwClient;

        public SelfRawParameters(ClientMemory clientMemory)
        {
            this.pwClient = clientMemory;
        }

        public float x() { return pwClient.read.asFloat(this.Personage() + Offset.self.x); }
        public float y() { return pwClient.read.asFloat(this.Personage() + Offset.self.y); }
        public float z() { return pwClient.read.asFloat(this.Personage() + Offset.self.z); }
        public String name() {
            int buffer = pwClient.read.as4byte(this.Personage() + Offset.self.name);            
            return pwClient.read.asString(buffer + 0, 32);
        }
        public Int32 type() { return pwClient.read.as4byte(this.Personage() + Offset.self.classID); }
        public Int32 HP() { return pwClient.read.as4byte(this.Personage() + Offset.self.HP); }
        public Int32 MP() { return pwClient.read.as4byte(this.Personage() + Offset.self.MP); }
        public Int32 maxMP() { return pwClient.read.as4byte(this.Personage() + Offset.self.maxMP); }
        public Int32 maxHP() { return pwClient.read.as4byte(this.Personage() + Offset.self.maxHP); }

        public Int32 Personage() {
            int buffer = pwClient.read.as4byte(Offset.gameAddress);
            return pwClient.read.as4byte(buffer + Offset.self.structure);
        }
    }
}
