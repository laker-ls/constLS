using System.Diagnostics;
using ConstLS.Memory;
using ConstLS.Unit.Parameters;

namespace ConstLS.Unit
{
    class UnitBase
    {
        public const int
            CLASS_ID_DRUID = 3,
            CLASS_ID_TANK = 2,
            CLASS_ID_PRIEST = 1,
            CLASS_ID_ARCHER = 0,
            CLASS_ID_MAGE = 4,
            CLASS_ID_WARRIOR = 5;

        public SelfParameters self;
        public MobParameters mob;
        public Action use;

        public UnitBase(Process clientProcess)
        {
            ClientMemory clientMemory = new ClientMemory(clientProcess);
            this.self = new SelfParameters(clientMemory);
            this.mob = new MobParameters(clientMemory);
            this.use = new Action(clientMemory);
        }
    }
}
