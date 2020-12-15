using ConstLS.Memory.RawParameters;
using ConstLS.Memory;
using System;

namespace ConstLS.Unit.Parameters
{
    class MobParameters : BaseParameters
    {
        private MobRawParameters mobRawParameters;

        public MobParameters(ClientMemory clientMemory)
        {
            MobRawParameters mobRawParameters = new MobRawParameters(clientMemory);
            this.mobRawParameters = mobRawParameters;
            this.rawParameters = mobRawParameters;
        }

        public float distance() { return mobRawParameters.distance(); }
        public int worldId() { return mobRawParameters.worldID(); }
        public string type()
        {
            switch (mobRawParameters.type()) {
                case 6:
                    return "Mob";
                case 7:
                    return "NPC";
                case 9:
                    return "Pet";
                default:
                    throw new Exception("Получено не корректно значение.");
            }
        }
    }
}
