using ConstLS.CoordinationCenter.Unit.idOfSkills;
using ConstLS.CoordinationCenter.Units.Conditions.Attack;
using ConstLS.Memory.Injections;

namespace ConstLS.CoordinationCenter.Units.Actions
{
    class DruidAttackAction
    {
        public ActionInjection action;
        private DruidConditionsAttack conditionAttack;

        private DruidSkills skill;

        public DruidAttackAction(ActionInjection action, DruidConditionsAttack conditionAttack)
        {
            this.skill = new DruidSkills();

            this.action = action;
            this.conditionAttack = conditionAttack;
        }

        public void singleTarget()
        {
            if (conditionAttack.isNeedStun()) {
                this.action.castSkill(skill.metalRoi);
            }
            this.action.castSkill(skill.roi);
        }
    }
}
