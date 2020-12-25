using System;
using System.Windows.Forms;
using ConstLS.Memory;
using System.Drawing;
using ConstLS.CoordinationCenter;
using System.Diagnostics;
using ConstLS.CoordinationCenter.Units;
using ConstLS.KeyAndMouseHook;
using ConstLS.Memory.Offsets;

namespace ConstLS
{
    public partial class MainWindow : Form
    {
        protected readonly GlobalHook hook;
        private Coordination CoordinationCenter;

        Process processForTank;
        Process processForDruid;

        public MainWindow()
        {
            InitializeComponent();
            this.hook = new GlobalHook();
            this.CoordinationCenter = new Coordination();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.setServerList();
        }

        private void UpdateClients_Click(object sender, EventArgs e)
        {
            this.setServerList();
        }

        private void setServerList()
        {
            serverList.Items.Clear();
            
            Process[] gameProcesses = Process.GetProcessesByName("elementclient");
            bool unique = true;
            foreach (Process gameProcess in gameProcesses) {
                foreach (string item in serverList.Items) {
                    string itemWithoutSpace = item.Replace(" ", "");
                    string windowTitleWithoutSpace = gameProcess.MainWindowTitle.ToString().Replace(" ", "");
                    if (itemWithoutSpace.Contains(windowTitleWithoutSpace)) {
                        unique = false;
                        break;
                    }
                }
                if (unique) {
                    serverList.Items.Add(gameProcess.MainWindowTitle);
                }
            }

            if (serverList.Items[0] == null) {
                serverList.Items.Add("Ни один игровой клиент не запущен.");
            }

            serverList.Text = serverList.Items[0].ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (CoordinationCenter.Tank == null && processForTank != null) {
                CoordinationCenter.Tank = new TankUnit(processForTank);
            } else if (CoordinationCenter.Tank != null && processForTank == null) {
                CoordinationCenter.Tank = null;
            }
            if (CoordinationCenter.Druid == null && processForDruid != null) {
                CoordinationCenter.Druid = new DruidUnit(processForDruid);
            } else if (CoordinationCenter.Druid != null && processForDruid == null) {
                CoordinationCenter.Druid = null;
            }

            if (processForTank != null) {
                tankIsFound.Text = "Подключен";
                tankIsFound.ForeColor = Color.Green;
            } else {
                tankIsFound.Text = "Не найден";
                tankIsFound.ForeColor = Color.Red;
            }
            if (processForDruid != null) {
                druidIsFound.Text = "Подключен";
                druidIsFound.ForeColor = Color.Green;
            } else {
                druidIsFound.Text = "Не найден";
                druidIsFound.ForeColor = Color.Red;
            }

            //if (CoordinationCenter.Tank != null && CoordinationCenter.Druid != null) {
            //    this.CoordinationCenter.assistFirstSubgroup();
            //}
        }

        private void serverList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Offset.setGameServer(serverList.SelectedItem.ToString());
            this.setProcessesGame(serverList.SelectedItem.ToString());
        }

        private void setProcessesGame(string selectedServer)
        {
            this.processForTank = ClientMemory.connect("TankLS", selectedServer);
            this.processForDruid = ClientMemory.connect("DruidLS", selectedServer);
        }
    }
}
