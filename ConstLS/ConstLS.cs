using System;
using System.Windows.Forms;
using ConstLS.Memory;

namespace ConstLS
{
    public partial class MainWindow : Form
    {
        Client pwClient;

        public MainWindow()
        {
            InitializeComponent();
            pwClient = new Client("elementclient", 0);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            labelHP.Text = pwClient.read.HP().ToString();
        }

        private void Attack_Click(object sender, EventArgs e)
        {

        }
    }
}
