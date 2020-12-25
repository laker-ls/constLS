using System.Windows.Forms;
using System.Diagnostics;

namespace ConstLS.CoordinationCenter.Units.Actions
{
    class CommonAction : ActionBase
    {
        public CommonAction(Process processClient) : base(processClient) {}

        public void jump()
        {
            this.pressKey(Keys.Space);
        }

        public void assist()
        {
            this.pressKeyCombo(Keys.ShiftKey, Keys.D1);
            this.pressKey(Keys.D1);
        }

        public void followPartyLeader()
        {
            
        }
    }
}
