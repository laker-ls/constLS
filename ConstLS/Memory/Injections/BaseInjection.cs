using ConstLS.Memory.Offsets;

namespace ConstLS.Memory.Injections
{
    class BaseInjection
    {
        protected ClientMemory pwClient;

        public BaseInjection(ClientMemory pwClient)
        {
            this.pwClient = pwClient;
        }
        

        public void send(byte[] bodyPacket)
        {
            pwClient.write.packet(bodyPacket);

            ASM asm = new ASM();
            asm.Pushad();

            asm.Mov_EAX(Offset.call.packet);

            asm.Mov_ECX_DWORD_Ptr(Offset.baseAddress);
            asm.Mov_ECX_DWORD_Ptr_ECX_Add(0x20);
            asm.Mov_EDI(pwClient.allocMemoryPacket);
            asm.Push6A(bodyPacket.Length);
            asm.Push_EDI();
            asm.Call_EAX();

            asm.Popad();
            asm.Ret();

            pwClient.write.inAllocMemory(asm.inBytes());
        }
    }
}
