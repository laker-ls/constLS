using System.Diagnostics;
using ConstLS.CoordinationCenter.Units.Actions;
using ConstLS.Memory;
using ConstLS.Memory.Parameters;

namespace ConstLS.CoordinationCenter.Units
{
    class UnitBase
    {
        public SelfParameters self;
        protected MobParameters mob;
        protected CommonAction useCommon;

        protected ClientMemory clientMemory;
        protected Process clientProcess;

        public UnitBase(Process clientProcess)
        {
            this.clientMemory = new ClientMemory(clientProcess);
            this.clientProcess = clientProcess;

            this.self = new SelfParameters(this.clientMemory);
            this.mob = new MobParameters(this.clientMemory);
            this.useCommon = new CommonAction(this.clientProcess);
        }
    }
}
