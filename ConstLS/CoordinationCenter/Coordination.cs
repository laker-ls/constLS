using ConstLS.Units;

namespace ConstLS.CoordinationCenter
{
    class Coordination : IncomingCommand
    {
        public void loop()
        {
            this.setModeForUnits();
            this.launchBehavourUnits();
        }

        private void setModeForUnits()
        {
            if (this.Druid != null) {
                this.Druid.setMode(this.mode);
            }
        }

        private void launchBehavourUnits()
        {
            if (this.Tank != null && this.Druid != null) {
                this.Druid.behavior(this.Tank.self);
            }
        }
    }
}
