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
            this.labelHP = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.labelMP = new System.Windows.Forms.Label();
            this.attack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(22, 25);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(22, 13);
            this.labelHP.TabIndex = 0;
            this.labelHP.Text = "HP";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(25, 160);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 1;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // labelMP
            // 
            this.labelMP.AutoSize = true;
            this.labelMP.Location = new System.Drawing.Point(22, 63);
            this.labelMP.Name = "labelMP";
            this.labelMP.Size = new System.Drawing.Size(23, 13);
            this.labelMP.TabIndex = 2;
            this.labelMP.Text = "MP";
            // 
            // attack
            // 
            this.attack.Location = new System.Drawing.Point(118, 160);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(75, 23);
            this.attack.TabIndex = 3;
            this.attack.Text = "Атаковать";
            this.attack.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(26, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Запустить клиент";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.labelMP);
            this.Controls.Add(this.update);
            this.Controls.Add(this.labelHP);
            this.Name = "MainWindow";
            this.Text = "constLS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label labelMP;
        private System.Windows.Forms.Button attack;
        private System.Windows.Forms.Button button1;
    }
}

