using System;

namespace ConstLS.Memory
{
    class MemoryRead
    {
        private int pid;
        private int PROCESS_All_ACCESS = 0x001F0FFF;


        public MemoryRead(int pid)
        {
            this.pid = pid;
        }

        public Int32 byte4(Int32 address)
        {
            int read; var buffer = new byte[4];

            IntPtr hProcess = WinApiMemory.OpenProcess(this.PROCESS_All_ACCESS, false, pid);

            WinApiMemory.ReadProcessMemory(hProcess, address, buffer, buffer.Length, out read);
            return BitConverter.ToInt32(buffer, 0);
        }

        private int BaseAddress = 0x905A4D;
        private int GameAddress = 0x5B4594;
        private Int32 Personage()
        {
            Int32 buffer;
            buffer = this.byte4(GameAddress);
            buffer = this.byte4(GameAddress + 0x20);
            return buffer;
        }

        public Int32 HP()
        {
            Int32 buffer;
            buffer = this.byte4(GameAddress);
            buffer = this.byte4(GameAddress + 0x20);
            buffer = this.byte4(buffer + 0x46C);
            return buffer;
        }
    }
}
