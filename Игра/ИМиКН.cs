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
    public partial class ИМиКН : Form
    {
        private int countBook = 0;
        private int countPage = 0;
        private int printout = 0;
        private int h=0, m=0, s=10;

        public ИМиКН()
        {
            InitializeComponent();
            label1.Text = $"Кол-во книг: 0";
            label2.Text = $"Кол-во листочков: 0";
            label3.Text = $"Кол-во распечатываний: 0";
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 3, 88, 90);
            Region rgn = new Region(path);
            button2.Region = rgn;
            button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.Region = rgn;
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            //Music.pl4.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (countPage < 5)
            {
                countPage++;
                label2.Text = $"Кол-во листочков: {countPage}";
            }
            if (countPage == 5)
                MessageBox.Show("Вы набрали лимит");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Music.pl4.Stop();
            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите выйти?",
                                                  "Выход",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information,
                                                  MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                Hide();
                Map map = new Map();
                map.ShowDialog();
            }
            if (dialogResult == DialogResult.No)
            {
                //Music.pl4.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (countBook < 10)
            {
                countBook++;
                label1.Text = $"Кол-во книг: {countBook}";
            }
            if (countBook == 10)
                MessageBox.Show("Вы набрали лимит");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printout < 1)
            {
                printout++;
                label3.Text = $"Кол-во распечатываний: {printout}";
            }
            if (printout == 1)
                MessageBox.Show("Вы набрали лимит");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s -= 1;
            if(s==-1)
            {
                m -= 1;
                s = 59;
            }
            if(m==-1)
            {
                h -= 1;
                m = 59;
            }
            if ((countBook==10 && countPage==5 && printout ==1) && (s > 0 ||h > 0 || m > 0))
            {
                timer1.Stop();
                DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                  "Уровень пройден",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Information,
                                                  MessageBoxDefaultButton.Button1);
                if (dialog == DialogResult.OK)
                {
                    countBook = 0; countPage = 0; printout = 0;
                    h = 0; m = 0; s = 10;
                    label1.Text = $"Кол-во книг: {countBook}";
                    label2.Text = $"Кол-во листочков: {countPage}";
                    label3.Text = $"Кол-во распечатываний: {printout}";

                }
            }
            else if (h == 0 && m==0 && s==0)
            {
                timer1.Stop();
                DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: книжек {countBook}, листочков {countPage}, распечатываний {printout}.",
                                                  "Время вышло",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Information,
                                                  MessageBoxDefaultButton.Button1) ;
                if (dialog == DialogResult.OK)
                {
                    countBook = 0;countPage = 0;printout = 0;
                    h = 0; m = 0; s = 10;
                    label1.Text = $"Кол-во книг: {countBook}";
                    label2.Text = $"Кол-во листочков: {countPage}";
                    label3.Text = $"Кол-во распечатываний: {printout}";

                }
            }
            label4.Text = Convert.ToString(h);
            label5.Text = Convert.ToString(m);
            label6.Text = Convert.ToString(s);
        }
    }
}
