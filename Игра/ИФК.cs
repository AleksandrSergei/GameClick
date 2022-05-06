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
    public partial class ИФК : Form
    {
        private int book = 0;
        private int sheet = 0;
        private int pencil = 0;
        private int brain = 0;
        private int ball = 0;
        private int shoes = 0;
        private int cup = 0;
        private int gymnastics = 0;
        private int weight = 0;
        private int breakfast = 0;
        private int fruits = 0;
        private int soda = 0;
        private int h = 0, m = 0, s = 0;

        private int level = 1;

        public ИФК()
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
                if (ball< 100)
                {
                    ball++;
                    label1.Text = $"Кол-во мячей: {ball}";
                }
                else if (ball == 100) MessageBox.Show("Вы набрали нужное количество мячей!");
            }

            else if (level == 2)
            {
                if (cup < 150)
                {
                    cup++;
                    label1.Text = $"Кол-во кубков: {cup}";
                }
                else if (cup == 150) MessageBox.Show("Вы набрали нужное количество кубков!");
            }

            else if (level == 3)
            {
                if (sheet < 200)
                {
                    sheet++;
                    label1.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 200) MessageBox.Show("Вы набрали нужное количество листов!");
            }

            else if (level == 4)
            {
                if (breakfast < 300)
                {
                    breakfast++;
                    label1.Text = $"Кол-во завтраков: {breakfast}";
                }
                else if (breakfast == 300) MessageBox.Show("Вы набрали нужное количество завтраков!");
            }

            else if (level == 5)
            {
                if (gymnastics < 500)
                {
                    gymnastics++;
                    label1.Text = $"Кол-во зарядок: {gymnastics}";
                }
                else if (gymnastics == 500) MessageBox.Show("Вы набрали нужное количество зарядок!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (shoes < 70)
                {
                    shoes++;
                    label2.Text = $"Кол-во кроссовок: {shoes}";
                }
                else if (shoes == 70) MessageBox.Show("Вы набрали нужное количество кроссовок!");
            }

            else if (level == 2)
            {
                if (book < 100)
                {
                    book++;
                    label2.Text = $"Кол-во книг: {book}";
                }
                else if (book == 100) MessageBox.Show("Вы набрали нужное количество книг!");
            }

            else if (level == 3)
            {
                if (shoes < 210)
                {
                    shoes++;
                    label2.Text = $"Кол-во кроссовок: {shoes}";
                }
                else if (shoes == 210) MessageBox.Show("Вы набрали нужное количество кроссовок!");
            }

            else if (level == 4)
            {
                if (fruits < 300)
                {
                    fruits++;
                    label2.Text = $"Кол-во фруктов: {fruits}";
                }
                else if (fruits == 300) MessageBox.Show("Вы набрали нужное количество фруктов!");
            }

            else if (level == 5)
            {
                if (weight < 300)
                {
                    weight++;
                    label2.Text = $"Кол-во гирь: {weight}";
                }
                else if (weight == 300) MessageBox.Show("Вы набрали нужное количество гирь!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (brain < 30)
                {
                    brain++;
                    label3.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 30) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }

            else if (level == 2)
            {
                if (pencil < 150)
                {
                    pencil++;
                    label3.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 150) MessageBox.Show("Вы набрали нужное количество карандашей!");
            }

            else if (level == 3)
            {
                if (pencil < 100)
                {
                    pencil++;
                    label3.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 100) MessageBox.Show("Вы набрали нужное количество карандашей!");
            }

            else if (level == 4)
            {
                if (soda < 200)
                {
                    soda++;
                    label3.Text = $"Кол-во газировок: {soda}";
                }
                else if (soda == 200) MessageBox.Show("Вы набрали нужное количество газировок!");
            }

            else if (level == 5)
            {
                if (brain < 200)
                {
                    brain++;
                    label3.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 200) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                h = 0; m = 0; s = 40;
                ball = 0; shoes = 0; brain = 0;
                label1.Text = $"Кол-во мячей: {ball}";
                label2.Text = $"Кол-во кроссовок: {shoes}";
                label3.Text = $"Кол-во мозгов: {brain}";
            }

            else if (level == 2)
            {
                h = 0; m = 1; s = 20;
                cup = 0; book = 0; pencil = 0;
                label1.Text = $"Кол-во кубков: {cup}";
                label2.Text = $"Кол-во книг: {book}";
                label3.Text = $"Кол-во карандашей: {pencil}";
            }

            else if (level == 3)
            {
                h = 0; m = 2; s = 0;
                sheet = 0; shoes = 0; pencil = 0;
                label1.Text = $"Кол-во листов: {sheet}";
                label2.Text = $"Кол-во кроссовок: {shoes}";
                label3.Text = $"Кол-во карандашей: {pencil}";
            }

            else if (level == 4)
            {
                h = 0; m = 2; s = 40;
                breakfast = 0; fruits = 0; soda = 0;
                label1.Text = $"Кол-во завтраков: {breakfast}";
                label2.Text = $"Кол-во фруктов: {fruits}";
                label3.Text = $"Кол-во газировок: {soda}";
            }

            else if (level == 5)
            {
                h = 0; m = 3; s = 20;
                gymnastics = 0; weight = 0; brain = 0;
                label1.Text = $"Кол-во зарядок: {gymnastics}";
                label2.Text = $"Кол-во гирь: {weight}";
                label3.Text = $"Кол-во мозгов: {brain}";
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
                if ((ball == 100 && shoes == 70 && brain == 30) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        ball = 0; shoes = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        level = 2;
                        label1.Text = $"Кол-во кубков: {cup}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                        richTextBox1.Text = "Лекция по теме 'Педагоги физической культуры':\n150 кубков\n100 книг\n150 карандашей\nУ вас есть 1 минута 20 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка кубок.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка книги2.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка карандаш.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: мячей {ball}, кроссовок {shoes}, мозгов {brain}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        ball = 0; shoes = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во мячей: {ball}";
                        label2.Text = $"Кол-во кроссовок: {shoes}";
                        label3.Text = $"Кол-во мозгов: {brain}";
                    }
                }
            }

            else if (level == 2)
            {
                if ((cup == 150 && book == 100 && pencil == 150) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        cup = 0; book = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        level = 3;
                        label1.Text = $"Кол-во листов: {sheet}";
                        label2.Text = $"Кол-во кроссовок: {shoes}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                        richTextBox1.Text = "Презентация на тему 'Физическая культура в России':\n200 листов\n210 кроссовок\n100 карандашей\nУ вас есть 2 минуты!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка кроссовок.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка карандаш.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: кубков {cup}, книг {book}, карандашей {pencil}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        cup = 0; book = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во кубков: {cup}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                    }
                }
            }

            else if (level == 3)
            {
                if ((sheet == 200 && shoes == 210 && pencil == 100) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        sheet = 0; shoes = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        level = 4;
                        label1.Text = $"Кол-во завтраков: {breakfast}";
                        label2.Text = $"Кол-во фруктов: {fruits}";
                        label3.Text = $"Кол-во газировок: {soda}";
                        richTextBox1.Text = "Нужно сходить покушать:\n300 завтраков\n300 фруктов\n200 газировки\nУ вас есть 2 минуты 40 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка завтрак.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка фрукты.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка газировка.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: листов {sheet}, кроссовок {shoes}, карандашей {pencil}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        sheet = 0; shoes = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во листов: {sheet}";
                        label2.Text = $"Кол-во кроссовок: {shoes}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                    }
                }
            }

            else if (level == 4)
            {
                if ((breakfast == 300 && fruits == 300 && soda == 200) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        breakfast = 0; fruits = 0; soda = 0;
                        h = 0; m = 0; s = 0;
                        level = 2;
                        label1.Text = $"Кол-во зарядок: {gymnastics}";
                        label2.Text = $"Кол-во гирь: {weight}";
                        label3.Text = $"Кол-во мозгов: {brain}";
                        richTextBox1.Text = "Зачет по тренерству:\n500 зарядок\n300 гирь\n200 мозгов\nУ вас есть 3 минуты 20 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка зарядка.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка гиря.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: завтраков {breakfast}, фруктоа {fruits}, газировок {soda}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        breakfast = 0; fruits = 0; soda = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во завтраков: {breakfast}";
                        label2.Text = $"Кол-во фруктов: {fruits}";
                        label3.Text = $"Кол-во газировок: {soda}";
                    }
                }
            }

            else if (level == 5)
            {
                if ((gymnastics == 500 && weight == 300 && brain == 200) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Институт пройден!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        gymnastics = 0; weight = 0; brain = 0;
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
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: зарядок {gymnastics}, гирь {weight}, мозгов {brain}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        gymnastics = 0; weight = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во зарядок: {gymnastics}";
                        label2.Text = $"Кол-во гирь: {weight}";
                        label3.Text = $"Кол-во мозгов: {brain}";
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
