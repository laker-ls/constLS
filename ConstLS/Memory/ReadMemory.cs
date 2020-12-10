using System;
using System.Text;

namespace ConstLS.Memory
{
    class ReadMemory
    {
        IntPtr hProcess;

        public ReadMemory(IntPtr hProcess)
        {
            this.hProcess = hProcess;
        }

        public Int32 as4byte(Int32 address)
        {
            int read; var buffer = new byte[4];
            WinApiMemory.ReadProcessMemory(this.hProcess, address, buffer, buffer.Length, out read);

            return BitConverter.ToInt32(buffer, 0);
        }

        public Single asFloat(Int32 address)
        {
            int read; var buffer = new byte[4];
            WinApiMemory.ReadProcessMemory(this.hProcess, address, buffer, buffer.Length, out read);

            return BitConverter.ToSingle(buffer, 0);
        }

        public String asString(Int32 address, Int32 length)
        {
            int read; var buffer = new byte[length];
            WinApiMemory.ReadProcessMemory(this.hProcess, address, buffer, buffer.Length, out read);

            var enc = new UnicodeEncoding();
            var rtnStr = enc.GetString(buffer);
            return (rtnStr.IndexOf('\0') != -1) ? rtnStr.Substring(0, rtnStr.IndexOf('\0')) : rtnStr;
        }
    }
}
