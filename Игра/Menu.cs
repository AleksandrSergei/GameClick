using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Игра
{
    public partial class Menu : Form
    {
       
        public Menu()
        {
            InitializeComponent();
            //Music.pl1.Play();

        }

        private void Play_Click(object sender, EventArgs e)
        {
            //Music.pl1.Stop();
            Hide();
            Map map = new Map();
            map.ShowDialog();
            //Game game = new Game();
            //game.ShowDialog();
        }

        private void Map_Click(object sender, EventArgs e)
        {
            //Music.pl1.Stop();
            Hide();
            Map map = new Map();
            map.ShowDialog();
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
                //Music.pl1.Stop();
                global_FormClosed();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Music.pl3.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
