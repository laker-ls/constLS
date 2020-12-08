using System;
using System.Windows.Forms;
using ConstLS.classes;
using ConstLS;
using System.Diagnostics;

namespace ConstLS
{
    public partial class MainWindow : Form
    {
        Process client = new Process();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Kill();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int[] HP = new int[] { Offset.Personage.self, Offset.Personage.HP };
            int[] MP = new int[] { Offset.Personage.self, Offset.Personage.type };
            //labelHP.Text = "HP: " + memoryReader.pointerData(HP).ToString();
            //labelMP.Text = "type: " + memoryReader.pointerData(MP).ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            client.StartInfo.WorkingDirectory = "C:\\Program Files (x86)\\Perfect World Classic\\element";
            client.StartInfo.FileName = "C:\\Program Files (x86)\\Perfect World Classic\\element\\elementclient.exe";
            client.Start();
        }

        
    }
}
