using ConstLS.CoordinationCenter.Units;
using System;
using System.Diagnostics;

namespace ConstLS.Memory
{
    class ClientMemory
    {
        public ReadMemory read;
        public WriteMemory write;

        public Int32 id;
        public Int32 allocMemoryFunction;
        public Int32 allocMemoryPacket;

        public ClientMemory(Process clientProcess)
        {
            this.id = clientProcess.Id;

            Int32 allocMemoryAddress = this.memoryAllocation();
            memoryAllocationOffsets(allocMemoryAddress);

            this.read = new ReadMemory(clientProcess.Id);
            this.write = new WriteMemory(this);
        }

        private Int32 memoryAllocation()
        {
            IntPtr hProcess = Memory.openProcess(this.id);
            Int32 allocMemoryAddress = Memory.virtualAllocEx(hProcess, 1023);
            Memory.closeHandle(hProcess);

            return allocMemoryAddress;
        }

        private void memoryAllocationOffsets(Int32 allocMemoryAddress)
        {
            this.allocMemoryFunction = allocMemoryAddress;
            this.allocMemoryPacket = (allocMemoryAddress + 500);
        }

        public static Process connect(string nameOfPersonage)
        {
            Process[] pwClients = Process.GetProcessesByName("elementclient");

            Process needClient = null;
            for (int i = 0; i < pwClients.Length; i++) {
                UnitBase RandomUnit = new UnitBase(pwClients[i]);
                if (RandomUnit.self.isExist() && RandomUnit.self.name() == nameOfPersonage) {
                    needClient = pwClients[i];
                }
            }
            return needClient;
        }
    }
}
