using ConstLS.Memory.Injections.PacketLists;

namespace ConstLS.Memory.Injections
{
    class Pet : BaseInjection
    {
        public Pet(ClientMemory pwClient) :base(pwClient) {}

        public void call() { this.send(PacketList.pet.call); }
        public void remove() { this.send(PacketList.pet.remove); }
        public void atack() { this.send(PacketList.pet.atack); }
    }
}
