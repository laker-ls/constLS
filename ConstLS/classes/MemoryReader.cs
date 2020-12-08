using System;
using System.Diagnostics;

namespace ConstLS.classes
{
    public class MEMORY_READER
    {
        private Process[] elementclients;
        private VAMemory clientMemory;
        private ProcessModule module;
        private IntPtr BaseAddress;

        public MEMORY_READER(string processName, int processNumber)
	    {
            this.elementclients = Process.GetProcessesByName(processName);
            this.clientMemory = new VAMemory(processName);
            this.module = elementclients[processNumber].Modules[0];

            this.BaseAddress = (module.BaseAddress + 0x5B4594);
        }

        public int pointerData(Array pointers)
        {
            int data = this.clientMemory.ReadInt32(this.BaseAddress);
            foreach (int pointer in pointers)
            {
                data = this.clientMemory.ReadInt32((IntPtr)data + pointer);
            }

            return data;
        }
    }
}
