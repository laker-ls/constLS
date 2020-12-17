
using ConstLS.Memory.Offsets;

namespace ConstLS.Memory.Injections
{
    class ActionOld
    {
        private ClientMemory pwClient;

        public ActionOld(ClientMemory pwClient)
        {
            this.pwClient = pwClient;
        }

        public void castSkill(int skillId)
        {
            ASM asm = new ASM();
            asm.Pushad();
            asm.Mov_ECX(Offset.baseAddress);
            asm.Mov_ECX_DWORD_Ptr_ECX();
            asm.Mov_ECX_DWORD_Ptr_ECX_Add(0x1C);
            asm.Mov_ECX_DWORD_Ptr_ECX_Add(Offset.self.structure);
            asm.Push6A(-1);
            asm.Push6A(0);
            asm.Push6A(0);
            asm.Mov_EAX(skillId);
            asm.Push_EAX();
            asm.Mov_EDX(Offset.call.skill);
            asm.Call_EDX();
            asm.Popad();
            asm.Ret();

            this.sendInGame(asm.inBytes());
        }

        public void follow(int personageId)
        {
            ASM asm = new ASM();
            asm.Pushad();
            asm.Mov_ESI(0x00438900);

            asm.Mov_ECX_DWORD_Ptr(Offset.baseAddress);
            asm.Push6A(0x00);
            asm.Push68(personageId);
            asm.Mov_EDX_DWORD_Ptr_ECX_Add(0x1C);
            asm.Mov_ECX_DWORD_Ptr_EDX_Add(0x1C);
            asm.Call_ESI();

            asm.Popad();
            asm.Ret();

            this.sendInGame(asm.inBytes());
        }

        public void target(int mobWorldID)
        {
            ASM asm = new ASM();
            asm.Pushad();

            asm.Mov_EDI(mobWorldID);
            asm.Mov_EDX(Offset.call.target);

            asm.Mov_EAX_DWORD_Ptr(0x00A591E0);
            asm.Mov_ECX_DWORD_Ptr_EAX_Add(0x20);
            asm.Add_ECX(0xEC);
            asm.Push_EDI();
            asm.Call_EDX();

            asm.Popad();
            asm.Ret();

            this.sendInGame(asm.inBytes());
        }

        private void sendInGame(byte[] data)
        {
            pwClient.write.inAllocMemory(data);
        }
    }
}
