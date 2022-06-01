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
        public Timer t = new Timer();

        public Game()
        {
            InitializeComponent();
            label1.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox14.Visible = false;
            panel2.Visible = false;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox7.Visible = true;
            pictureBox2.Visible = false;
            pictureBox8.Visible = true;
            pictureBox3.Visible = false;
            pictureBox9.Visible = true;
            pictureBox4.Visible = false;
            pictureBox10.Visible = true;
            pictureBox5.Visible = false;
            pictureBox11.Visible = true;
            pictureBox6.Visible = false;
            pictureBox12.Visible = true;
            pictureBox15.Visible = false;
            pictureBox14.Visible = true;
            label1.Visible = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                panel2.Visible = true;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Hide();
            Map map = new Map();
            map.ShowDialog();
            Close();
        }

        public void global_FormClosed()
        {
            Application.Exit();
        }

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
