using ConstLS.Memory.Parameters;
using System;
using static ConstLS.Memory.Parameters.RawParameters.SelfRawParameters;

namespace ConstLS.Units.Conditions
{
    class BaseCondition
    {
        protected MobParameters mob;
       
        public void setMob(MobParameters mobInTarget) { this.mob = mobInTarget; }

        public bool isSelfMoving(Coordinates prevCoordinateRaw, Coordinates coordinateRaw)
        {
            return (prevCoordinateRaw.x != coordinateRaw.x && prevCoordinateRaw.y != coordinateRaw.y);
        }

        public bool isTargetFar(Coordinates coordinateRawSelf, Coordinates coordinatesRawTarget)
        {
            const double CLOSE_DISTANCE = 2.8;
            float distanceX = Math.Abs(coordinateRawSelf.x - coordinatesRawTarget.x);
            float distanceY = Math.Abs(coordinateRawSelf.y - coordinatesRawTarget.y);

            bool isDistanceFarX = (distanceX > CLOSE_DISTANCE);
            bool isDistanceFarY = (distanceY > CLOSE_DISTANCE);

            return (isDistanceFarX && isDistanceFarY);
        }

        public bool isNeedStun()
        {
            bool mobTooClose = (this.mob.distance() < 10);
            bool mobIsFaster = (this.mob.feature() == "acceleration");
            bool mobHaveIncreasedHP = (this.mob.feature() == "increasedHP");
            bool mobHaveLotHP = (this.mob.HPpercent() > 20);

            return (mobHaveLotHP && (mobTooClose || mobIsFaster || mobHaveIncreasedHP));
        }

        public bool isMobAlive()
        {
            if (this.mob.worldID() != -1) {
                string status = this.mob.action();
                return (status != "died");
            } else {
                return false;
            }
        }

        /** TODO: на данный момент взаимодействие с лутом не реализовано. */
        public bool isLootExist()
        {
            return false;
        }
    }
}
