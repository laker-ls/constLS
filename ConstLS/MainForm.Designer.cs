namespace ConstLS
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TankHP = new System.Windows.Forms.Label();
            this.TankMP = new System.Windows.Forms.Label();
            this.TankName = new System.Windows.Forms.GroupBox();
            this.selectClientForTank = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCoords = new System.Windows.Forms.Label();
            this.mobName1 = new System.Windows.Forms.GroupBox();
            this.labelWorldId = new System.Windows.Forms.Label();
            this.labelDistance1 = new System.Windows.Forms.Label();
            this.useSkill = new System.Windows.Forms.Button();
            this.refreshClientList = new System.Windows.Forms.Button();
            this.DruidName = new System.Windows.Forms.GroupBox();
            this.selectClientForDruid = new System.Windows.Forms.ComboBox();
            this.DruidMP = new System.Windows.Forms.Label();
            this.DruidHP = new System.Windows.Forms.Label();
            this.setAllClients = new System.Windows.Forms.Button();
            this.TankName.SuspendLayout();
            this.mobName1.SuspendLayout();
            this.DruidName.SuspendLayout();
            this.SuspendLayout();
            // 
            // TankHP
            // 
            this.TankHP.AutoSize = true;
            this.TankHP.Location = new System.Drawing.Point(6, 33);
            this.TankHP.Name = "TankHP";
            this.TankHP.Size = new System.Drawing.Size(22, 13);
            this.TankHP.TabIndex = 0;
            this.TankHP.Text = "HP";
            // 
            // TankMP
            // 
            this.TankMP.AutoSize = true;
            this.TankMP.Location = new System.Drawing.Point(101, 33);
            this.TankMP.Name = "TankMP";
            this.TankMP.Size = new System.Drawing.Size(23, 13);
            this.TankMP.TabIndex = 2;
            this.TankMP.Text = "MP";
            // 
            // TankName
            // 
            this.TankName.Controls.Add(this.selectClientForTank);
            this.TankName.Controls.Add(this.TankMP);
            this.TankName.Controls.Add(this.TankHP);
            this.TankName.Location = new System.Drawing.Point(12, 12);
            this.TankName.Name = "TankName";
            this.TankName.Size = new System.Drawing.Size(130, 269);
            this.TankName.TabIndex = 3;
            this.TankName.TabStop = false;
            this.TankName.Text = "Танк";
            // 
            // selectClientForTank
            // 
            this.selectClientForTank.AccessibleDescription = "";
            this.selectClientForTank.AccessibleName = "";
            this.selectClientForTank.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectClientForTank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectClientForTank.FormattingEnabled = true;
            this.selectClientForTank.Items.AddRange(new object[] {
            "Выберите клиент"});
            this.selectClientForTank.Location = new System.Drawing.Point(6, 148);
            this.selectClientForTank.Name = "selectClientForTank";
            this.selectClientForTank.Size = new System.Drawing.Size(118, 21);
            this.selectClientForTank.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelCoords
            // 
            this.labelCoords.AutoSize = true;
            this.labelCoords.Location = new System.Drawing.Point(6, 34);
            this.labelCoords.Name = "labelCoords";
            this.labelCoords.Size = new System.Drawing.Size(75, 13);
            this.labelCoords.TabIndex = 4;
            this.labelCoords.Text = "Коорды моба";
            // 
            // mobName1
            // 
            this.mobName1.Controls.Add(this.labelWorldId);
            this.mobName1.Controls.Add(this.labelDistance1);
            this.mobName1.Controls.Add(this.labelCoords);
            this.mobName1.Location = new System.Drawing.Point(12, 371);
            this.mobName1.Name = "mobName1";
            this.mobName1.Size = new System.Drawing.Size(332, 62);
            this.mobName1.TabIndex = 5;
            this.mobName1.TabStop = false;
            this.mobName1.Text = "Имя моба 1";
            // 
            // labelWorldId
            // 
            this.labelWorldId.AutoSize = true;
            this.labelWorldId.Location = new System.Drawing.Point(272, 0);
            this.labelWorldId.Name = "labelWorldId";
            this.labelWorldId.Size = new System.Drawing.Size(46, 13);
            this.labelWorldId.TabIndex = 6;
            this.labelWorldId.Text = "WorldID";
            // 
            // labelDistance1
            // 
            this.labelDistance1.AutoSize = true;
            this.labelDistance1.Location = new System.Drawing.Point(251, 34);
            this.labelDistance1.Name = "labelDistance1";
            this.labelDistance1.Size = new System.Drawing.Size(67, 13);
            this.labelDistance1.TabIndex = 5;
            this.labelDistance1.Text = "Расстояние";
            // 
            // useSkill
            // 
            this.useSkill.Location = new System.Drawing.Point(372, 410);
            this.useSkill.Name = "useSkill";
            this.useSkill.Size = new System.Drawing.Size(134, 23);
            this.useSkill.TabIndex = 6;
            this.useSkill.Text = "Действие";
            this.useSkill.UseVisualStyleBackColor = true;
            this.useSkill.Click += new System.EventHandler(this.UseSkill_MouseClick);
            // 
            // refreshClientList
            // 
            this.refreshClientList.Location = new System.Drawing.Point(12, 307);
            this.refreshClientList.Name = "refreshClientList";
            this.refreshClientList.Size = new System.Drawing.Size(149, 40);
            this.refreshClientList.TabIndex = 7;
            this.refreshClientList.Text = "Обновить список окон";
            this.refreshClientList.UseVisualStyleBackColor = true;
            this.refreshClientList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RefreshClientList_MouseClick);
            // 
            // DruidName
            // 
            this.DruidName.Controls.Add(this.selectClientForDruid);
            this.DruidName.Controls.Add(this.DruidMP);
            this.DruidName.Controls.Add(this.DruidHP);
            this.DruidName.Location = new System.Drawing.Point(148, 12);
            this.DruidName.Name = "DruidName";
            this.DruidName.Size = new System.Drawing.Size(138, 269);
            this.DruidName.TabIndex = 8;
            this.DruidName.TabStop = false;
            this.DruidName.Text = "Друид";
            // 
            // selectClientForDruid
            // 
            this.selectClientForDruid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectClientForDruid.FormattingEnabled = true;
            this.selectClientForDruid.Items.AddRange(new object[] {
            "Выберите клиент"});
            this.selectClientForDruid.Location = new System.Drawing.Point(6, 148);
            this.selectClientForDruid.Name = "selectClientForDruid";
            this.selectClientForDruid.Size = new System.Drawing.Size(127, 21);
            this.selectClientForDruid.TabIndex = 4;
            // 
            // DruidMP
            // 
            this.DruidMP.AutoSize = true;
            this.DruidMP.Location = new System.Drawing.Point(109, 33);
            this.DruidMP.Name = "DruidMP";
            this.DruidMP.Size = new System.Drawing.Size(23, 13);
            this.DruidMP.TabIndex = 2;
            this.DruidMP.Text = "MP";
            // 
            // DruidHP
            // 
            this.DruidHP.AutoSize = true;
            this.DruidHP.Location = new System.Drawing.Point(6, 33);
            this.DruidHP.Name = "DruidHP";
            this.DruidHP.Size = new System.Drawing.Size(22, 13);
            this.DruidHP.TabIndex = 0;
            this.DruidHP.Text = "HP";
            // 
            // setAllClients
            // 
            this.setAllClients.Enabled = false;
            this.setAllClients.Location = new System.Drawing.Point(167, 308);
            this.setAllClients.Name = "setAllClients";
            this.setAllClients.Size = new System.Drawing.Size(177, 39);
            this.setAllClients.TabIndex = 9;
            this.setAllClients.Text = "Применить выбранные окна";
            this.setAllClients.UseVisualStyleBackColor = true;
            this.setAllClients.Click += new System.EventHandler(this.SetAllClients_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 445);
            this.Controls.Add(this.setAllClients);
            this.Controls.Add(this.DruidName);
            this.Controls.Add(this.refreshClientList);
            this.Controls.Add(this.useSkill);
            this.Controls.Add(this.mobName1);
            this.Controls.Add(this.TankName);
            this.Name = "MainWindow";
            this.Text = "constLS";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TankName.ResumeLayout(false);
            this.TankName.PerformLayout();
            this.mobName1.ResumeLayout(false);
            this.mobName1.PerformLayout();
            this.DruidName.ResumeLayout(false);
            this.DruidName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TankHP;
        private System.Windows.Forms.Label TankMP;
        private System.Windows.Forms.GroupBox TankName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCoords;
        private System.Windows.Forms.GroupBox mobName1;
        private System.Windows.Forms.Label labelDistance1;
        private System.Windows.Forms.Button useSkill;
        private System.Windows.Forms.Label labelWorldId;
        private System.Windows.Forms.ComboBox selectClientForTank;
        private System.Windows.Forms.Button refreshClientList;
        private System.Windows.Forms.GroupBox DruidName;
        private System.Windows.Forms.ComboBox selectClientForDruid;
        private System.Windows.Forms.Label DruidMP;
        private System.Windows.Forms.Label DruidHP;
        private System.Windows.Forms.Button setAllClients;
    }
}

