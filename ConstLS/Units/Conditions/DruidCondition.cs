using ConstLS.Memory.Parameters;

namespace ConstLS.Units.Conditions
{
    class DruidCondition : BaseCondition
    {
        private MobParameters pet;

        public void setPet(MobParameters pet) { this.pet = pet; }

        public bool isPetNeedHeal()
        {
            bool petHaveFewHP = (this.pet.HPpercent() < 40);
            return petHaveFewHP;
        }

        public bool isPetNeedResurrect()
        {
            bool petIsDied = (this.pet.action() == "died");
            return petIsDied;
        }

        public bool isPetCalled()
        {
            // TODO: реализовать проверку, вызван ли питомец.
            return false;
        }

        public bool isTankWithDruidBuff()
        {
            // TODO: Реализовать отслеживание бафа друида (шипов) на танке.
            return true;
        }
    }
}
