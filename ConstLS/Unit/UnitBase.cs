using ConstLS.Memory;
using ConstLS.Parameters;

namespace ConstLS.Unit
{
    class UnitBase
    {
        private ClientMemory pwClient;
        public UnitParameters self;
        public MobParameters mob;
        public Action use;

        public UnitBase()
        {
            this.pwClient = new ClientMemory("elementclient", 0);
            this.self = new UnitParameters(pwClient);
            this.mob = new MobParameters(pwClient);
            this.use = new Action(pwClient);
        }


    }
}
