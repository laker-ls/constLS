using System.Windows.Forms;
using ConstLS.Memory;
using ConstLS.Memory.Injections;
using ConstLS.Memory.Injections.PacketLists;

namespace ConstLS.Units.Actions
{
    class BaseAction
    {
        protected InjectionFunction function;
        protected InjectionPacket packet;
        protected InjectionKeyPress keyPress;

        public BaseAction(ClientMemory pwClient)
        {
            function = new InjectionFunction(pwClient);
            packet = new InjectionPacket(pwClient);
            keyPress = new InjectionKeyPress(pwClient.handle);
        }


        public void castSkill(int skillId) { this.function.castSkill(skillId); }
        //public void walk(float x, float y, float z) { this.function.walk(x, y, z); }
        public void walk() {
            this.keyPress.randomDelay(250);
            this.keyPress.sendMouseRight(510, 70);
            this.keyPress.randomDelay(200);
            this.keyPress.sendMouseLeft(550, 80);
        }

        public void assist(int personageId) { packet.sendWithOneParameter(PacketList.action.assist, personageId, 2); }

        public void inMeditation() { packet.sendWithoutParamter(PacketList.action.inMeditation); }
        public void outMeditation() { packet.sendWithoutParamter(PacketList.action.outMeditation); }

        public void flyOnOrOff(int flyId) { packet.sendWithOneParameter(PacketList.action.flyOnOrOff, flyId, 6); }

        public void inviteToGroup(int personageId) { packet.sendWithOneParameter(PacketList.action.inviteToGroup, personageId, 2); }
        public void groupLeaderShift(int personageId) { packet.sendWithOneParameter(PacketList.action.groupLeaderShift, personageId, 2); }
        public void acceptInviteToGroup(int personageId) { packet.sendWithOneParameter(PacketList.action.acceptInviteToGroup, personageId, 2); }
        public void leaveGroup() { packet.sendWithoutParamter(PacketList.action.leaveGroup); }

        public void resurrectInTown() { packet.sendWithoutParamter(PacketList.action.resurrectInTown); }
        public void resurrectScroll() { packet.sendWithoutParamter(PacketList.action.resurrectScroll); }
        public void resurrectPriest() { packet.sendWithoutParamter(PacketList.action.resurrectPriest); }

        public void pickUpLoot(int itemWId, int itemId) { packet.sendWithTwoParameter(PacketList.action.pickUpLoot, new int[2] { itemWId, itemId }, new int[2] { 2, 8 }); }
        public void hurvestResource(int resourceWId) { packet.sendWithOneParameter(PacketList.action.hurvestResource, resourceWId, 2); }

        public void logoutServer() { packet.sendWithoutParamter(PacketList.action.logoutServer); }

        public void autoAttack() { packet.sendWithoutParamter(PacketList.action.autoAttack); }

        public void selectTarget(int worldId) { 
            if (worldId != - 1) {
                packet.sendWithOneParameter(PacketList.action.selectTarget, worldId, 2);
            }
        }
        public void deselectTarget() { packet.sendWithoutParamter(PacketList.action.deselectTarget); }

        public void cancelCastSkill() { packet.sendWithoutParamter(PacketList.action.cancelCastSkill); }

        public void jump() { keyPress.send(Keys.Space); }
    }
}
