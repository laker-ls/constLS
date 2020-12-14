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
            this.labelHP = new System.Windows.Forms.Label();
            this.labelMP = new System.Windows.Forms.Label();
            this.unitName1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCoords = new System.Windows.Forms.Label();
            this.mobName1 = new System.Windows.Forms.GroupBox();
            this.labelDistance1 = new System.Windows.Forms.Label();
            this.actionBtn = new System.Windows.Forms.Button();
            this.labelTarget = new System.Windows.Forms.Label();
            this.labelWorldId = new System.Windows.Forms.Label();
            this.unitName1.SuspendLayout();
            this.mobName1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(6, 33);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(22, 13);
            this.labelHP.TabIndex = 0;
            this.labelHP.Text = "HP";
            // 
            // labelMP
            // 
            this.labelMP.AutoSize = true;
            this.labelMP.Location = new System.Drawing.Point(6, 63);
            this.labelMP.Name = "labelMP";
            this.labelMP.Size = new System.Drawing.Size(23, 13);
            this.labelMP.TabIndex = 2;
            this.labelMP.Text = "MP";
            this.labelMP.Click += new System.EventHandler(this.LabelMP_Click);
            // 
            // unitName1
            // 
            this.unitName1.Controls.Add(this.labelMP);
            this.unitName1.Controls.Add(this.labelHP);
            this.unitName1.Location = new System.Drawing.Point(12, 12);
            this.unitName1.Name = "unitName1";
            this.unitName1.Size = new System.Drawing.Size(113, 91);
            this.unitName1.TabIndex = 3;
            this.unitName1.TabStop = false;
            this.unitName1.Text = "Имя персонажа 1";
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
            this.mobName1.Location = new System.Drawing.Point(12, 128);
            this.mobName1.Name = "mobName1";
            this.mobName1.Size = new System.Drawing.Size(348, 62);
            this.mobName1.TabIndex = 5;
            this.mobName1.TabStop = false;
            this.mobName1.Text = "Имя моба 1";
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
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(226, 77);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(134, 23);
            this.actionBtn.TabIndex = 6;
            this.actionBtn.Text = "Действие";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(226, 31);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(42, 13);
            this.labelTarget.TabIndex = 7;
            this.labelTarget.Text = "Таргет";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 211);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.mobName1);
            this.Controls.Add(this.unitName1);
            this.Name = "MainWindow";
            this.Text = "constLS";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.unitName1.ResumeLayout(false);
            this.unitName1.PerformLayout();
            this.mobName1.ResumeLayout(false);
            this.mobName1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelMP;
        private System.Windows.Forms.GroupBox unitName1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCoords;
        private System.Windows.Forms.GroupBox mobName1;
        private System.Windows.Forms.Label labelDistance1;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Label labelWorldId;
    }
}

