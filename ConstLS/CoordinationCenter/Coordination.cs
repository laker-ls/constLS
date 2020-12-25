using ConstLS.CoordinationCenter.Units;
using ConstLS.KeyAndMouseHook;
using System.Windows.Forms;

namespace ConstLS.CoordinationCenter
{
    class Coordination
    {
        public TankUnit Tank;
        public DruidUnit Druid;

        private GlobalHook hook;

        public Coordination()
        {
            this.eventByPressButton();
        }

        private void eventByPressButton()
        {
            this.hook = new GlobalHook();

            hook.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.LShiftKey) {

                    if (this.Tank != null) {
                        this.Tank.jump();
                    }

                    /*if (this.Tank != null && this.Druid != null) {
                        this.assistFirstSubgroup();
                    }*/
                }
            };
        }

        public void assistFirstSubgroup()
        {
            int targetOfTank = this.Tank.target();
            if (targetOfTank != 0)
            {
                this.Druid.attackAssist();
            }
            else
            {
                //this.Druid.follow(this.Tank.selfCoordinatesRaw());
            }
        }
    }
}
