using ConstLS.CoordinationCenter.Units;

namespace ConstLS.CoordinationCenter
{
    class Coordination
    {
        public TankUnit Tank;
        public DruidUnit Druid;

        public void launch()
        {
            int targetOfTank = this.Tank.self.targetWID();
            if (targetOfTank != 0) {
                this.Druid.assist(targetOfTank);
            }
        }
    }
}
