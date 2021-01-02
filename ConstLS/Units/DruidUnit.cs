using System.Diagnostics;
using ConstLS.Memory.Parameters;
using ConstLS.Units.Conditions;
using ConstLS.Units.Actions;
using ConstLS.Units.SkillLists;
using static ConstLS.Memory.Parameters.RawParameters.SelfRawParameters;

namespace ConstLS.Units
{
    class DruidUnit : BaseUnit
    {
        public DruidAction use;
        private MobParameters pet;
        private DruidCondition condition;

        public string mode;
        public string status;

        private MobParameters targetDruid;
        private string prevStatus;
        private Coordinates prevCoordinatesSelf;

        public DruidUnit(Process clientProcess) : base(clientProcess)
        {
            this.use = new DruidAction(this.clientMemory);
            this.pet = new MobParameters(this.clientMemory);
            this.condition = new DruidCondition();

            this.status = "follow";

            prevCoordinatesSelf = this.self.coordinateRaw();
        }

        public void behavior(SelfParameters Tank)
        {
            if (this.mode == "startingLocations") {
                this.setUpMob();
                this.setUpPet();
                switch (this.status) {
                    case "setTarget": this.actionSetTarget(Tank.targetWID()); break;

                    case "follow": this.actionFollow(Tank.id(), Tank.coordinateRaw()); break;
                    case "buff": this.actionBuff(); break;
                    case "attackOnOne": this.actionAttackOnOne(); break;
                    case "raiseLoot": this.actionRaiseLoot(); break;

                    case "petCall": this.actionPetCall(); break;
                    case "petHide": this.actionPetHide(); break;
                    case "petHeal": this.actionPetHeal(); break;
                    case "petResurrect": this.actionPetRessurect(); break;
                }

                prevCoordinatesSelf = this.self.coordinateRaw();
            }
        }

        private void actionFollow(int targetWid, Coordinates targetCoordinates)
        {
            float test_x = this.self.coordinateRaw().x, test_y = this.self.coordinateRaw().y;
            this.use.selectTarget(targetWid);
            if (!condition.isSelfMoving(prevCoordinatesSelf, this.self.coordinateRaw()) && condition.isTargetFar(this.self.coordinateRaw(), targetCoordinates)) {
                this.use.walk();
            } else {
                this.prevStatus = this.status;
            }

            if (!condition.isTankWithDruidBuff()) {
                this.setStatus("buff");
            }

            if (condition.isPetCalled()) {
                if (condition.isPetNeedHeal()) {
                    this.setStatus("petHeal");
                }
                if (condition.isPetNeedResurrect()) {
                    this.setStatus("petResurrect");
                }
            }

            // TODO: Не реализовано.
            /*if (!condition.isPetCalled()) {
                this.setStatus("petCall");
            }*/
        }

        private void actionBuff()
        {
            if (condition.isTankWithDruidBuff()) {
                this.setStatus("follow");
            }
        }

        private void actionSetTarget(int targetTankWid)
        {
            this.mob.setCurrent(targetTankWid);
            this.targetDruid = this.mob;

            this.use.selectTarget(this.targetDruid.worldID());
            if (targetTankWid != 0) {
                this.setStatus("attackOnOne");
            } else {
                this.setStatus("follow");
            }
        }

        private void actionAttackOnOne()
        {
            this.attackSingleTarget(this.targetDruid.worldID());

            if (!condition.isMobAlive()) {
                this.targetDruid = null;
                this.setStatus("raiseLoot");
            }
        }

        private void actionRaiseLoot()
        {
            this.setStatus("follow");

            // TODO: реализовать поднятие лута.
            /*int itemWId = -1, itemId = -1;
            this.use.pickUpLoot(itemWId, itemId);

            if (!condition.isLootExist()) {
                this.setStatus("follow");
            }*/
        }


        private void actionPetCall()
        {
            this.use.pet_call();

            if (condition.isPetCalled()) {
                this.setStatus("follow");
            }
        }

        private void actionPetHide()
        {
            this.use.pet_hide();

            if (!condition.isPetCalled()) {
                this.setStatus("follow");
            }
        }

        private void actionPetHeal()
        {
            this.use.pet_healing();

            if (!condition.isPetNeedHeal()) {
                this.setStatus("follow");
            }
        }

        private void actionPetRessurect()
        {
            this.use.pet_resurrect();

            if (!condition.isPetNeedResurrect()) {
                this.setStatus("follow");
            }
        }

        private void attackSingleTarget(int targetWID)
        {
            if (targetWID != -1) {
                if (condition.isNeedStun()) {
                    this.use.castSkill(УмениеДруида.рой_железных_скал);
                }
                this.use.castSkill(УмениеДруида.жалящий_рой);
            }
        }

        private void setUpMob()
        {
            if (this.targetDruid != null) {
                this.mob.setCurrent(this.targetDruid.worldID());
                this.condition.setMob(this.targetDruid);
            }
        }

        private void setUpPet()
        {
            this.pet.setCurrent(this.self.petOfDruidWID());
            this.condition.setPet(this.pet);
        }

        public void setMode(string mode)
        {
            this.mode = mode;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }
    }
}
