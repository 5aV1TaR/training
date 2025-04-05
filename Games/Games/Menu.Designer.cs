namespace Games
{
    partial class Menu
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
            this.panelSnake = new System.Windows.Forms.Panel();
            this.labelSnake = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSnake.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSnake
            // 
            this.panelSnake.BackColor = System.Drawing.Color.SlateBlue;
            this.panelSnake.Controls.Add(this.labelSnake);
            this.panelSnake.Location = new System.Drawing.Point(12, 12);
            this.panelSnake.Name = "panelSnake";
            this.panelSnake.Size = new System.Drawing.Size(236, 60);
            this.panelSnake.TabIndex = 34;
            this.panelSnake.Click += new System.EventHandler(this.panelSnake_Click);
            this.panelSnake.MouseEnter += new System.EventHandler(this.panelSnake_MouseEnter);
            this.panelSnake.MouseLeave += new System.EventHandler(this.panelSnake_MouseLeave);
            // 
            // labelSnake
            // 
            this.labelSnake.AutoSize = true;
            this.labelSnake.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelSnake.ForeColor = System.Drawing.Color.Cyan;
            this.labelSnake.Location = new System.Drawing.Point(83, 22);
            this.labelSnake.Name = "labelSnake";
            this.labelSnake.Size = new System.Drawing.Size(65, 21);
            this.labelSnake.TabIndex = 0;
            this.labelSnake.Text = "Змейка";
            this.labelSnake.MouseEnter += new System.EventHandler(this.labelSnake_MouseEnter);
            this.labelSnake.MouseLeave += new System.EventHandler(this.labelSnake_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 60);
            this.panel1.TabIndex = 35;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Крестики-нолики";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(264, 153);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSnake);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelSnake.ResumeLayout(false);
            this.panelSnake.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSnake;
        private System.Windows.Forms.Label labelSnake;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

