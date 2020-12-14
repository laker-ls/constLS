using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstLS.Memory;

namespace ConstLS.Unit
{
    class Action
    {
        private ClientMemory pwClient;

        public Action(ClientMemory pwClient)
        {
            this.pwClient = pwClient;
        }

        public void skill() // TODO: не работает
        {
            ASM asm = new ASM();
            asm.Pushad();

            asm.Mov_EBX(0x0093E05C);

            asm.Mov_ESI(0x1AB584E0);
            asm.Mov_EDI(0x01);
            asm.Mov_EAX(0x7D);

            asm.Mov_ECX_DWORD_Ptr(OffsetInMemory.BaseAddress);
            asm.Mov_EAX_DWORD_Ptr_EAX(0x08);
            asm.Mov_EDX_DWORD_Ptr_ECX_Add(0x1C);
            asm.Push_ESI();
            asm.Mov_ESI_DWORD_Ptr_EDX_Add(0x34);
            asm.Push_EDI();
            asm.Push_EAX();
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
            asm.Mov_EDX(0x00632150);

            asm.Mov_EAX_DWORD_Ptr(0x00A591E0);
            asm.Mov_ECX_DWORD_Ptr_EAX_Add(0x20);
            asm.Add_ECX(0xEC);
            asm.Push_EDI();
            asm.Call_EDX();

            asm.Popad();
            asm.Ret();

            this.sendInGame(asm.inBytes());
        }

        public void sendPacket() // TODO: не работает
        {
            int lengthPacket = 0x04;
            int bodyPacket = 0x22222222;
            //byte[] bodyPacket = { 30, 00, 00, 00 };

            ASM asm = new ASM();
            asm.Pushad();

            //asm.Mov_ESI(bodyPacket);
            //asm.Mov_EDI(OffsetInMemory.callPacket);
            asm.Mov_EDI(0x0063F890);

            asm.Mov_ECX_DWORD_Ptr(OffsetInMemory.BaseAddress);
            asm.Mov_ECX_DWORD_Ptr_ECX_Add(0x20);
            asm.Push6A(lengthPacket);
            asm.Push68(bodyPacket);
            asm.Call_EDI();

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
