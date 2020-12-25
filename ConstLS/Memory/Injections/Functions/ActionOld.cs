
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

        public void target(int mobWorldID)
        {
            ASM asm = new ASM();
            asm.Pushad();
            asm.Mov_EDI(mobWorldID);
            asm.Mov_EDX(Offset.get().call_target());
            asm.Mov_EAX_DWORD_Ptr(0x00A591E0);
            asm.Mov_ECX_DWORD_Ptr_EAX_Add(0x20);
            asm.Add_ECX(0xEC);
            asm.Push_EDI();
            asm.Call_EDX();
            asm.Popad();
            asm.Ret();

            this.sendInGame(asm.inBytes());
        }

        public void castSkill(int skillId)
        {
            ASM asm = new ASM();
            asm.Pushad();
            asm.Mov_ECX_DWORD_Ptr(Offset.get().gameAddress());
            asm.Mov_ECX_DWORD_Ptr_ECX_Add(Offset.get().self_structure());
            asm.Push6A(-1);
            asm.Push6A(0);
            asm.Push6A(0);
            asm.Mov_EAX(skillId);
            asm.Push_EAX();
            asm.Mov_EDX(Offset.get().call_skill());
            asm.Call_EDX();
            asm.Popad();
            asm.Ret();

            this.sendInGame(asm.inBytes());
        }

        public void walk(float x, float y, float z)
        {
            int walkMode = 0; // 0 - передвижение по земле, 1 - полёт

            ASM asm = new ASM();
            asm.Pushad();

            asm.Mov_EAX_DWORD_Ptr(Offset.get().gameAddress());
            asm.Mov_ESI_DWORD_Ptr_EAX_Add(Offset.get().self_structure());
            asm.Mov_ECX_DWORD_Ptr_ESI_Add(0x1050);
            asm.Push68(0x01);
            asm.Mov_EDX(Offset.get().call_walk1());
            asm.Call_EDX();

            asm.Mov_EDI_EAX();
            asm.Lea_EAX_DWORD_Ptr_ESP_Add(0x18);
            asm.Push_EAX();
            asm.Push6A(walkMode);
            asm.Mov_ECX_EDI();
            asm.Mov_EBX(Offset.get().call_walk2());
            asm.Call_EBX();

            asm.Mov_ECX_DWORD_Ptr_ESI_Add(0x1050);
            asm.Push6A(0x00);
            asm.Push6A(0x01);
            asm.Push_EDI();
            asm.Push6A(0x01);
            asm.Mov_EBX(Offset.get().call_walk3());
            asm.Call_EBX();

            asm.Mov_EAX_DWORD_Ptr(Offset.get().gameAddress());
            asm.Mov_EAX_DWORD_Ptr_EAX_Add(Offset.get().self_structure());
            asm.Mov_EAX_DWORD_Ptr_EAX_Add(0x1050);
            asm.Mov_EAX_DWORD_Ptr_EAX_Add(0x30);
            asm.Mov_ECX_DWORD_Ptr_EAX_Add(0x04);
            asm.Mov_EAX(x);
            asm.Mov_DWORD_Ptr_ECX_ADD_EAX(0x20);
            asm.Mov_EAX(z);
            asm.Mov_DWORD_Ptr_ECX_ADD_EAX(0x24);
            asm.Mov_EAX(y);
            asm.Mov_DWORD_Ptr_ECX_ADD_EAX(0x28);


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
