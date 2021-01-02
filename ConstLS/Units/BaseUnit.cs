using System.Diagnostics;
using ConstLS.Memory;
using ConstLS.Memory.Parameters;

namespace ConstLS.Units
{
    class BaseUnit
    {
        public SelfParameters self;
        protected MobParameters mob;

        protected ClientMemory clientMemory;

        public BaseUnit(Process clientProcess)
        {
            this.clientMemory = new ClientMemory(clientProcess);

            this.self = new SelfParameters(this.clientMemory);
            this.mob = new MobParameters(this.clientMemory);
        }
    }
}
