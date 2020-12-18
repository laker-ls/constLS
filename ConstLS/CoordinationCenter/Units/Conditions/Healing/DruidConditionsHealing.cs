using ConstLS.Memory.Parameters;

namespace ConstLS.CoordinationCenter.Units.Conditions.Healing
{
    class DruidConditionsHealing
    {
        private MobParameters pet;

        public void setPet(MobParameters pet)
        {
            this.pet = pet;
        }

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
    }
}
