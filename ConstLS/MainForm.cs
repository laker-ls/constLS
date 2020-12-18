using System;
using System.Windows.Forms;
using ConstLS.Memory;
using System.Drawing;
using ConstLS.CoordinationCenter;
using System.Diagnostics;
using ConstLS.CoordinationCenter.Units;
using ConstLS.KeyAndMouseHook;
using System.Threading;
using System.Threading.Tasks;

namespace ConstLS
{
    public partial class MainWindow : Form
    {
        protected readonly GlobalHook hook;
        private Coordination CoordinationCenter;

        public MainWindow()
        {
            InitializeComponent();
            this.hook = new GlobalHook();
            this.CoordinationCenter = new Coordination();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //hook.KeyDown += (s, ev) => {
            //    if (ev.KeyCode == Keys.LShiftKey) {
            //        if (CoordinationCenter.Tank != null && CoordinationCenter.Druid != null) {
            //            this.CoordinationCenter.launch();
            //        }
            //    }
            //};
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (CoordinationCenter.Tank != null && CoordinationCenter.Druid != null) {
                this.CoordinationCenter.launch();
            }

            Process processForTank = ClientMemory.connect("TankLS");
            Process processForDruid = ClientMemory.connect("DruidLS");

            if (CoordinationCenter.Tank == null && processForTank != null) {
                CoordinationCenter.Tank = new TankUnit(processForTank);
            }
            if (CoordinationCenter.Druid == null && processForDruid != null) {
                CoordinationCenter.Druid = new DruidUnit(processForDruid);
            }

            if (CoordinationCenter.Tank != null) {
                tankIsFound.Text = "Подключен";
                tankIsFound.ForeColor = Color.Green;
            } else {
                tankIsFound.Text = "Не найден";
                tankIsFound.ForeColor = Color.Red;
            }
            if (CoordinationCenter.Druid != null) {
                druidIsFound.Text = "Подключен";
                druidIsFound.ForeColor = Color.Green;
            } else {
                druidIsFound.Text = "Не найден";
                druidIsFound.ForeColor = Color.Red;
            }
        }

        private void ListOfClients_Enter(object sender, EventArgs e)
        {

        }

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
