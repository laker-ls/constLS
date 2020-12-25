using System.Diagnostics;
using ConstLS.CoordinationCenter.Units.Conditions.Attack;
using ConstLS.Memory.Parameters;
using ConstLS.CoordinationCenter.Units.Conditions.Healing;
using ConstLS.CoordinationCenter.Units.Actions;
using ConstLS.CoordinationCenter.Units.Actions.DruidAction;

namespace ConstLS.CoordinationCenter.Units
{
    class DruidUnit : UnitBase
    {
        private MobParameters pet;

        public DruidPetAction usePet;
        public DruidAttackAction useAttack;

        private DruidConditionsAttack conditionAttack;
        private DruidConditionsHealing conditionHealing;

        public DruidUnit(Process clientProcess) : base(clientProcess)
        {
            this.pet = new MobParameters(this.clientMemory);

            this.usePet = new DruidPetAction(clientProcess);
            this.useAttack = new DruidAttackAction(clientProcess, conditionAttack);

            this.conditionAttack = new DruidConditionsAttack();
            this.conditionHealing = new DruidConditionsHealing();
        }

        public void attackAssist()
        {
            this.mainActions();
            this.useCommon.assist();
            this.setUpConditions(this.mob.currentMobWID);
            while (this.mob.currentMobWID != -1 && conditionAttack.isMobAlive()) {
                this.useAttack.singleTarget();
            }
        }

        private void mainActions()
        {
            if (this.pet.isExist()) {
                if (conditionHealing.isPetNeedHeal()) {
                    this.usePet.healing();
                }
                // TODO: очень сомневаюсь, что это условие когда-нибудь выполнится.
                if (conditionHealing.isPetNeedResurrect()) {
                    this.usePet.resurrect();
                }
            } else {
                //this.usePet.call(); //TODO пока пета нет, нельзя его вызывать, а то вешает клиент (надо найти как проверить наличие пета)
            }
        }

        private void setUpConditions(int targetWID)
        {
            this.mob.setCurrent(targetWID);
            this.pet.setCurrent(this.self.petOfDruidWID());

            this.conditionAttack.setMob(this.mob);
            this.conditionHealing.setPet(this.pet);
        }
    }
}
