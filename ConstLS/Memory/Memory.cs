using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstLS.Memory
{
    class Memory
    {
        public static IntPtr openProcess(int processId)
        {
            IntPtr hProcess = WinApiMemory.OpenProcess(WinApiMemory.ProcessAccessFlags.All, false, processId);
            if (hProcess == IntPtr.Zero) {
                throw new Exception("Не удалось открыть процесс для записи в выделенную память.");
            }

            return hProcess;
        }

        public static void closeHandle(IntPtr hProcess)
        {
            bool isClosed = WinApiMemory.CloseHandle(hProcess);
            if (!isClosed) {
                throw new Exception("Не удалось закрыть процесс.");
            }
        }

        public static int virtualAllocEx(IntPtr hProcess, int size)
        {
            const int MEM_COMMIT = 0x1000, PROTECTION_READ_WRITE = 0x04;
            int allocMemoryAddress = WinApiMemory.VirtualAllocEx(hProcess, 0, size, MEM_COMMIT, PROTECTION_READ_WRITE);
            if (allocMemoryAddress == 0) {
                WinApiMemory.CloseHandle(hProcess);
                throw new Exception("Не удалось выделить память в процессе.");
            }

            return allocMemoryAddress;
        }

        public static byte[] readProcessMemory(IntPtr hProcess, int address, int length)
        {
            int read = 0; var buffer = new byte[length];
            int readedMemory = WinApiMemory.ReadProcessMemory(hProcess, address, buffer, length, out read);
            if (length != read) {
                WinApiMemory.CloseHandle(hProcess);
                throw new Exception("Не удалось прочитать фрагмент памяти.");
            }

            return buffer;
        }

        public static void writeProcessMemory(IntPtr hProcess, int allocMemoryAddress, byte[] data)
        {
            int numberOfBytesWritten = 0;
            bool writeSuccess = WinApiMemory.WriteProcessMemory(hProcess, allocMemoryAddress, data, data.Length, out numberOfBytesWritten);
            if (!writeSuccess || data.Length != numberOfBytesWritten) {
                WinApiMemory.CloseHandle(hProcess);
                throw new Exception("Не удалось записать данные в выделенную память.");
            }
        }

        public static IntPtr createRemoteThread(IntPtr hProcess, int allocMemoryAddress)
        {
            IntPtr threadId = IntPtr.Zero;
            IntPtr hProcThread = WinApiMemory.CreateRemoteThread(hProcess, IntPtr.Zero, 0, allocMemoryAddress, IntPtr.Zero, 0, out threadId);
            if (hProcThread == IntPtr.Zero) {
                WinApiMemory.CloseHandle(hProcess);
                throw new Exception("Не удалось создать поток.");
            }

            return hProcThread;
        }

        // WaitForSingleObject(hProcThread,INFINITE);
        public static uint waitForSingleObject(IntPtr hProcThread)
        {
            const int INFINITE = -1;
            return WinApiMemory.WaitForSingleObject(hProcThread, INFINITE);
        }
    }
}
