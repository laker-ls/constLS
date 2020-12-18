
using ConstLS.Memory.Parameters;

namespace ConstLS.CoordinationCenter.Units.Conditions.Attack
{
    class DruidConditionsAttack
    {
        private MobParameters mob;

        public void setMob(MobParameters mob)
        {
            this.mob = mob;
        }

        public bool isNeedStun()
        {
            bool mobTooClose = (this.mob.distance() < 10); 
            bool mobIsFaster = (this.mob.feature() == "acceleration");
            bool mobHaveIncreasedHP = (this.mob.feature() == "increasedHP");
            bool mobHaveLotHP = (this.mob.HPpercent() > 20);

            return (mobHaveLotHP && (mobTooClose || mobIsFaster || mobHaveIncreasedHP));
        }
    }
}
