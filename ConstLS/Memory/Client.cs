using System.Diagnostics;

namespace ConstLS.Memory
{
    class Client
    {
        public MemoryRead read;
        public MemoryWrite write;

        private Process client;
        private int pid;

        public Client(string processName, int processNumber)
        {
            Process[] clients = Process.GetProcessesByName(processName);
            this.client = clients[processNumber];
            this.pid = client.Id;

            read = new MemoryRead(client.Id);
        }
    }
}
