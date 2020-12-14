using System;
using System.Threading;

namespace ConstLS.Memory
{
    class WriteMemory
    {
        private int clientId;
        public Int32 allocMemoryAddress;

        public WriteMemory(int clientId, Int32 allocMemoryAddress)
        {
            this.clientId = clientId;
            this.allocMemoryAddress = allocMemoryAddress;
        }

        public void inAllocMemory(byte[] data)
        {
            IntPtr hProcess = Memory.openProcess(this.clientId);
            Memory.writeProcessMemory(hProcess, this.allocMemoryAddress, data);
            IntPtr hProcThread = Memory.createRemoteThread(hProcess, this.allocMemoryAddress);
            Memory.waitForSingleObject(hProcThread);
            Memory.closeHandle(hProcThread);
            Memory.closeHandle(hProcess);
        }

        public void packet(byte[] body)
        {
            IntPtr hProcess = Memory.openProcess(this.clientId);
            Memory.writeProcessMemory(hProcess, this.allocMemoryAddress, body);
            Memory.closeHandle(hProcess);
        }
    }
}
