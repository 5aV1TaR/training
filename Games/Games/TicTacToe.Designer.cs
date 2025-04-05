namespace SnakeGame
{
    partial class frmTicTacToe
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
            this.labelPlayerVsPlayer = new System.Windows.Forms.Label();
            this.labelPlayerVsCpu = new System.Windows.Forms.Label();
            this.panelPlayerVsCpu = new System.Windows.Forms.Panel();
            this.labelNewGame = new System.Windows.Forms.Label();
            this.panelNewGame = new System.Windows.Forms.Panel();
            this.labelReset = new System.Windows.Forms.Label();
            this.panelPlayerVsPlayer = new System.Windows.Forms.Panel();
            this.panelReset = new System.Windows.Forms.Panel();
            this.labelWhooseTurn = new System.Windows.Forms.Label();
            this.labelNowTurnIs = new System.Windows.Forms.Label();
            this.labelPlayer2Score = new System.Windows.Forms.Label();
            this.labelPlayer1Score = new System.Windows.Forms.Label();
            this.labelPlayer2Name = new System.Windows.Forms.Label();
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.labelNewGameTitle = new System.Windows.Forms.Label();
            this.panelCell2_2 = new System.Windows.Forms.Panel();
            this.panelCell1_2 = new System.Windows.Forms.Panel();
            this.panelCell2_1 = new System.Windows.Forms.Panel();
            this.panelCell0_2 = new System.Windows.Forms.Panel();
            this.panelCell2_0 = new System.Windows.Forms.Panel();
            this.panelCell1_1 = new System.Windows.Forms.Panel();
            this.panelCell1_0 = new System.Windows.Forms.Panel();
            this.panelCell0_1 = new System.Windows.Forms.Panel();
            this.panelCell0_0 = new System.Windows.Forms.Panel();
            this.panelPlayerVsCpu.SuspendLayout();
            this.panelNewGame.SuspendLayout();
            this.panelPlayerVsPlayer.SuspendLayout();
            this.panelReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPlayerVsPlayer
            // 
            this.labelPlayerVsPlayer.AutoSize = true;
            this.labelPlayerVsPlayer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelPlayerVsPlayer.ForeColor = System.Drawing.Color.Cyan;
            this.labelPlayerVsPlayer.Location = new System.Drawing.Point(37, 19);
            this.labelPlayerVsPlayer.Name = "labelPlayerVsPlayer";
            this.labelPlayerVsPlayer.Size = new System.Drawing.Size(158, 21);
            this.labelPlayerVsPlayer.TabIndex = 0;
            this.labelPlayerVsPlayer.Text = "Игрок против игрока";
            this.labelPlayerVsPlayer.Click += new System.EventHandler(this.labelPlayerVsPlayer_Click_1);
            this.labelPlayerVsPlayer.MouseEnter += new System.EventHandler(this.panelPlayerVsPlayer_MouseLeave);
            // 
            // labelPlayerVsCpu
            // 
            this.labelPlayerVsCpu.AutoSize = true;
            this.labelPlayerVsCpu.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelPlayerVsCpu.ForeColor = System.Drawing.Color.Cyan;
            this.labelPlayerVsCpu.Location = new System.Drawing.Point(21, 21);
            this.labelPlayerVsCpu.Name = "labelPlayerVsCpu";
            this.labelPlayerVsCpu.Size = new System.Drawing.Size(197, 21);
            this.labelPlayerVsCpu.TabIndex = 0;
            this.labelPlayerVsCpu.Text = "Игрок против компьютера";
            this.labelPlayerVsCpu.Click += new System.EventHandler(this.labelPlayerVsCpu_Click_1);
            this.labelPlayerVsCpu.MouseEnter += new System.EventHandler(this.labelPlayerVsCpu_MouseEnter);
            // 
            // panelPlayerVsCpu
            // 
            this.panelPlayerVsCpu.BackColor = System.Drawing.Color.SlateBlue;
            this.panelPlayerVsCpu.Controls.Add(this.labelPlayerVsCpu);
            this.panelPlayerVsCpu.Location = new System.Drawing.Point(332, 111);
            this.panelPlayerVsCpu.Name = "panelPlayerVsCpu";
            this.panelPlayerVsCpu.Size = new System.Drawing.Size(236, 60);
            this.panelPlayerVsCpu.TabIndex = 33;
            this.panelPlayerVsCpu.Click += new System.EventHandler(this.panelPlayerVsCpu_Click);
            this.panelPlayerVsCpu.MouseEnter += new System.EventHandler(this.panelPlayerVsCpu_MouseEnter);
            this.panelPlayerVsCpu.MouseLeave += new System.EventHandler(this.panelPlayerVsCpu_MouseLeave);
            // 
            // labelNewGame
            // 
            this.labelNewGame.AutoSize = true;
            this.labelNewGame.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelNewGame.ForeColor = System.Drawing.Color.Cyan;
            this.labelNewGame.Location = new System.Drawing.Point(3, 9);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(91, 21);
            this.labelNewGame.TabIndex = 0;
            this.labelNewGame.Text = "Новая игра";
            this.labelNewGame.Click += new System.EventHandler(this.labelNewGame_Click);
            this.labelNewGame.MouseEnter += new System.EventHandler(this.labelNewGame_MouseEnter);
            this.labelNewGame.MouseLeave += new System.EventHandler(this.labelNewGame_MouseLeave);
            // 
            // panelNewGame
            // 
            this.panelNewGame.BackColor = System.Drawing.Color.SlateBlue;
            this.panelNewGame.Controls.Add(this.labelNewGame);
            this.panelNewGame.Location = new System.Drawing.Point(390, 9);
            this.panelNewGame.Name = "panelNewGame";
            this.panelNewGame.Size = new System.Drawing.Size(98, 38);
            this.panelNewGame.TabIndex = 32;
            this.panelNewGame.Click += new System.EventHandler(this.panelNewGame_Click);
            this.panelNewGame.MouseEnter += new System.EventHandler(this.panelNewGame_MouseEnter);
            this.panelNewGame.MouseLeave += new System.EventHandler(this.panelNewGame_MouseLeave);
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelReset.ForeColor = System.Drawing.Color.Cyan;
            this.labelReset.Location = new System.Drawing.Point(4, 9);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(52, 21);
            this.labelReset.TabIndex = 0;
            this.labelReset.Text = "Сброс";
            this.labelReset.Click += new System.EventHandler(this.labelReset_Click);
            this.labelReset.MouseEnter += new System.EventHandler(this.labelReset_MouseEnter);
            this.labelReset.MouseLeave += new System.EventHandler(this.labelReset_MouseLeave);
            // 
            // panelPlayerVsPlayer
            // 
            this.panelPlayerVsPlayer.BackColor = System.Drawing.Color.SlateBlue;
            this.panelPlayerVsPlayer.Controls.Add(this.labelPlayerVsPlayer);
            this.panelPlayerVsPlayer.Location = new System.Drawing.Point(332, 177);
            this.panelPlayerVsPlayer.Name = "panelPlayerVsPlayer";
            this.panelPlayerVsPlayer.Size = new System.Drawing.Size(236, 60);
            this.panelPlayerVsPlayer.TabIndex = 31;
            this.panelPlayerVsPlayer.Click += new System.EventHandler(this.panelPlayerVsPlayer_Click_1);
            this.panelPlayerVsPlayer.MouseEnter += new System.EventHandler(this.panelPlayerVsPlayer_MouseEnter);
            this.panelPlayerVsPlayer.MouseLeave += new System.EventHandler(this.panelPlayerVsPlayer_MouseLeave);
            // 
            // panelReset
            // 
            this.panelReset.BackColor = System.Drawing.Color.SlateBlue;
            this.panelReset.Controls.Add(this.labelReset);
            this.panelReset.Location = new System.Drawing.Point(323, 9);
            this.panelReset.Name = "panelReset";
            this.panelReset.Size = new System.Drawing.Size(61, 38);
            this.panelReset.TabIndex = 30;
            this.panelReset.Click += new System.EventHandler(this.panelReset_Click);
            this.panelReset.MouseEnter += new System.EventHandler(this.panelReset_MouseEnter);
            this.panelReset.MouseLeave += new System.EventHandler(this.panelReset_MouseLeave);
            // 
            // labelWhooseTurn
            // 
            this.labelWhooseTurn.AutoSize = true;
            this.labelWhooseTurn.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F);
            this.labelWhooseTurn.ForeColor = System.Drawing.Color.White;
            this.labelWhooseTurn.Location = new System.Drawing.Point(424, 328);
            this.labelWhooseTurn.Name = "labelWhooseTurn";
            this.labelWhooseTurn.Size = new System.Drawing.Size(33, 37);
            this.labelWhooseTurn.TabIndex = 29;
            this.labelWhooseTurn.Text = "?";
            // 
            // labelNowTurnIs
            // 
            this.labelNowTurnIs.AutoSize = true;
            this.labelNowTurnIs.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F);
            this.labelNowTurnIs.ForeColor = System.Drawing.Color.White;
            this.labelNowTurnIs.Location = new System.Drawing.Point(323, 328);
            this.labelNowTurnIs.Name = "labelNowTurnIs";
            this.labelNowTurnIs.Size = new System.Drawing.Size(105, 37);
            this.labelNowTurnIs.TabIndex = 28;
            this.labelNowTurnIs.Text = "Ходит:";
            // 
            // labelPlayer2Score
            // 
            this.labelPlayer2Score.AutoSize = true;
            this.labelPlayer2Score.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F);
            this.labelPlayer2Score.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelPlayer2Score.Location = new System.Drawing.Point(528, 289);
            this.labelPlayer2Score.Name = "labelPlayer2Score";
            this.labelPlayer2Score.Size = new System.Drawing.Size(36, 37);
            this.labelPlayer2Score.TabIndex = 27;
            this.labelPlayer2Score.Text = "0";
            // 
            // labelPlayer1Score
            // 
            this.labelPlayer1Score.AutoSize = true;
            this.labelPlayer1Score.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F);
            this.labelPlayer1Score.ForeColor = System.Drawing.Color.Gold;
            this.labelPlayer1Score.Location = new System.Drawing.Point(528, 252);
            this.labelPlayer1Score.Name = "labelPlayer1Score";
            this.labelPlayer1Score.Size = new System.Drawing.Size(36, 37);
            this.labelPlayer1Score.TabIndex = 26;
            this.labelPlayer1Score.Text = "0";
            // 
            // labelPlayer2Name
            // 
            this.labelPlayer2Name.AutoSize = true;
            this.labelPlayer2Name.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F);
            this.labelPlayer2Name.ForeColor = System.Drawing.Color.White;
            this.labelPlayer2Name.Location = new System.Drawing.Point(323, 289);
            this.labelPlayer2Name.Name = "labelPlayer2Name";
            this.labelPlayer2Name.Size = new System.Drawing.Size(189, 37);
            this.labelPlayer2Name.TabIndex = 25;
            this.labelPlayer2Name.Text = "Компьютер:";
            // 
            // labelPlayer1Name
            // 
            this.labelPlayer1Name.AutoSize = true;
            this.labelPlayer1Name.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F);
            this.labelPlayer1Name.ForeColor = System.Drawing.Color.White;
            this.labelPlayer1Name.Location = new System.Drawing.Point(323, 252);
            this.labelPlayer1Name.Name = "labelPlayer1Name";
            this.labelPlayer1Name.Size = new System.Drawing.Size(108, 37);
            this.labelPlayer1Name.TabIndex = 24;
            this.labelPlayer1Name.Text = "Игрок:";
            // 
            // labelNewGameTitle
            // 
            this.labelNewGameTitle.AutoSize = true;
            this.labelNewGameTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F);
            this.labelNewGameTitle.ForeColor = System.Drawing.Color.White;
            this.labelNewGameTitle.Location = new System.Drawing.Point(355, 68);
            this.labelNewGameTitle.Name = "labelNewGameTitle";
            this.labelNewGameTitle.Size = new System.Drawing.Size(186, 37);
            this.labelNewGameTitle.TabIndex = 23;
            this.labelNewGameTitle.Text = "Новая игра:";
            // 
            // panelCell2_2
            // 
            this.panelCell2_2.BackColor = System.Drawing.Color.Indigo;
            this.panelCell2_2.Location = new System.Drawing.Point(218, 213);
            this.panelCell2_2.Name = "panelCell2_2";
            this.panelCell2_2.Size = new System.Drawing.Size(99, 96);
            this.panelCell2_2.TabIndex = 22;
            this.panelCell2_2.Click += new System.EventHandler(this.panelCell2_2_Click);
            this.panelCell2_2.MouseEnter += new System.EventHandler(this.panelCell2_2_MouseEnter);
            this.panelCell2_2.MouseLeave += new System.EventHandler(this.panelCell2_2_MouseLeave);
            // 
            // panelCell1_2
            // 
            this.panelCell1_2.BackColor = System.Drawing.Color.Indigo;
            this.panelCell1_2.Location = new System.Drawing.Point(218, 111);
            this.panelCell1_2.Name = "panelCell1_2";
            this.panelCell1_2.Size = new System.Drawing.Size(99, 96);
            this.panelCell1_2.TabIndex = 21;
            this.panelCell1_2.Click += new System.EventHandler(this.panelCell1_2_Click);
            this.panelCell1_2.MouseEnter += new System.EventHandler(this.panelCell1_2_MouseEnter);
            this.panelCell1_2.MouseLeave += new System.EventHandler(this.panelCell1_2_MouseLeave);
            // 
            // panelCell2_1
            // 
            this.panelCell2_1.BackColor = System.Drawing.Color.Indigo;
            this.panelCell2_1.Location = new System.Drawing.Point(113, 213);
            this.panelCell2_1.Name = "panelCell2_1";
            this.panelCell2_1.Size = new System.Drawing.Size(99, 96);
            this.panelCell2_1.TabIndex = 20;
            this.panelCell2_1.Click += new System.EventHandler(this.panelCell2_1_Click);
            this.panelCell2_1.MouseEnter += new System.EventHandler(this.panelCell2_1_MouseEnter);
            this.panelCell2_1.MouseLeave += new System.EventHandler(this.panelCell2_1_MouseLeave);
            // 
            // panelCell0_2
            // 
            this.panelCell0_2.BackColor = System.Drawing.Color.Indigo;
            this.panelCell0_2.Location = new System.Drawing.Point(218, 9);
            this.panelCell0_2.Name = "panelCell0_2";
            this.panelCell0_2.Size = new System.Drawing.Size(99, 96);
            this.panelCell0_2.TabIndex = 15;
            this.panelCell0_2.Click += new System.EventHandler(this.panelCell0_2_Click);
            this.panelCell0_2.MouseEnter += new System.EventHandler(this.panelCell0_2_MouseEnter);
            this.panelCell0_2.MouseLeave += new System.EventHandler(this.panelCell0_2_MouseLeave);
            // 
            // panelCell2_0
            // 
            this.panelCell2_0.BackColor = System.Drawing.Color.Indigo;
            this.panelCell2_0.Location = new System.Drawing.Point(8, 213);
            this.panelCell2_0.Name = "panelCell2_0";
            this.panelCell2_0.Size = new System.Drawing.Size(99, 96);
            this.panelCell2_0.TabIndex = 18;
            this.panelCell2_0.Click += new System.EventHandler(this.panelCell2_0_Click);
            this.panelCell2_0.MouseEnter += new System.EventHandler(this.panelCell2_0_MouseEnter);
            this.panelCell2_0.MouseLeave += new System.EventHandler(this.panelCell2_0_MouseLeave);
            // 
            // panelCell1_1
            // 
            this.panelCell1_1.BackColor = System.Drawing.Color.Indigo;
            this.panelCell1_1.Location = new System.Drawing.Point(113, 111);
            this.panelCell1_1.Name = "panelCell1_1";
            this.panelCell1_1.Size = new System.Drawing.Size(99, 96);
            this.panelCell1_1.TabIndex = 19;
            this.panelCell1_1.Click += new System.EventHandler(this.panelCell1_1_Click);
            this.panelCell1_1.MouseEnter += new System.EventHandler(this.panelCell1_1_MouseEnter);
            this.panelCell1_1.MouseLeave += new System.EventHandler(this.panelCell1_1_MouseLeave);
            // 
            // panelCell1_0
            // 
            this.panelCell1_0.BackColor = System.Drawing.Color.Indigo;
            this.panelCell1_0.Location = new System.Drawing.Point(8, 111);
            this.panelCell1_0.Name = "panelCell1_0";
            this.panelCell1_0.Size = new System.Drawing.Size(99, 96);
            this.panelCell1_0.TabIndex = 17;
            this.panelCell1_0.Click += new System.EventHandler(this.panelCell1_0_Click);
            this.panelCell1_0.MouseEnter += new System.EventHandler(this.panelCell1_0_MouseEnter);
            this.panelCell1_0.MouseLeave += new System.EventHandler(this.panelCell1_0_MouseLeave);
            // 
            // panelCell0_1
            // 
            this.panelCell0_1.BackColor = System.Drawing.Color.Indigo;
            this.panelCell0_1.Location = new System.Drawing.Point(113, 9);
            this.panelCell0_1.Name = "panelCell0_1";
            this.panelCell0_1.Size = new System.Drawing.Size(99, 96);
            this.panelCell0_1.TabIndex = 16;
            this.panelCell0_1.Click += new System.EventHandler(this.panelCell0_1_Click);
            this.panelCell0_1.MouseEnter += new System.EventHandler(this.panelCell0_1_MouseEnter);
            this.panelCell0_1.MouseLeave += new System.EventHandler(this.panelCell0_1_MouseLeave);
            // 
            // panelCell0_0
            // 
            this.panelCell0_0.BackColor = System.Drawing.Color.Indigo;
            this.panelCell0_0.Location = new System.Drawing.Point(8, 9);
            this.panelCell0_0.Name = "panelCell0_0";
            this.panelCell0_0.Size = new System.Drawing.Size(99, 96);
            this.panelCell0_0.TabIndex = 14;
            this.panelCell0_0.Click += new System.EventHandler(this.panelCell0_0_Click);
            this.panelCell0_0.MouseEnter += new System.EventHandler(this.panelCell0_0_MouseEnter);
            this.panelCell0_0.MouseLeave += new System.EventHandler(this.panelCell0_0_MouseLeave);
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(577, 375);
            this.Controls.Add(this.panelPlayerVsCpu);
            this.Controls.Add(this.panelNewGame);
            this.Controls.Add(this.panelPlayerVsPlayer);
            this.Controls.Add(this.panelReset);
            this.Controls.Add(this.labelWhooseTurn);
            this.Controls.Add(this.labelNowTurnIs);
            this.Controls.Add(this.labelPlayer2Score);
            this.Controls.Add(this.labelPlayer1Score);
            this.Controls.Add(this.labelPlayer2Name);
            this.Controls.Add(this.labelPlayer1Name);
            this.Controls.Add(this.labelNewGameTitle);
            this.Controls.Add(this.panelCell2_2);
            this.Controls.Add(this.panelCell1_2);
            this.Controls.Add(this.panelCell2_1);
            this.Controls.Add(this.panelCell0_2);
            this.Controls.Add(this.panelCell2_0);
            this.Controls.Add(this.panelCell1_1);
            this.Controls.Add(this.panelCell1_0);
            this.Controls.Add(this.panelCell0_1);
            this.Controls.Add(this.panelCell0_0);
            this.Name = "frmTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Крестики Нолики";
            this.panelPlayerVsCpu.ResumeLayout(false);
            this.panelPlayerVsCpu.PerformLayout();
            this.panelNewGame.ResumeLayout(false);
            this.panelNewGame.PerformLayout();
            this.panelPlayerVsPlayer.ResumeLayout(false);
            this.panelPlayerVsPlayer.PerformLayout();
            this.panelReset.ResumeLayout(false);
            this.panelReset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerVsPlayer;
        private System.Windows.Forms.Label labelPlayerVsCpu;
        private System.Windows.Forms.Panel panelPlayerVsCpu;
        private System.Windows.Forms.Label labelNewGame;
        private System.Windows.Forms.Panel panelNewGame;
        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.Panel panelPlayerVsPlayer;
        private System.Windows.Forms.Panel panelReset;
        private System.Windows.Forms.Label labelWhooseTurn;
        private System.Windows.Forms.Label labelNowTurnIs;
        private System.Windows.Forms.Label labelPlayer2Score;
        private System.Windows.Forms.Label labelPlayer1Score;
        private System.Windows.Forms.Label labelPlayer2Name;
        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Label labelNewGameTitle;
        private System.Windows.Forms.Panel panelCell2_2;
        private System.Windows.Forms.Panel panelCell1_2;
        private System.Windows.Forms.Panel panelCell2_1;
        private System.Windows.Forms.Panel panelCell0_2;
        private System.Windows.Forms.Panel panelCell2_0;
        private System.Windows.Forms.Panel panelCell1_1;
        private System.Windows.Forms.Panel panelCell1_0;
        private System.Windows.Forms.Panel panelCell0_1;
        private System.Windows.Forms.Panel panelCell0_0;
    }
}