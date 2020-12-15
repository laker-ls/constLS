using ConstLS.Memory;
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

        public void skill() // TODO: не работает
        {
            ASM asm = new ASM();
            asm.Pushad();

            asm.Mov_EBX(Offset.call.skill);

            asm.Mov_ECX_DWORD_Ptr(Offset.baseAddress);
            asm.Mov_ECX_DWORD_Ptr_ECX_Add(0x1C);
            asm.Mov_ECX_DWORD_Ptr_ECX_Add(0x20);
            asm.Push68(-1);
            asm.Push6A(0x00);
            asm.Push6A(0x00);
            asm.Mov_EDX(0x7D);
            asm.Push_EDX();
            asm.Call_DWORD_Ptr_EBX();

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
