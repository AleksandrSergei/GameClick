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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            //Music.pl2.Play();
            this.Load += new EventHandler(Form1_Load);
        }
        void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 3, 88, 90);
            Region rgn = new Region(path);
            pictureBox2.Region = rgn;
            pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pictureBox3.Region = rgn;
            pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pictureBox4.Region = rgn;
            pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pictureBox5.Region = rgn;
            pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pictureBox6.Region = rgn;
            pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pictureBox7.Region = rgn;
            pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Music.pl2.Stop();
            Hide();
            Menu f = new Menu();
            f.ShowDialog();
        }

        private void Map_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dialog = MessageBox.Show("Хотите выйти, сохранившись?",
                                                                  "Выход",
                                                                  MessageBoxButtons.YesNo,
                                                                  MessageBoxIcon.Information,
                                                                  MessageBoxDefaultButton.Button2);

                if (dialog == DialogResult.Yes)
                {
                    ///сохранение
                    Hide();
                    Menu f1 = new Menu();
                    f1.ShowDialog();
                }

                if (dialog==DialogResult.No)
                {
                    ///без сохранения
                    Hide();
                    Menu f1 = new Menu();
                    f1.ShowDialog();
                }
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
                Hide();
                //Music.pl2.Stop();
                ИМиКН иМиКН = new ИМиКН();
                иМиКН.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            //Music.pl2.Stop();
            ИГиП иГиП = new ИГиП();
            иГиП.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hide();
            //Music.pl2.Stop();
            ИИиПН иИиПН = new ИИиПН();
            иИиПН.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hide();
            //Music.pl2.Stop();
            ФЭИ фэи = new ФЭИ();
            фэи.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            //Music.pl2.Stop();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
