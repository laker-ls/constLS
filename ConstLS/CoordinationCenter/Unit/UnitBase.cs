using System.Diagnostics;
using ConstLS.Memory;
using ConstLS.Memory.Injections;
using ConstLS.Memory.Parameters;

namespace ConstLS.CoordinationCenter.Unit
{
    class UnitBase
    {
        public SelfParameters self;
        public MobParameters mob;
        public ActionInjection action;

        protected ClientMemory clientMemory;

        public UnitBase(Process clientProcess)
        {
            if (clientProcess != null) {
                this.clientMemory = new ClientMemory(clientProcess);

                this.self = new SelfParameters(this.clientMemory);
                this.mob = new MobParameters(this.clientMemory);
                this.action = new ActionInjection(this.clientMemory);
            }
        }
    }
}
