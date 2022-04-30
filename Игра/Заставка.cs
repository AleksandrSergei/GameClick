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
    public partial class Заставка : Form
    {
        public Timer t = new Timer();
        

        public Заставка()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void Заставка_Load(object sender, EventArgs e)
        {
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
                //t.Interval = 400;
                //t.Tick += new EventHandler(t_Tick);
                //t.Start();
        }

        //void t_Tick(object sender, EventArgs e)
        //{
        //    label1.Visible = !label1.Visible;
        //}

        private void Заставка_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Hide();
                Menu f1 = new Menu();
                f1.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Visible = true;

        }
    }
}
