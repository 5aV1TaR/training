﻿namespace SnakeGame
{
    partial class FrmSnakeGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerGameLoop = new System.Windows.Forms.Timer(this.components);
            this.TimerFoodBlink = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimerGameLoop
            // 
            this.TimerGameLoop.Interval = 300;
            this.TimerGameLoop.Tick += new System.EventHandler(this.TimerGameLoop_Tick);
            // 
            // TimerFoodBlink
            // 
            this.TimerFoodBlink.Tick += new System.EventHandler(this.TimerFoodBlink_Tick);
            // 
            // FrmSnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 482);
            this.Name = "FrmSnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Змейка";
            this.Load += new System.EventHandler(this.FrmSnakeGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmSnakeGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSnakeGame_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerGameLoop;
        private System.Windows.Forms.Timer TimerFoodBlink;
    }
}