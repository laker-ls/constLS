using System;
using System.Text;

namespace ConstLS.Memory
{
    class ReadMemory
    {
        private int clientId;

        public ReadMemory(int clientId)
        {
            this.clientId = clientId;
        }

        public Int32 as4byte(Int32 address)
        {
            byte[] buffer = this.readMemory(address, 4);
            return BitConverter.ToInt32(buffer, 0);
        }

        public Single asFloat(Int32 address)
        {
            byte[] buffer = this.readMemory(address, 4);
            return BitConverter.ToSingle(buffer, 0);
        }

        public bool asBoolean(Int32 address)
        {
            byte[] buffer = this.readMemory(address, 4);
            return BitConverter.ToBoolean(buffer, 0);
        }

        public String asString(Int32 address, Int32 length)
        {
            byte[] buffer = this.readMemory(address, length);

            var enc = new UnicodeEncoding();
            var rtnStr = enc.GetString(buffer);
            return (rtnStr.IndexOf('\0') != -1) ? rtnStr.Substring(0, rtnStr.IndexOf('\0')) : rtnStr;
        }

        private byte[] readMemory(Int32 address, Int32 length)
        {
            byte[] memory = {};
            if (address != 0) {
                IntPtr hProcess = Memory.openProcess(this.clientId);
                memory = Memory.readProcessMemory(hProcess, address, length);
                Memory.closeHandle(hProcess);
            }

            return memory;
        }
    }
}
