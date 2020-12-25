using System.Diagnostics;
using static ConstLS.Memory.Parameters.RawParameters.SelfRawParameters;

namespace ConstLS.CoordinationCenter.Units
{
    class TankUnit : UnitBase
    {
        public TankUnit(Process clientProcess) : base(clientProcess) {}

        public void jump()
        {
            this.useCommon.jump();
        }

        public int target()
        {
            int targetWID = this.self.targetWID();

            setUpSetters(targetWID);

            if (this.mob.isExist()) {
                return this.self.targetWID();
            }
            return 0;
        }

        public Coordinates selfCoordinatesRaw()
        {
            return this.self.coordinateRaw();
        }

        private void setUpSetters(int targetWID)
        {
            this.mob.setCurrent(targetWID);
        }
    }
}
