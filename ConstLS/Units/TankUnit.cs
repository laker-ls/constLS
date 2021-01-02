using System.Diagnostics;
using static ConstLS.Memory.Parameters.RawParameters.SelfRawParameters;

namespace ConstLS.Units
{
    class TankUnit : BaseUnit
    {
        public TankUnit(Process clientProcess) : base(clientProcess) {}

        public int target()
        {
            int targetWID = this.self.targetWID();
            setUpSetters(targetWID);

            if (this.mob.isExist()) {
                return targetWID;
            } else {
                return 0;
            }
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
