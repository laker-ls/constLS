using ConstLS.Memory.Injections.PacketLists;

namespace ConstLS.Memory.Injections
{
    class PetInjection : BaseInjection
    {
        public PetInjection(ClientMemory pwClient) :base(pwClient) {}

        public void call() { this.sendWithoutParamter(PacketList.pet.call); }
        public void hide() { this.sendWithoutParamter(PacketList.pet.hide); }
        public void atack(int mobWorldId) { this.sendWithOneParameter(PacketList.pet.atack, mobWorldId, 7); }
        public void follow() { this.sendWithoutParamter(PacketList.pet.atack); }
    }
}
