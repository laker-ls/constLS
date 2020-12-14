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
            Process client = Process.GetProcessesByName(processName)[processNumber];
            Int32 allocMemoryAddress = this.memoryAllocation(client.Id);

            this.read = new ReadMemory(client.Id);
            this.write = new WriteMemory(client.Id, allocMemoryAddress);
        }

        private Int32 memoryAllocation(int id)
        {
            IntPtr hProcess = Memory.openProcess(id);
            Int32 allocMemoryAddress = Memory.virtualAllocEx(hProcess, 2500);
            Memory.closeHandle(hProcess);

            return allocMemoryAddress;
        }
    }
}
