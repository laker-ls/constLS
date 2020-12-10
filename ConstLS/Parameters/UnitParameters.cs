using System;
using ConstLS.Memory;

namespace ConstLS.Parameters
{
    class UnitParameters : ParametersBase
    {
        public UnitParameters(ClientMemory pwClient) : base(pwClient){}

        public String name() {
            int buffer = pwClient.read.as4byte(this.Personage() + OffsetInMemory.playerName);
            return pwClient.read.asString(buffer + 0, 18);
        }
        public Int32 classID() { return pwClient.read.as4byte(this.Personage() + OffsetInMemory.classID); }
        public Int32 HP() { return pwClient.read.as4byte(this.Personage() + OffsetInMemory.HP); }
        public Int32 maxHP() { return pwClient.read.as4byte(this.Personage() + OffsetInMemory.maxHP); }
        public Int32 MP() { return pwClient.read.as4byte(this.Personage() + OffsetInMemory.MP); }
        public Int32 maxMP() { return pwClient.read.as4byte(this.Personage() + OffsetInMemory.maxMP); }

        private Int32 Personage() { return pwClient.read.as4byte(OffsetInMemory.GameAddress + OffsetInMemory.structurePersonage); }
    }
}
