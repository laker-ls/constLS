using System;
using System.Windows.Forms;
using ConstLS.Memory;
using ConstLS.CoordinationCenter;
using System.Diagnostics;
using ConstLS.Units;
using ConstLS.Memory.Offsets;

namespace ConstLS
{
    public partial class MainWindow : Form
    {
        private Coordination CoordinationCenter;

        Process processForTank;
        Process processForDruid;

        public MainWindow()
        {
            InitializeComponent();
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

            this.CoordinationCenter.loop();

            this.displayMode(CoordinationCenter.mode);
            this.displayStatus();
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
