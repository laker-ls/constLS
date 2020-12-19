using ConstLS.Memory.Injections.PacketLists;
using System;

namespace ConstLS.Memory.Injections
{
    class ActionInjection : BaseInjection
    {
        private ActionOld function;

        public ActionInjection(ClientMemory pwClient) :base(pwClient)
        {
            function = new ActionOld(this.pwClient);
        }

        
        public void castSkill(int skillId) { this.function.castSkill(skillId); }
        public void walk(float x, float y, float z) { this.function.walk(x, y, z); }

        public void inMeditation() { this.sendWithoutParamter(PacketList.action.inMeditation); }
        public void outMeditation() { this.sendWithoutParamter(PacketList.action.outMeditation); }

        public void autoAttack() { this.sendWithoutParamter(PacketList.action.autoAttack); }
        public void flyOnOrOff(int flyId) { this.sendWithOneParameter(PacketList.action.flyOnOrOff, flyId, 6); }

        public void inviteToGroup(int personageId) { this.sendWithOneParameter(PacketList.action.inviteToGroup, personageId, 2); }
        public void groupLeaderShift(int personageId) { this.sendWithOneParameter(PacketList.action.groupLeaderShift, personageId, 2); }
        public void acceptInviteToGroup(int personageId) { this.sendWithOneParameter(PacketList.action.acceptInviteToGroup, personageId, 2); }
        public void leaveGroup() { this.sendWithoutParamter(PacketList.action.leaveGroup); }

        public void resurrectInTown() { this.sendWithoutParamter(PacketList.action.resurrectInTown); }
        public void resurrectScroll() { this.sendWithoutParamter(PacketList.action.resurrectScroll); }
        public void resurrectPriest() { this.sendWithoutParamter(PacketList.action.resurrectPriest); }

        public void assist(int personageId) { this.sendWithOneParameter(PacketList.action.assist, personageId, 2); } // TODO: не понятно id или worldID
        public void selectTarget(int worldId) { this.sendWithOneParameter(PacketList.action.selectTarget, worldId, 2); }
        public void deselectTarget() { this.sendWithoutParamter(PacketList.action.deselectTarget); }

        public void cancelCastSkill() { this.sendWithoutParamter(PacketList.action.cancelCastSkill); }

        public void pickUpLoot(int itemWId, int itemId) { this.sendWithTwoParameter(PacketList.action.pickUpLoot, new int[2] { itemWId, itemId }, new int[2] { 2, 8 }); }
        public void hurvestResource(int resourceWId) { this.sendWithOneParameter(PacketList.action.hurvestResource, resourceWId, 2); }

        public void logoutServer() { this.sendWithoutParamter(PacketList.action.logoutServer); }
    }
}
