using System;
using System.Threading;

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

        public void inject(byte[] func, byte[] param)
        {
            int ipNumberWritten = 0; IntPtr lpThreadId = IntPtr.Zero;

            WinApiMemory.WriteProcessMemory(this.hProcess, this.pathFunction, func, 250, out ipNumberWritten);
            WinApiMemory.WriteProcessMemory(this.hProcess, this.pathParameters, param, 250, out ipNumberWritten);

            IntPtr hProcThread = WinApiMemory.CreateRemoteThread(this.hProcess, IntPtr.Zero, 0, this.pathFunction, this.pathParameters, 0, out lpThreadId);
            WinApiMemory.WaitForSingleObject(hProcThread, Timeout.Infinite);
            WinApiMemory.CloseHandle(hProcThread);
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
