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
    public partial class ФизТех : Form
    {
        private int book = 0;
        private int sheet = 0;
        private int pencil = 0;
        private int brain = 0;
        private int rover = 0;
        private int apple = 0;
        private int laptop = 0;
        private int atom = 0;
        private int breakfast = 0;
        private int fruits = 0;
        private int soda = 0;
        private int bulb = 0;
        private int h = 0, m = 0, s = 0;

        private int level = 1;

        public ФизТех()
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
                if (rover < 300)
                {
                    rover++;
                    label1.Text = $"Кол-во марсоходов: {rover}";
                }
                else if (rover == 300) MessageBox.Show("Вы набрали нужное количесвто марсоходов!");
            }

            else if (level == 2)
            {
                if (laptop < 700)
                {
                    laptop++;
                    label1.Text = $"Кол-во ноутбуков: {laptop}";
                }
                else if (laptop == 700) MessageBox.Show("Вы набрали нужное количество ноутбуков!");
            }

            else if (level == 3)
            {
                if (breakfast < 800)
                {
                    breakfast++;
                    label1.Text = $"Кол-во завтраков: {breakfast}";
                }
                else if (breakfast == 800) MessageBox.Show("Вы набрали нужное количество завтраков!");
            }

            else if (level == 4)
            {
                if (bulb < 1000)
                {
                    bulb++;
                    label1.Text = $"Кол-во лампочек: {bulb}";
                }
                else if (bulb == 1000) MessageBox.Show("Вы набрали нужное количество лампочек!");
            }

            else if (level == 5)
            {
                if (rover < 1000)
                {
                    rover++;
                    label1.Text = $"Кол-во марсоходов: {rover}";
                }
                else if (rover == 1000) MessageBox.Show("Вы набрали нужное количество марсоходов!");
            }
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
                if ((rover == 300 && sheet == 200 && apple == 100) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        rover = 0; sheet = 0; apple = 0;
                        h = 0; m = 0; s = 0;
                        level = 2;
                        label1.Text = $"Кол-во ноутбуков: {laptop}";
                        label2.Text = $"Кол-во мозгов: {brain}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                        richTextBox1.Text = "Сдать лабораторную работу по информатике:\n700 ноутбуков\n300 мозгов\n200 карандашей\nУ вас есть 3 минута 20 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка ноутбук.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка карандаш.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: марсоходов {rover}, листов {sheet}, яблок {apple}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        rover = 0; sheet = 0; apple = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во марсоходов: {rover}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во яблок: {apple}";
                    }
                }
            }

            else if (level == 2)
            {
                if ((laptop == 700 && brain == 300 && pencil == 200) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        laptop = 0; brain = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        level = 3;
                        label1.Text = $"Кол-во завтраков: {breakfast}";
                        label2.Text = $"Кол-во фруктов: {fruits}";
                        label3.Text = $"Кол-во газировок: {soda}";
                        richTextBox1.Text = "Время покушать, столовая:\n800 завтраков\n700 фруктов\n300 газировок\nУ вас есть 5 минут!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка завтрак.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка фрукты.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка газировка.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: ноутбуков {laptop}, мозгов {brain}, карандашей {pencil}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        laptop = 0; brain = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во ноутбуков: {laptop}";
                        label2.Text = $"Кол-во мозгов: {brain}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                    }
                }
            }

            else if (level == 3)
            {
                if ((breakfast == 800 && fruits == 700 && soda == 300) && (s > 0 || h > 0 || m > 0))
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
                        level = 4;
                        label1.Text = $"Кол-во лампочек: {bulb}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во атомов: {atom}";
                        richTextBox1.Text = "Лекция по технической физике:\n100 лампочек\n700 книг\n700 атомов\nУ вас есть 6 минут 40 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лампочка.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка книги2.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка атом.png");
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

            else if (level == 4)
            {
                if ((bulb == 1000 && book == 700 && atom == 700) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        bulb = 0; book = 0; atom = 0;
                        h = 0; m = 0; s = 0;
                        level = 5;
                        label1.Text = $"Кол-во марсоходов: {rover}";
                        label2.Text = $"Кол-во мозгов: {brain}";
                        label3.Text = $"Кол-во атомов: {atom}";
                        richTextBox1.Text = "Экзамен по физике:\n1000 марсоходов\n1500 мозгов\n500 атомов\nУ вас есть 8 минут 20 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка марсоход.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка атом.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: лампочек {rover}, книг {brain}, атом {atom}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        bulb = 0; book = 0; atom = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во лампочек: {bulb}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во атомов: {atom}";
                    }
                }
            }

            else if (level == 5)
            {
                if ((rover == 1000 && brain == 1500 && atom == 500) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Институт пройден!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        rover = 0; brain = 0; atom = 0;
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
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: марсоходов {rover}, мозгов {brain}, атомов {atom}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        rover = 0; brain = 0; atom = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во марсоходов: {rover}";
                        label2.Text = $"Кол-во мозгов: {brain}";
                        label3.Text = $"Кол-во атомов: {atom}";
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                h = 0; m = 1; s = 40;
                rover = 0; sheet = 0; apple = 0;
                label1.Text = $"Кол-во марсоходов: {rover}";
                label2.Text = $"Кол-во листов: {sheet}";
                label3.Text = $"Кол-во яблок: {apple}";
            }

            else if (level == 2)
            {
                h = 0; m = 3; s = 20;
                laptop = 0; brain = 0; pencil = 0;
                label1.Text = $"Кол-во ноутбуков: {laptop}";
                label2.Text = $"Кол-во мозгов: {brain}";
                label3.Text = $"Кол-во карандашей: {pencil}";
            }

            else if (level == 3)
            {
                h = 0; m = 5; s = 0;
                breakfast = 0; fruits = 0; soda = 0;
                label1.Text = $"Кол-во завтраков: {breakfast}";
                label2.Text = $"Кол-во фруктов: {fruits}";
                label3.Text = $"Кол-во газировок: {soda}";
            }

            else if (level == 4)
            {
                h = 0; m = 6; s = 40;
                bulb = 0; book = 0; atom = 0;
                label1.Text = $"Кол-во лампочек: {bulb}";
                label2.Text = $"Кол-во книг: {book}";
                label3.Text = $"Кол-во атомов: {atom}";
            }

            else if (level == 5)
            {
                h = 0; m = 8; s = 20;
                rover = 0; brain = 0; atom = 0;
                label1.Text = $"Кол-во марсоходов: {rover}";
                label2.Text = $"Кол-во мозгов: {brain}";
                label3.Text = $"Кол-во атомов: {atom}";
            }

            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (sheet < 200)
                {
                    sheet++;
                    label2.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 200) MessageBox.Show("Вы набрали нужное количесвто листов!");
            }

            else if (level == 2)
            {
                if (brain < 300)
                {
                    brain++;
                    label2.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 300) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }

            else if (level == 3)
            {
                if (fruits < 800)
                {
                    fruits++;
                    label2.Text = $"Кол-во фруктов: {fruits}";
                }
                else if (fruits == 800) MessageBox.Show("Вы набрали нужное количество фруктов!");
            }

            else if (level == 4)
            {
                if (book < 700)
                {
                    book++;
                    label2.Text = $"Кол-во книг: {book}";
                }
                else if (book == 700) MessageBox.Show("Вы набрали нужное количество книг!");
            }

            else if (level == 5)
            {
                if (brain < 1500)
                {
                    brain++;
                    label2.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 1500) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (apple < 100)
                {
                    apple++;
                    label3.Text = $"Кол-во яблок: {apple}";
                }
                else if (apple == 100) MessageBox.Show("Вы набрали нужное количесвто яблок!");
            }

            else if (level == 2)
            {
                if (pencil < 200)
                {
                    pencil++;
                    label3.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 200) MessageBox.Show("Вы набрали нужное количество карандашей!");
            }

            else if (level == 3)
            {
                if (soda < 300)
                {
                    soda++;
                    label3.Text = $"Кол-во газировок: {soda}";
                }
                else if (soda == 300) MessageBox.Show("Вы набрали нужное количество газировок!");
            }

            else if (level == 4)
            {
                if (atom < 700)
                {
                    atom++;
                    label3.Text = $"Кол-во атомов: {atom}";
                }
                else if (atom == 700) MessageBox.Show("Вы набрали нужное количество атомов!");
            }

            else if (level == 5)
            {
                if (atom < 500)
                {
                    atom++;
                    label3.Text = $"Кол-во атомов: {atom}";
                }
                else if (atom == 500) MessageBox.Show("Вы набрали нужное количество атом!");
            }
        }
    }
}
