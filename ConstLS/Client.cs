using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using ConstLS.Unit;
using ConstLS.Memory.Offsets;

namespace ConstLS
{
    class Client
    {
        private Process[] clients;
        public Client()
        {
            this.clients = Process.GetProcessesByName("elementclient");
        }

        public List<string> displayAll()
        {
            List<string> listClients = new List<string>();
            for (int i = 0; i < this.clients.Length; i++) {
                UnitBase RandomUnit = new UnitBase(this.clients[i]);
                string unitName = RandomUnit.self.name();
                if (unitName != "") {
                    listClients.Add("(" + RandomUnit.self.name() + ") " + this.clients[i].MainWindowTitle);
                } else {
                    listClients.Add(this.clients[i].MainWindowTitle);
                }
            }

            return listClients;
        }

        public Process select(int index)
        {
            return clients[index];
        }
    }
}
