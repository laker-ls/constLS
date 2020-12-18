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
            this.listOfClients = new System.Windows.Forms.GroupBox();
            this.druidIsFound = new System.Windows.Forms.Label();
            this.tankIsFound = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listOfClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfClients
            // 
            this.listOfClients.Controls.Add(this.druidIsFound);
            this.listOfClients.Controls.Add(this.tankIsFound);
            this.listOfClients.Controls.Add(this.label2);
            this.listOfClients.Controls.Add(this.label1);
            this.listOfClients.Location = new System.Drawing.Point(12, 12);
            this.listOfClients.Name = "listOfClients";
            this.listOfClients.Size = new System.Drawing.Size(118, 176);
            this.listOfClients.TabIndex = 3;
            this.listOfClients.TabStop = false;
            this.listOfClients.Text = "Персонажи";
            this.listOfClients.Enter += new System.EventHandler(this.ListOfClients_Enter);
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
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(141, 193);
            this.Controls.Add(this.listOfClients);
            this.Name = "MainWindow";
            this.Text = "constLS";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.listOfClients.ResumeLayout(false);
            this.listOfClients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox listOfClients;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label druidIsFound;
        private System.Windows.Forms.Label tankIsFound;
        private System.Windows.Forms.Label label2;
    }
}

