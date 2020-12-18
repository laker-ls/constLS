using ConstLS.Memory.Injections;
using System.Diagnostics;
using ConstLS.CoordinationCenter.Unit.idOfSkills;
using ConstLS.CoordinationCenter.Units.Conditions.Attack;
using ConstLS.Memory.Parameters;
using ConstLS.CoordinationCenter.Units.Conditions.Healing;

namespace ConstLS.CoordinationCenter.Units
{
    class DruidUnit : UnitBase, IUnit
    {
        public MobParameters pet;
        public PetInjection usePet;

        private DruidConditionsAttack conditionAttack;
        private DruidConditionsHealing conditionHealing;

        private DruidSkills skill;

        public DruidUnit(Process clientProcess) : base(clientProcess)
        {
            this.pet = new MobParameters(this.clientMemory);
            this.usePet = new PetInjection(this.clientMemory);

            this.conditionAttack = new DruidConditionsAttack();
            this.conditionHealing = new DruidConditionsHealing();

            this.skill = new DruidSkills();
        }

        public void assist(int targetWID)
        {
            this.setUpSetters(targetWID);
            this.mainActions();

            this.action.selectTarget(targetWID);
            if (conditionAttack.isNeedStun()) {
                this.action.castSkill(skill.metalRoi);
            }
            this.action.castSkill(skill.roi);
        }

        private void mainActions()
        {
            if (this.pet.isExist()) {
                if (conditionHealing.isPetNeedHeal()) {
                    this.action.castSkill(skill.petHealing);
                }
                // TODO: очень сомневаюсь, что это условие когда-нибудь выполнится.
                if (conditionHealing.isPetNeedResurrect()) {
                    this.action.castSkill(skill.petResurrect);
                }
            } else {
                //this.usePet.call(); //TODO пока пета нет, нельзя его вызывать, а то вешает клиент (надо найти как проверить наличие пета)
            }
        }

        private void setUpSetters(int targetWID)
        {
            this.mob.setCurrent(targetWID);
            this.pet.setCurrent(this.self.petOfDruidWID());
            this.conditionAttack.setMob(this.mob);
            this.conditionHealing.setPet(this.pet);
        }
    }
}
