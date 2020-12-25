using System.Diagnostics;
using System.Windows.Forms;

namespace ConstLS.CoordinationCenter.Units.Actions.DruidAction
{
    class DruidPetAction : ActionBase
    {
        public DruidPetAction(Process processClient) : base(processClient)  {}

        public void healing()
        {
            this.pressKey(Keys.F4);
        }

        public void resurrect()
        {
            this.pressKey(Keys.F5);
        }
    }
}
