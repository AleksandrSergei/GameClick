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
    public partial class ИнЗем : Form
    {
        private int book = 0;
        private int sheet = 0;
        private int pencil = 0;
        private int brain = 0;
        private int map = 0;
        private int compass = 0;
        private int globe = 0;
        private int tent = 0;
        private int breakfast = 0;
        private int fruits = 0;
        private int soda = 0;
        private int planet = 0;
        private int h = 0, m = 0, s = 0;

        private int level = 1;

        public ИнЗем()
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
                if (map < 60)
                {
                    map++;
                    label1.Text = $"Кол-во карт: {map}";
                }
                else if (map == 60) MessageBox.Show("Вы набрали нужное количесвто карт!");
            }

            else if (level == 2)
            {
                if (planet < 80)
                {
                    planet++;
                    label1.Text = $"Кол-во планет: {planet}";
                }
                else if (planet == 80) MessageBox.Show("Вы набрали нужное количество планет!");
            }

            else if (level == 3)
            {
                if (breakfast < 120)
                {
                    breakfast++;
                    label1.Text = $"Кол-во завтраков: {breakfast}";
                }
                else if (breakfast == 120) MessageBox.Show("Вы набрали нужное количество завтраков!");
            }

            else if (level == 4)
            {
                if (map < 120)
                {
                    map++;
                    label1.Text = $"Кол-во карт: {map}";
                }
                else if (map == 120) MessageBox.Show("Вы набрали нужное количество карт!");
            }

            else if (level == 5)
            {
                if (tent < 150)
                {
                    tent++;
                    label1.Text = $"Кол-во палаток: {tent}";
                }
                else if (tent == 150) MessageBox.Show("Вы набрали нужное количество палаток!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (book < 30)
                {
                    book++;
                    label2.Text = $"Кол-во книг: {book}";
                }
                else if (book == 30) MessageBox.Show("Вы набрали нужное количесвто книг!");
            }

            else if (level == 2)
            {
                if (sheet < 60)
                {
                    sheet++;
                    label2.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 60) MessageBox.Show("Вы набрали нужное количество листов!");
            }

            else if (level == 3)
            {
                if (fruits < 80)
                {
                    fruits++;
                    label2.Text = $"Кол-во фруктов: {fruits}";
                }
                else if (fruits == 80) MessageBox.Show("Вы набрали нужное количество фруктов!");
            }

            else if (level == 4)
            {
                if (brain < 120)
                {
                    brain++;
                    label2.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 120) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }

            else if (level == 5)
            {
                if (sheet < 100)
                {
                    sheet++;
                    label2.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 100) MessageBox.Show("Вы набрали нужное количество листов!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (compass < 30)
                {
                    compass++;
                    label3.Text = $"Кол-во компасов: {compass}";
                }
                else if (compass == 30) MessageBox.Show("Вы набрали нужное количесвто компасов!");
            }

            else if (level == 2)
            {
                if (pencil < 40)
                {
                    pencil++;
                    label3.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 40) MessageBox.Show("Вы набрали нужное количество карандашей!");
            }

            else if (level == 3)
            {
                if (soda < 70)
                {
                    soda++;
                    label3.Text = $"Кол-во газировок: {soda}";
                }
                else if (soda == 70) MessageBox.Show("Вы набрали нужное количество газировок!");
            }

            else if (level == 4)
            {
                if (globe < 120)
                {
                    globe++;
                    label3.Text = $"Кол-во глобусов: {globe}";
                }
                else if (globe == 120) MessageBox.Show("Вы набрали нужное количество глобусов!");
            }

            else if (level == 5)
            {
                if (compass < 200)
                {
                    compass++;
                    label3.Text = $"Кол-во компасов: {compass}";
                }
                else if (compass == 200) MessageBox.Show("Вы набрали нужное количество компасов!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                h = 0; m = 0; s = 40;
                map = 0; book = 0; compass = 0;
                label1.Text = $"Кол-во карт: {map}";
                label2.Text = $"Кол-во книг: {book}";
                label3.Text = $"Кол-во компасов: {compass}";
            }

            else if (level == 2)
            {
                h = 0; m = 1; s = 0;
                planet = 0; sheet = 0; pencil = 0;
                label1.Text = $"Кол-во планет: {planet}";
                label2.Text = $"Кол-во листов: {sheet}";
                label3.Text = $"Кол-во карандашей: {pencil}";
            }

            else if (level == 3)
            {
                h = 0; m = 1; s = 30;
                breakfast = 0; fruits = 0; soda = 0;
                label1.Text = $"Кол-во завтраков: {breakfast}";
                label2.Text = $"Кол-во фруктов: {fruits}";
                label3.Text = $"Кол-во газировок: {soda}";
            }

            else if (level == 4)
            {
                h = 0; m = 2; s = 0;
                map = 0; brain = 0; globe = 0;
                label1.Text = $"Кол-во карт: {map}";
                label2.Text = $"Кол-во мозгов: {brain}";
                label3.Text = $"Кол-во глобусов: {globe}";
            }

            else if (level == 5)
            {
                h = 0; m = 2; s = 30;
                tent = 0; sheet = 0; compass = 0;
                label1.Text = $"Кол-во палаток: {tent}";
                label2.Text = $"Кол-во листов: {sheet}";
                label3.Text = $"Кол-во компасов: {compass}";
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
                if ((map == 60 && book == 30 && compass == 30) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        map = 0; book = 0; compass = 0;
                        h = 0; m = 0; s = 0;
                        level = 2;
                        label1.Text = $"Кол-во планет: {planet}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                        richTextBox1.Text = "Сделать реферат на тему 'Экология Тюменской области':\n80 планет\n60 листов\n40 карандашей\nУ вас есть 1 минута!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка планета.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка карандаш.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: карт {map}, книг {book}, компасов {compass}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        map = 0; book = 0; compass = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во карт: {map}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во компасов: {compass}";
                    }
                }
            }

            else if (level == 2)
            {
                if ((planet == 80 && sheet == 60 && pencil == 40) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        planet = 0; sheet = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        level = 3;
                        label1.Text = $"Кол-во завтраков: {breakfast}";
                        label2.Text = $"Кол-во фруктов: {fruits}";
                        label3.Text = $"Кол-во газировок: {soda}";
                        richTextBox1.Text = "Время покушать, столовая:\n120 завтраков\n80 фруктов\n70 газировок\nУ вас есть 1 минута 30 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка завтрак.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка фрукты.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка газировка.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: планет {planet}, листов {sheet}, карандашей {pencil}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        planet = 0; sheet = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во планет: {planet}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                    }
                }
            }

            else if (level == 3)
            {
                if ((breakfast == 120 && fruits ==80 && soda == 70) && (s > 0 || h > 0 || m > 0))
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
                        label1.Text = $"Кол-во карт: {map}";
                        label2.Text = $"Кол-во мозгов: {brain}";
                        label3.Text = $"Кол-во глобусов: {globe}";
                        richTextBox1.Text = "Контрольная по картографии:\n120 карт\n120 мозгов\n120 глобусов\nУ вас есть 2 минуты!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка географ карта.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка глобус.jpg");
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
                if ((map == 120 && brain == 120 && globe == 120) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        map = 0; brain = 0; globe = 0;
                        h = 0; m = 0; s = 0;
                        level = 5;
                        label1.Text = $"Кол-во палаток: {tent}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во компасов: {compass}";
                        richTextBox1.Text = "Практика по природопользованию:\n150 палаток\n100 листов\n200 компасов\nУ вас есть 2 минуты 30 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка палатка.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка компас.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: карт {map}, мозгов {brain}, глобусов {globe}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        map = 0; brain = 0; globe = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во карт: {map}";
                        label2.Text = $"Кол-во мозгов: {brain}";
                        label3.Text = $"Кол-во глобусов: {globe}";
                    }
                }
            }

            else if (level == 5)
            {
                if ((tent == 150 && sheet == 100 && compass == 200) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Институт пройден!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        tent = 0; sheet = 0; compass = 0;
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
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: палаток {tent}, листов {sheet}, компасов {compass}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        tent = 0; sheet = 0; compass = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во палаток: {tent}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во компасов: {compass}";
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
