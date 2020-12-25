using ConstLS.Memory.Offsets;
using System;

namespace ConstLS.Memory.Injections
{
    class BaseInjection
    {
        protected ClientMemory pwClient;

        public BaseInjection(ClientMemory pwClient)
        {
            this.pwClient = pwClient;
        }

        protected void sendWithoutParamter(byte[] packet)
        {
            this.send(packet);
        }

        protected void sendWithOneParameter(byte[] packet, int parameter, int destinationPacket, int lengthParameter = 4)
        {
            byte[] parameterAsByte = BitConverter.GetBytes(parameter);
            byte[] modifiedPacket = packet;
            Array.Copy(parameterAsByte, 0, modifiedPacket, destinationPacket, lengthParameter);
            byte[] test = modifiedPacket;
            this.send(modifiedPacket);
        }

        protected void sendWithTwoParameter(byte[] packet, int[] parameters, int[] destinationPackets, int lengthEachParameter = 4)
        {
            byte[] parameterAsByte = BitConverter.GetBytes(parameters[0]);
            byte[] parameterSecondAsByte = BitConverter.GetBytes(parameters[1]);
            byte[] modifiedPacket = packet;
            Array.Copy(parameterAsByte, 0, modifiedPacket, destinationPackets[0], lengthEachParameter);
            Array.Copy(parameterSecondAsByte, 0, modifiedPacket, destinationPackets[1], lengthEachParameter);
            this.send(modifiedPacket);
        }

        private void send(byte[] bodyPacket)
        {
            pwClient.write.packet(bodyPacket);

            ASM asm = new ASM();
            asm.Pushad();

            asm.Mov_EAX(Offset.get().call_packet());

            asm.Mov_ECX_DWORD_Ptr(Offset.get().baseAddress());
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
