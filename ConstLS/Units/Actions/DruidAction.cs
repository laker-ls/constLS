using ConstLS.Memory;
using ConstLS.Memory.Injections.PacketLists;
using ConstLS.Units.SkillLists;

namespace ConstLS.Units.Actions
{
    class DruidAction : BaseAction
    {
        public DruidAction(ClientMemory pwClient) :base(pwClient) {}

        public void pet_call() { this.packet.sendWithoutParamter(PacketList.pet.call); }
        public void pet_hide() { this.packet.sendWithoutParamter(PacketList.pet.hide); }
        public void pet_atack(int mobWorldId) { this.packet.sendWithOneParameter(PacketList.pet.atack, mobWorldId, 7); }
        public void pet_follow() { this.packet.sendWithoutParamter(PacketList.pet.atack); }

        public void pet_healing() { this.castSkill(УмениеДруида.исцеление_питомца); }
        public void pet_resurrect() { this.castSkill(УмениеДруида.оживление_питомца); }
    }
}
