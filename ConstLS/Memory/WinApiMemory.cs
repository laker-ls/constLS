using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConstLS.Memory
{
    class WinApiMemory
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(
            int dwDesitedAccess, 
            bool bInheritHandle, 
            int dwProcessID
        );

        [DllImport("kernel32.dll")]
        public static extern Int32 ReadProcessMemory(
            IntPtr hProcess,
            Int32 lpBaseAddress,
            [In, Out] Byte[] buffer,
            Int32 size,
            out Int32 lpNumberOfBytesRead
        );
    }
}
