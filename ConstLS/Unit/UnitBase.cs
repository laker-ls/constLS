using ConstLS.Memory;
using ConstLS.Parameters;

namespace ConstLS.Unit
{
    class UnitBase
    {
        private ClientMemory pwClient;
        public UnitParameters self;
        public MobParameters mob;

        public UnitBase()
        {
            pwClient = new ClientMemory("elementclient", 0);
            self = new UnitParameters(pwClient);
            mob = new MobParameters(pwClient);
        }


    }
}
