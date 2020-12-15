using ConstLS.Memory.Injections.PacketLists;

namespace ConstLS.Memory.Injections
{
    class Action : BaseInjection
    {
        public Action(ClientMemory pwClient) :base(pwClient){}

        public void inMeditation() { this.send(PacketList.action.inMeditation); }
        public void outMeditation() { this.send(PacketList.action.outMeditation); }
        public void autoAttack() { this.send(PacketList.action.autoAttack); }
        public void flyOnOrOff() { this.send(PacketList.action.flyOnOrOff); }
        public void inviteToGroup() { this.send(PacketList.action.inviteToGroup); }
        public void leaveGroup() { this.send(PacketList.action.leaveGroup); }
    }
}
