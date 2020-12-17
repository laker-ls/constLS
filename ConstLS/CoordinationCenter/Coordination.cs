using ConstLS.CoordinationCenter.Unit;

namespace ConstLS.CoordinationCenter
{
    class Coordination
    {
        public TankUnit Tank;
        public DruidUnit Druid;

        public void launch()
        {
            this.assist();
        }

        private void assist()
        {
            this.Druid.action.assist(this.Tank.self.targetWID());
            //if (this.Tank.self.targetWID() != 0) {
            //    this.Druid.action.selectTarget(this.Tank.self.targetWID());
            //    this.Druid.action.castSkill(299);
            //}
        }
    }
}
