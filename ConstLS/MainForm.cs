using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using ConstLS.Unit;
using ConstLS.Memory;

namespace ConstLS
{
    public partial class MainWindow : Form
    {
        Client client;

        TankUnit Tank;
        DruidUnit Druid;

        int mobWID;

        private void listClient()
        {
            List<string> labelsOfClients = client.displayAll();
            foreach (string label in labelsOfClients) {
                selectClientForTank.Items.Add(label);
                selectClientForDruid.Items.Add(label);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            selectClientForTank.SelectedIndex = 0;
            selectClientForDruid.SelectedIndex = 0;

            client = new Client();

            //TopMost = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.listClient();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (selectClientForTank.SelectedIndex != 0 && selectClientForDruid.SelectedIndex != 0) {
                setAllClients.Enabled = true;
            } else {
                setAllClients.Enabled = false;
            }

            if (this.Tank != null) {
                TankName.Text = Tank.self.name();
                TankHP.Text = Tank.self.percentHP().ToString();
            }
        }

        private void RefreshClientList_MouseClick(object sender, MouseEventArgs e)
        {
            selectClientForTank.Items.Clear();
            selectClientForDruid.Items.Clear();
            this.listClient();
        }

        private void UseSkill_MouseClick(object sender, EventArgs e)
        {
            byte[] bodyPacket = { 0x2e, 0x0 };
            Druid.useAction.autoAttack();
        }

        private void SetAllClients_Click(object sender, EventArgs e)
        {
            Process TankClient = client.select(selectClientForTank.SelectedIndex - 1);
            Process DruidClient = client.select(selectClientForDruid.SelectedIndex - 1);

            this.Tank = new TankUnit(TankClient);
            this.Druid = new DruidUnit(DruidClient);
        }
    }
}
