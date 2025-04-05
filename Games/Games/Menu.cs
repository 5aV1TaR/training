using SnakeGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class Menu: Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void SnakeGame(object sender, EventArgs e)
        {
            FrmSnakeGame frm1 = new FrmSnakeGame();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void panelSnake_Click(object sender, EventArgs e)
        {
            SnakeGame(sender, e);
        }

        private void TicTacToe(object sender, EventArgs e)
        {
            frmTicTacToe frm2 = new frmTicTacToe();
            this.Hide();
            frm2.ShowDialog();
            this.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            TicTacToe(sender, e);
        }

        private void RegularButtonMouseOver(Panel panelButton, Label labelButtonText)
        {
            panelButton.BackColor = Color.Purple; //Задаем цвет при наведении на панель
            labelButtonText.ForeColor = Color.Yellow; //Задаем цвет при наведении на текст
            Cursor = Cursors.Hand;
        }

        private void RegularButtonMouseOut(Panel panelButton, Label labelButtonText)
        {
            panelButton.BackColor = Color.SlateBlue; //Возвращаем цвет при наведении на панель
            labelButtonText.ForeColor = Color.Cyan; //Возвращаем цвет при наведении на текст
            Cursor = Cursors.Default;
        }

        private void panelSnake_MouseEnter(object sender, EventArgs e)
        {
            RegularButtonMouseOver(panelSnake, labelSnake);
        }

        private void panelSnake_MouseLeave(object sender, EventArgs e)
        {
            RegularButtonMouseOut(panelSnake, labelSnake);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            RegularButtonMouseOver(panel1, label1);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            RegularButtonMouseOut(panel1, label1);
        }

        private void labelSnake_MouseEnter(object sender, EventArgs e)
        {
            RegularButtonMouseOver(panelSnake, labelSnake);
        }

        private void labelSnake_MouseLeave(object sender, EventArgs e)
        {
            RegularButtonMouseOut(panelSnake, labelSnake);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            RegularButtonMouseOver(panel1, label1);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            RegularButtonMouseOut(panel1, label1);
        }
    }
}
