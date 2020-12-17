using System;
using System.Threading;

namespace ConstLS.Memory
{
    class WriteMemory
    {
        private int clientId;
        private Int32 allocMemoryFunction;
        private Int32 allocMemoryPacket;

        public WriteMemory(ClientMemory client)
        {
            this.clientId = client.id;
            this.allocMemoryFunction = client.allocMemoryFunction;
            this.allocMemoryPacket = client.allocMemoryPacket;
        }

        public void inAllocMemory(byte[] data)
        {
            IntPtr hProcess = Memory.openProcess(this.clientId);
            Memory.writeProcessMemory(hProcess, this.allocMemoryFunction, data);
            IntPtr hProcThread = Memory.createRemoteThread(hProcess, this.allocMemoryFunction);
            Memory.waitForSingleObject(hProcThread);
            Memory.closeHandle(hProcThread);
            Memory.closeHandle(hProcess);
        }

        public void packet(byte[] body)
        {
            IntPtr hProcess = Memory.openProcess(this.clientId);
            Memory.writeProcessMemory(hProcess, this.allocMemoryPacket, body);
            Memory.closeHandle(hProcess);
        }
    }
}
