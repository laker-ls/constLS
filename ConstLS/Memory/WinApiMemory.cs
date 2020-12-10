using System;
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

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern int VirtualAllocEx(
            IntPtr hProcess, 
            Int32 lpAddress,
            Int32 dwSize, 
            Int32 flAllocationType, 
            Int32 flProtect
        );

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(
            IntPtr hProcess,
            Int32 lpBaseAddress,
            [In, Out] Byte[] buffer,
            Int32 nSize,
            out Int32 lpNumberOfBytesWritten
        );

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateRemoteThread(
            IntPtr hProcess,
            IntPtr lpThreadAttributes, 
            int dwStackSize, Int32 lpStartAddress,
            Int32 lpParameter, 
            int dwCreationFlags, 
            out IntPtr lpThreadId
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern UInt32 WaitForSingleObject(
            IntPtr hHandle, 
            Int32 dwMilliseconds
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hObject);
    }
}
