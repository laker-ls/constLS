using ConstLS.Units;
using ConstLS.KeyHook;
using System.Windows.Forms;

namespace ConstLS.CoordinationCenter
{
    class IncomingCommand
    {
        public string mode;
        public string status;

        private GlobalHook hook;

        public TankUnit Tank;
        public DruidUnit Druid;

        public IncomingCommand()
        {
            this.mode = "";

            this.hook = new GlobalHook();
            hook.KeyDown += (s, ev) => {
                this.sendNum1(ev);
                this.sendLShiftKey(ev);
            };
        }

        private void sendNum1(KeyEventArgs ev)
        {
            if (ev.KeyCode == Keys.NumPad1) {
                this.mode = "startingLocations";
            }
        }

        private void sendLShiftKey(KeyEventArgs ev)
        {
            if (ev.KeyCode == Keys.LShiftKey) {
                if (this.Tank != null && this.Druid != null) {
                    this.Druid.setStatus("setTarget");
                }
            }
        }
    }
}
