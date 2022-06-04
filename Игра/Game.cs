using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            View.InitializeGame(label1, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox14, panel2);
        }

        private void timer1_Tick(object sender, EventArgs e) => View.TimerGame(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, 
            pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox14, pictureBox15, label1);

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e) => panel2.Visible = e.KeyCode == Keys.Enter;

        private void Play_Click(object sender, EventArgs e)
        {
            Hide();
            Map map = new Map();
            map.ShowDialog();
            Close();
        }

        public void global_FormClosed() => Application.Exit();


        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти?",
                                                  "Выход",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information,
                                                  MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                Music.pl1.Stop();
                global_FormClosed();
            }
        }
    }
}
