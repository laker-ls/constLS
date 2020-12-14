﻿using System;
using System.Windows.Forms;
using ConstLS.Memory;
using ConstLS.Unit;
using ConstLS.Parameters;

namespace ConstLS
{
    public partial class MainWindow : Form
    {
        int mobWID;
        Druid Druid;

        public MainWindow()
        {
            InitializeComponent();

            //TopMost = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

            this.Druid = new Druid();

            this.mobWID = Druid.mob.worldID();

            unitName1.Text = Druid.self.name();
            labelHP.Text = "HP: " + Druid.self.HP().ToString() + "/" + Druid.self.maxHP().ToString();
            labelMP.Text = "MP: " + Druid.self.MP().ToString() + "/" + Druid.self.maxMP().ToString();

            mobName1.Text = Druid.mob.searchName();
            labelWorldId.Text = this.mobWID.ToString();
            labelCoords.Text = Druid.mob.mobSearch();
            labelDistance1.Text = "Distance: " + Druid.mob.searchDistance().ToString();
        }

        private void LabelMP_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Druid.use.skill();
        }
    }
}
