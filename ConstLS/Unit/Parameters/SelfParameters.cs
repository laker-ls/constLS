using ConstLS.Memory.RawParameters;
using ConstLS.Memory;
using System;

namespace ConstLS.Unit.Parameters
{
    class SelfParameters : BaseParameters
    {
        private SelfRawParameters selfRawParameters;

        public SelfParameters(ClientMemory clientMemory)
        {
            SelfRawParameters selfRawParameters = new SelfRawParameters(clientMemory);
            this.selfRawParameters = selfRawParameters;
            this.rawParameters = selfRawParameters;
        }

        public string name() { return this.selfRawParameters.name(); }
        public string type()
        {
            string result = "";
            switch (this.selfRawParameters.type()) {
                case 0:
                    return "Tank";
                case 1:
                    return "Druid";
                case 2:
                    return "Warrior";
                case 3:
                    return "Mage";
                case 4:
                    return "Archer";
                case 5:
                    return "Priest";
                default:
                    throw new Exception("Получено не корректное значение.");
            }
        }
        public int percentMP() { return (this.selfRawParameters.MP() / (this.selfRawParameters.maxMP() / 100)); }

        public bool isExist() {
            if (this.selfRawParameters.Personage() != 0) {
                return true;
            }
            return false;
        }
    }
}
