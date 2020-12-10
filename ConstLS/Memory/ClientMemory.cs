using System;
using System.Diagnostics;

namespace ConstLS.Memory
{
    class ClientMemory
    {
        public ReadMemory read;
        public WriteMemory write;

        public ClientMemory(string processName, int processNumber)
        {
            Process[] clients = Process.GetProcessesByName(processName);
            Process client = clients[processNumber];

            const int PROCESS_All_ACCESS = 0x001F0FFF;
            IntPtr hProcess = WinApiMemory.OpenProcess(PROCESS_All_ACCESS, false, client.Id);

            this.read = new ReadMemory(hProcess);

            this.write = new WriteMemory(hProcess);
        }
    }
}
