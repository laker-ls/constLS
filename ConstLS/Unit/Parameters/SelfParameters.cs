using System;
using ConstLS.Memory;
using ConstLS.Memory.Offsets;
using ConstLS.Memory.Offsets.GameServers;

namespace ConstLS.Unit.Parameters
{
    class SelfParameters : BaseParameters
    {
        public SelfParameters(ClientMemory pwClient) : base(pwClient){}

        public String name() {
            string name = "";
            int personageStructure = this.Personage();
            if (personageStructure != 0) {
                int buffer = pwClient.read.as4byte(personageStructure + Offset.self.name);
                name = pwClient.read.asString(buffer + 0, 18);
            }
            
            return name;
        }
        public Int32 classID() { return pwClient.read.as4byte(this.Personage() + Offset.self.classID); }
        public Int32 HP() { return pwClient.read.as4byte(this.Personage() + Offset.self.HP); }
        public Int32 maxHP() { return pwClient.read.as4byte(this.Personage() + Offset.self.maxHP); }
        public Int32 MP() { return pwClient.read.as4byte(this.Personage() + Offset.self.MP); }
        public Int32 maxMP() { return pwClient.read.as4byte(this.Personage() + Offset.self.maxMP); }

        private Int32 Personage() {
            int buffer = pwClient.read.as4byte(Offset.gameAddress);
            return pwClient.read.as4byte(buffer + Offset.self.structure);
        }
    }
}
