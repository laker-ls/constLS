using System;

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
            IntPtr hProcess = WorkWithMemory.openProcess(this.clientId);
            WorkWithMemory.writeProcessMemory(hProcess, this.allocMemoryFunction, data);
            IntPtr hProcThread = WorkWithMemory.createRemoteThread(hProcess, this.allocMemoryFunction);
            WorkWithMemory.waitForSingleObject(hProcThread);
            WorkWithMemory.closeHandle(hProcThread);
            WorkWithMemory.closeHandle(hProcess);
        }

        public void packet(byte[] body)
        {
            IntPtr hProcess = WorkWithMemory.openProcess(this.clientId);
            WorkWithMemory.writeProcessMemory(hProcess, this.allocMemoryPacket, body);
            WorkWithMemory.closeHandle(hProcess);
        }
    }
}
