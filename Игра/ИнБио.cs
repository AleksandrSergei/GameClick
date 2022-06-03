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
    public partial class ИнБио : Form
    {
        private int book = 0;
        private int sheet = 0;
        private int pencil = 0;
        private int brain = 0;
        private int plant = 0;
        private int microscope = 0;
        private int dnk = 0;
        private int flack = 0;
        private int breakfast = 0;
        private int fruits = 0;
        private int soda = 0;
        private int h = 0, m = 0, s = 0;

        private int level = 1;

        public ИнБио()
        {
            InitializeComponent();

            button1_InBio.Visible = true;
            button2_InBio.Visible = true;
            button3_InBio.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (book < 20)
                {
                    book++;
                    label1.Text = $"Кол-во книг: {book}";
                }
                else if (book == 20) MessageBox.Show("Вы набрали нужное количесвто книг!");
            }

            else if (level == 2)
            {
                if (microscope < 60)
                {
                    microscope++;
                    label1.Text = $"Кол-во микроскопов: {microscope}";
                }
                else if (microscope == 60) MessageBox.Show("Вы набрали нужное количество микроскопов!");
            }

            else if (level == 3)
            {
                if (breakfast < 90)
                {
                    breakfast++;
                    label1.Text = $"Кол-во завтраков: {breakfast}";
                }
                else if (breakfast == 90) MessageBox.Show("Вы набрали нужное количество завтраков!");
            }

            else if (level == 4)
            {
                if (dnk < 150)
                {
                    dnk++;
                    label1.Text = $"Кол-во днк: {dnk}";
                }
                else if (dnk == 150) MessageBox.Show("Вы набрали нужное количество днк!");
            }

            else if (level == 5)
            {
                if (microscope < 120)
                {
                    microscope++;
                    label1.Text = $"Кол-во микроскопов: {microscope}";
                }
                else if (microscope == 120) MessageBox.Show("Вы набрали нужное количество микроскопов!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (plant < 20)
                {
                    plant++;
                    label2.Text = $"Кол-во растений: {plant}";
                }
                else if (plant == 20) MessageBox.Show("Вы набрали нужное количесвто растений!");
            }

            else if (level == 2)
            {
                if (plant < 50)
                {
                    plant++;
                    label2.Text = $"Кол-во растений: {plant}";
                }
                else if (plant == 50) MessageBox.Show("Вы набрали нужное количество растений!");
            }

            else if (level == 3)
            {
                if (fruits < 60)
                {
                    fruits++;
                    label2.Text = $"Кол-во фруктов: {fruits}";
                }
                else if (fruits == 60) MessageBox.Show("Вы набрали нужное количество фруктов!");
            }

            else if (level == 4)
            {
                if (flack < 100)
                {
                    flack++;
                    label2.Text = $"Кол-во колб: {flack}";
                }
                else if (flack == 100) MessageBox.Show("Вы набрали нужное количество колб!");
            }

            else if (level == 5)
            {
                if (plant < 175)
                {
                    plant++;
                    label2.Text = $"Кол-во растений: {plant}";
                }
                else if (plant == 175) MessageBox.Show("Вы набрали нужное количество растений!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (pencil < 40)
                {
                    pencil++;
                    label3.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 40) MessageBox.Show("Вы набрали нужное количесвто карандашей!");
            }

            else if (level == 2)
            {
                if (brain < 40)
                {
                    brain++;
                    label3.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 40) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }

            else if (level == 3)
            {
                if (soda < 30)
                {
                    soda++;
                    label3.Text = $"Кол-во газировок: {soda}";
                }
                else if (soda == 30) MessageBox.Show("Вы набрали нужное количество газировок!");
            }

            else if (level == 4)
            {
                if (sheet < 50)
                {
                    sheet++;
                    label3.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 50) MessageBox.Show("Вы набрали нужное количество листов!");
            }

            else if (level == 5)
            {
                if (sheet < 80)
                {
                    sheet++;
                    label3.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 80) MessageBox.Show("Вы набрали нужное количество листов!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                h = 0; m = 0; s = 20;
                book = 0; plant = 0; pencil = 0;
                label1.Text = $"Кол-во книг: {book}";
                label2.Text = $"Кол-во растений: {plant}";
                label3.Text = $"Кол-во карандашей: {pencil}";
            }

            else if (level == 2)
            {
                h = 0; m = 0; s = 40;
                microscope = 0; plant = 0; brain = 0;
                label1.Text = $"Кол-во микроскопов: {microscope}";
                label2.Text = $"Кол-во растений: {plant}";
                label3.Text = $"Кол-во мозгов: {brain}";
            }

            else if (level == 3)
            {
                h = 0; m = 1; s = 0;
                breakfast = 0; fruits = 0; soda = 0;
                label1.Text = $"Кол-во завтраков: {breakfast}";
                label2.Text = $"Кол-во фруктов: {fruits}";
                label3.Text = $"Кол-во газировок: {soda}";
            }

            else if (level == 4)
            {
                h = 0; m = 1; s = 20;
                dnk = 0; flack = 0; sheet = 0;
                label1.Text = $"Кол-во днк: {dnk}";
                label2.Text = $"Кол-во колб: {flack}";
                label3.Text = $"Кол-во листов: {sheet}";
            }

            else if (level == 5)
            {
                h = 0; m = 1; s = 40;
                microscope = 0; plant = 0; sheet = 0;
                label1.Text = $"Кол-во микроскопов: {microscope}";
                label2.Text = $"Кол-во растенйи: {plant}";
                label3.Text = $"Кол-во листов: {sheet}";
            }

            timer_number_seconds.Start();
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
                if ((book == 20 && plant == 20 && pencil == 40) && (s > 0 || h > 0 || m > 0))
                {
                    timer_number_seconds.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; plant = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        level = 2;
                        label1.Text = $"Кол-во микроскопов: {microscope}";
                        label2.Text = $"Кол-во растений: {plant}";
                        label3.Text = $"Кол-во мозгов: {brain}";
                        richTextBox1.Text = "Сдать лабораторную работу по биоинженерии:\n60 микроскопов\n50 растений\n40 мозгов\nУ вас есть 40 секунд!";
                        button1_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка микроскоп.png");
                        button2_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка растение.png");
                        button3_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer_number_seconds.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: книг {book}, растений {plant}, карандашей {pencil}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; plant = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во книг: {book}";
                        label2.Text = $"Кол-во растений: {plant}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                    }
                }
            }

            else if (level == 2)
            {
                if ((microscope == 60 && plant == 50 && brain == 40) && (s > 0 || h > 0 || m > 0))
                {
                    timer_number_seconds.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        microscope = 0; plant = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        level = 3;
                        label1.Text = $"Кол-во завтраков: {breakfast}";
                        label2.Text = $"Кол-во фруктов: {fruits}";
                        label3.Text = $"Кол-во газировок: {soda}";
                        richTextBox1.Text = "Время покушать, столовая:\n90 завтраков\n60 фруктов\n30 газировок\nУ вас есть 1 минута!";
                        button1_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка завтрак.png");
                        button2_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка фрукты.png");
                        button3_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка газировка.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer_number_seconds.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: микроскопов {microscope}, растений {plant}, мозгов {brain}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        microscope = 0; plant = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во микроскопов: {microscope}";
                        label2.Text = $"Кол-во растений: {plant}";
                        label3.Text = $"Кол-во мозгов: {brain}";
                    }
                }
            }

            else if (level == 3)
            {
                if ((breakfast == 90 && fruits == 60 && soda == 30) && (s > 0 || h > 0 || m > 0))
                {
                    timer_number_seconds.Stop();
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
                        label1.Text = $"Кол-во днк: {dnk}";
                        label2.Text = $"Кол-во колб: {flack}";
                        label3.Text = $"Кол-во листов: {sheet}";
                        richTextBox1.Text = "Решить задачи по биотехнологиям:\n150 днк\n100 колб\n50 листов\nУ вас есть 1 минут 20 секунд!";
                        button1_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка днк.png");
                        button2_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка колбы.png");
                        button3_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer_number_seconds.Stop();
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
                if ((dnk == 150 && flack == 100 && sheet == 50) && (s > 0 || h > 0 || m > 0))
                {
                    timer_number_seconds.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        dnk = 0; flack = 0; sheet = 0;
                        h = 0; m = 0; s = 0;
                        level = 5;
                        label1.Text = $"Кол-во микроскопов: {microscope}";
                        label2.Text = $"Кол-во растенйи: {plant}";
                        label3.Text = $"Кол-во листов: {sheet}";
                        richTextBox1.Text = "Сдать реферат на тему 'Анатомия растений':\n120 микроскопов\n175 растений\n80 листов\nУ вас есть 1 минут 40 секунд!";
                        button1_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка микроскоп.png");
                        button2_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка растение.png");
                        button3_InBio.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer_number_seconds.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: днк {dnk}, колб {flack}, листов {sheet}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        dnk = 0; flack = 0; sheet = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во днк: {dnk}";
                        label2.Text = $"Кол-во колб: {flack}";
                        label3.Text = $"Кол-во листов: {sheet}";
                    }
                }
            }

            else if (level == 5)
            {
                if ((microscope == 120 && plant == 175 && sheet == 80) && (s > 0 || h > 0 || m > 0))
                {
                    timer_number_seconds.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Институт пройден!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        microscope = 0; plant = 0; sheet = 0;
                        h = 0; m = 0; s = 0;
                        level = 1;
                        label1.Text = $"";
                        label2.Text = $"";
                        label3.Text = $"";
                        richTextBox1.Text = "Институт пройден !!!";
                        button1_InBio.Visible = false;
                        button2_InBio.Visible = false;
                        button3_InBio.Visible = false;
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer_number_seconds.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: микроскопов {microscope}, растений {plant}, листов {sheet}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        microscope = 0; plant = 0; sheet = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во микроскопов: {microscope}";
                        label2.Text = $"Кол-во растенйи: {plant}";
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
