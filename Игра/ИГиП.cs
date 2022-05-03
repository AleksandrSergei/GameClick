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
    public partial class ИГиП : Form
    {
        private int book = 0;
        private int sheet = 0;
        private int pencil = 0;
        private int brain = 0;
        private int ball = 0;
        private int athlete = 0;
        private int dumbbells = 0;
        private int scales = 0;
        private int hammer = 0;
        private int clip = 0;
        private int scroll = 0;
        private int folder = 0;
        private int h = 0, m = 0, s = 0;

        private int level = 1;

        public ИГиП()
        {
            InitializeComponent();

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (hammer < 30)
                {
                    hammer++;
                    label1.Text = $"Кол-во судейских молотов: {hammer}";
                }
                else if (hammer == 30) MessageBox.Show("Вы набрали нужное количесвто судейских молотов!");
            }

            else if (level == 2)
            {
                if (ball < 70)
                {
                    ball++;
                    label1.Text = $"Кол-во мячей: {ball}";
                }
                else if (ball == 70) MessageBox.Show("Вы набрали нужное количество мячей!");
            }

            else if (level == 3)
            {
                if (folder < 80)
                {
                    folder++;
                    label1.Text = $"Кол-во папок: {folder}";
                }
                else if (folder == 80) MessageBox.Show("Вы набрали нужное количество папок!");
            }

            else if (level == 4)
            {
                if (scales < 120)
                {
                    scales++;
                    label1.Text = $"Кол-во весов: {scales}";
                }
                else if (scales == 120) MessageBox.Show("Вы набрали нужное количество весов!");
            }

            else if (level == 5)
            {
                if (scroll < 300)
                {
                    scroll++;
                    label1.Text = $"Кол-во свитков: {scroll}";
                }
                else if (scroll == 300) MessageBox.Show("Вы набрали нужное количество свитков!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (brain < 25)
                {
                    brain++;
                    label2.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 25) MessageBox.Show("Вы набрали нужное количесвто мозгов!");
            }

            else if (level == 2)
            {
                if (athlete < 40)
                {
                    athlete++;
                    label2.Text = $"Кол-во спортсменов: {athlete}";
                }
                else if (athlete == 40) MessageBox.Show("Вы набрали нужное количество спортсменов!");
            }

            else if (level == 3)
            {
                if (clip < 50)
                {
                    clip++;
                    label2.Text = $"Кол-во скрепок: {clip}";
                }
                else if (clip == 50) MessageBox.Show("Вы набрали нужное количество скрепок!");
            }

            else if (level == 4)
            {
                if (hammer < 150)
                {
                    hammer++;
                    label2.Text = $"Кол-во судейских молотов: {hammer}";
                }
                else if (hammer == 150) MessageBox.Show("Вы набрали нужное количество судейских молотов!");
            }

            else if (level == 5)
            {
                if (book < 280)
                {
                    book++;
                    label2.Text = $"Кол-во книг: {book}";
                }
                else if (book == 280) MessageBox.Show("Вы набрали нужное количество книг!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (pencil < 15)
                {
                    pencil++;
                    label3.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 15) MessageBox.Show("Вы набрали нужное количесвто карандашей!");
            }

            else if (level == 2)
            {
                if (dumbbells < 30)
                {
                    dumbbells++;
                    label3.Text = $"Кол-во гантелей: {dumbbells}";
                }
                else if (dumbbells == 30) MessageBox.Show("Вы набрали нужное количество гантелей!");
            }

            else if (level == 3)
            {
                if (sheet < 60)
                {
                    sheet++;
                    label3.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 60) MessageBox.Show("Вы набрали нужное количество листов!");
            }

            else if (level == 4)
            {
                if (pencil < 90)
                {
                    pencil++;
                    label3.Text = $"Кол-во карандаш: {pencil}";
                }
                else if (pencil == 90) MessageBox.Show("Вы набрали нужное количество карандаш!");
            }

            else if (level == 5)
            {
                if (sheet < 140)
                {
                    sheet++;
                    label3.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 140) MessageBox.Show("Вы набрали нужное количество листов!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                h = 0; m = 0; s = 30;
                hammer = 0; brain = 0; pencil = 0;
                label1.Text = $"Кол-во судейских молотов: {hammer}";
                label2.Text = $"Кол-во мозгов: {brain}";
                label3.Text = $"Кол-во карандашей: {pencil}";
            }

            else if (level == 2)
            {
                h = 0; m = 1; s = 0;
                ball = 0; athlete = 0; dumbbells = 0;
                label1.Text = $"Кол-во мячей: {ball}";
                label2.Text = $"Кол-во спортсменов: {athlete}";
                label3.Text = $"Кол-во гантель: {dumbbells}";
            }

            else if (level == 3)
            {
                h = 0; m = 1; s = 20;
                folder = 0; clip = 0; sheet = 0;
                label1.Text = $"Кол-во папок: {folder}";
                label2.Text = $"Кол-во скрепок: {clip}";
                label3.Text = $"Кол-во листов: {sheet}";
            }

            else if (level == 4)
            {
                h = 0; m = 2; s = 30;
                scales = 0; hammer = 0; pencil = 0;
                label1.Text = $"Кол-во весов: {scales}";
                label2.Text = $"Кол-во судейских молотов: {hammer}";
                label3.Text = $"Кол-во карандашей: {pencil}";
            }

            else if (level == 5)
            {
                h = 0; m = 6; s = 0;
                scroll = 0; book = 0; sheet = 0;
                label1.Text = $"Кол-во свитков: {scroll}";
                label2.Text = $"Кол-во книг: {book}";
                label3.Text = $"Кол-во листов: {sheet}";
            }

            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            s -= 1;
            if (s == -1)
            {
                m -= 1;
                s = 59;
            }
            if (m == -1)
            {
                h -= 1;
                m = 59;
            }

            if (level == 1)
            {
                if ((hammer == 30 && brain == 25 && pencil == 15) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        hammer = 0; brain = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        level = 2;
                        label1.Text = $"Кол-во мячей: {ball}";
                        label2.Text = $"Кол-во спортсменов: {athlete}";
                        label3.Text = $"Кол-во гантель: {dumbbells}";
                        richTextBox1.Text = "Пора размяться, пара физкультуры:\n70 мячей\n40 спортсменов\n30 гантелей\nУ вас есть 60 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мяч.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка спортсмен.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка гантели.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: судейских молотов {hammer}, мозгов {brain}, карандашей {pencil}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        hammer = 0; brain = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во судейских молотов: {hammer}";
                        label2.Text = $"Кол-во мозгов: {brain}";
                        label3.Text = $"Кол-во карандаш: {pencil}";
                    }
                }
            }

            else if (level == 2)
            {
                if ((ball == 70 && athlete == 40 && dumbbells ==30) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        ball = 0; athlete = 0; dumbbells = 0;
                        h = 0; m = 0; s = 0;
                        level = 3;
                        label1.Text = $"Кол-во папок: {folder}";
                        label2.Text = $"Кол-во скрепок: {clip}";
                        label3.Text = $"Кол-во листов: {sheet}";
                        richTextBox1.Text = "Сделать презентацию на тему 'Бухгалтерский учет':\n80 папок\n50 скрепок\n60 листов\nУ вас есть 1 минута 20 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка папки.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка скрепка.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: мячей {ball}, спортсменов {athlete},гантелей {dumbbells}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        ball = 0; athlete = 0; dumbbells = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во мячей: {ball}";
                        label2.Text = $"Кол-во спортсменов: {athlete}";
                        label3.Text = $"Кол-во гантель: {dumbbells}";
                    }
                }
            }

            else if (level == 3)
            {
                if ((folder == 80 && clip == 50 && sheet == 60) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        folder = 0; clip = 0; sheet = 0;
                        h = 0; m = 0; s = 0;
                        level = 4;
                        label1.Text = $"Кол-во весов: {scales}";
                        label2.Text = $"Кол-во судейских молотов: {hammer}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                        richTextBox1.Text = "Посетить лекцию по уголовному праву:\n120 весов\n150 судейских молотов\n90 карандашей\nУ вас есть 2 минуты 30 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка веса.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка судейский молот.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка карандаш.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: папок {folder}, скрепок {clip}, листов {sheet}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        folder = 0; clip = 0; sheet = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во папок: {folder}";
                        label2.Text = $"Кол-во скрепок: {clip}";
                        label3.Text = $"Кол-во листов: {sheet}";
                    }
                }
            }

            else if (level == 4)
            {
                if ((scales == 120 && hammer == 150 && pencil == 90) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        scales = 0; hammer = 0;  pencil = 0;
                        h = 0; m = 0; s = 0;
                        level = 5;
                        label1.Text = $"Кол-во свитков: {scroll}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во листов: {sheet}";
                        richTextBox1.Text = "Сдать экзамен по 'Истории государсвеного управления':\n300 свитков\n280 книг\n140 листов\nУ вас есть 6 минут!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка свиток.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка книги2.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: весов {scales}, судейских молотов {hammer}, карандашей {pencil}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        scales = 0; hammer = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во весов: {scales}";
                        label2.Text = $"Кол-во судейских молотов: {hammer}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                    }
                }
            }

            else if (level == 5)
            {
                if ((scales == 300 && book == 280 && sheet == 140) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Институт пройден!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        scales = 0; book = 0; sheet = 0;
                        h = 0; m = 0; s = 0;
                        level = 1;
                        label1.Text = $"";
                        label2.Text = $"";
                        label3.Text = $"";
                        richTextBox1.Text = "Институт пройден !!!";
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: свитков {scales}, книг {book}, листов {sheet}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        scales = 0; book = 0; sheet = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во свитков: {scroll}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во листов: {sheet}";
                    }
                }
            }

            label4.Text = Convert.ToString(h);
            label5.Text = Convert.ToString(m);
            label6.Text = Convert.ToString(s);
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
    }
}
