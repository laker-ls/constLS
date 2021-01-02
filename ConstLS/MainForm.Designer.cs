using System.Diagnostics;
using System.Drawing;

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
            this.groupFirst = new System.Windows.Forms.GroupBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.modeName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serverList = new System.Windows.Forms.ComboBox();
            this.updateClients = new System.Windows.Forms.Button();
            this.druidIsFound = new System.Windows.Forms.Label();
            this.tankIsFound = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupFirst.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFirst
            // 
            this.groupFirst.Controls.Add(this.modeLabel);
            this.groupFirst.Controls.Add(this.modeName);
            this.groupFirst.Controls.Add(this.groupBox1);
            this.groupFirst.Controls.Add(this.updateClients);
            this.groupFirst.Controls.Add(this.druidIsFound);
            this.groupFirst.Controls.Add(this.tankIsFound);
            this.groupFirst.Controls.Add(this.label2);
            this.groupFirst.Controls.Add(this.label1);
            this.groupFirst.Location = new System.Drawing.Point(12, 12);
            this.groupFirst.Name = "groupFirst";
            this.groupFirst.Size = new System.Drawing.Size(408, 111);
            this.groupFirst.TabIndex = 3;
            this.groupFirst.TabStop = false;
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(6, 0);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(90, 13);
            this.modeLabel.TabIndex = 8;
            this.modeLabel.Text = "Игровой режим:";
            // 
            // modeName
            // 
            this.modeName.AutoSize = true;
            this.modeName.Location = new System.Drawing.Point(93, 0);
            this.modeName.Name = "modeName";
            this.modeName.Size = new System.Drawing.Size(33, 13);
            this.modeName.TabIndex = 7;
            this.modeName.Text = "mode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serverList);
            this.groupBox1.Location = new System.Drawing.Point(152, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 45);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбранный сервер";
            // 
            // serverList
            // 
            this.serverList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverList.FormattingEnabled = true;
            this.serverList.Location = new System.Drawing.Point(6, 16);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(242, 21);
            this.serverList.TabIndex = 0;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            // 
            // updateClients
            // 
            this.updateClients.Location = new System.Drawing.Point(6, 82);
            this.updateClients.Name = "updateClients";
            this.updateClients.Size = new System.Drawing.Size(111, 23);
            this.updateClients.TabIndex = 4;
            this.updateClients.Text = "Обновить сервера";
            this.updateClients.UseVisualStyleBackColor = true;
            this.updateClients.Click += new System.EventHandler(this.UpdateClients_Click);
            // 
            // druidIsFound
            // 
            this.druidIsFound.AutoSize = true;
            this.druidIsFound.ForeColor = System.Drawing.SystemColors.ControlText;
            this.druidIsFound.Location = new System.Drawing.Point(47, 50);
            this.druidIsFound.Name = "druidIsFound";
            this.druidIsFound.Size = new System.Drawing.Size(60, 13);
            this.druidIsFound.TabIndex = 3;
            this.druidIsFound.Text = "Не найден";
            // 
            // tankIsFound
            // 
            this.tankIsFound.AutoSize = true;
            this.tankIsFound.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tankIsFound.Location = new System.Drawing.Point(47, 28);
            this.tankIsFound.Name = "tankIsFound";
            this.tankIsFound.Size = new System.Drawing.Size(60, 13);
            this.tankIsFound.TabIndex = 2;
            this.tankIsFound.Text = "Не найден";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Друид:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Танк:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 139);
            this.Controls.Add(this.groupFirst);
            this.Name = "MainWindow";
            this.Text = "constLS";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupFirst.ResumeLayout(false);
            this.groupFirst.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupFirst;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label druidIsFound;
        private System.Windows.Forms.Label tankIsFound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateClients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox serverList;

        protected void setServerList()
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

            if (serverList.Items.Count == 0) {
                serverList.Items.Add("Ни один игровой клиент не запущен");
            }

            serverList.Text = serverList.Items[0].ToString();
        }

        protected void displayMode(string mode)
        {
            if (mode != "") {
                modeName.Text = mode;
                modeName.ForeColor = Color.Green;
            } else {
                modeName.Text = "не установлен";
                modeName.ForeColor = Color.Red;
            }
        }

        protected void displayStatus()
        {
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
        }

        private System.Windows.Forms.Label modeName;
        private System.Windows.Forms.Label modeLabel;
    }
}

