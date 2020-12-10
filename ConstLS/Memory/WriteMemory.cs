using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstLS.Memory
{
    class WriteMemory
    {
        private IntPtr hProcess;
        private Int32 pathFunction;
        private Int32 pathParameters;

        public WriteMemory(IntPtr hProcess)
        {
            this.hProcess = hProcess;
        }

        public void memoryAllocation()
        {
            const int MEM_COMMIT = 0x1000, PROTECTION_READ_WRITE = 0x04;
            Int32 allocation = WinApiMemory.VirtualAllocEx(hProcess, 0, 511, MEM_COMMIT, PROTECTION_READ_WRITE);
            this.pathFunction = allocation;
            this.pathParameters = allocation + 64;  
        }
    }
}
