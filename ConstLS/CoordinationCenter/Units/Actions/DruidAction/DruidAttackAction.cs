using ConstLS.CoordinationCenter.Units.Conditions.Attack;
using System.Diagnostics;
using System.Windows.Forms;

namespace ConstLS.CoordinationCenter.Units.Actions
{
    class DruidAttackAction : ActionBase
    {
        private DruidConditionsAttack conditionAttack;

        public DruidAttackAction(Process clientProcess, DruidConditionsAttack conditionAttack) :base(clientProcess)
        {
            this.conditionAttack = conditionAttack;
        }

        public void singleTarget()
        {
            if (conditionAttack.isNeedStun()) {
                this.pressKey(Keys.F2);
            }
            this.pressKey(Keys.F1);
        }
    }
}
