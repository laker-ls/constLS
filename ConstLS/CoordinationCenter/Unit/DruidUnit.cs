using ConstLS.Memory.Injections;
using System.Diagnostics;

namespace ConstLS.CoordinationCenter.Unit
{
    class DruidUnit : UnitBase
    {
        public PetInjection usePet;

        public DruidUnit(Process clientProcess) : base(clientProcess)
        {
            this.usePet = new PetInjection(this.clientMemory);
        }
    }
}
