using System.Diagnostics;
using ConstLS.Memory;
using ConstLS.Memory.Injections;
using ConstLS.Unit.Parameters;

namespace ConstLS.Unit
{
    class UnitBase
    {
        public SelfParameters self;
        public MobParameters mob;

        public Action useAction;
        public Pet usePet;

        public UnitBase(Process clientProcess)
        {
            ClientMemory clientMemory = new ClientMemory(clientProcess);
            this.self = new SelfParameters(clientMemory);
            this.mob = new MobParameters(clientMemory);

            this.useAction = new Action(clientMemory);
            this.usePet = new Pet(clientMemory);
        }
    }
}
