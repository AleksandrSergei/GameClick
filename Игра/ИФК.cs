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
        private int[] k_botton= new int[12];
        private string[] name_botton = { "книг", "листов", "карандашей", "мозгов", "мячей", "кроссовок", "кубков", "зарядок", "гирь", "завтраков", "фруктов", "газировок" };
        private string[] tasks = { "Тренировка по басскетболу", "Лекция по теме 'Педагоги физической культуры'", "Презентация на тему 'Физическая культура в России'", "Нужно сходить покушать", "Зачет по тренерству" };
        private string[] name_b = { "книги2", "лист2", "карандаш", "мозг", "баскет мяч", "кроссовок", "кубок", "зарядка", "гиря", "завтрак", "фрукты", "газировка"};

        private int s = 0; // количесво секунд

        private int level = 1; // уровень

        private int k = 5; // сложность

        private int k_level = 5; // количество уровней

        private int[] time_s = {40, 80, 120, 160, 200}; // массив с секундами на каждый уровень

        private int[,] k_click = new int[5, 3]; // массив для количества кликов на каждую кнопку и каждый уровень

        public ИФК()
        {
            InitializeComponent();

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;

            Random rnd = new Random();

            for (int i = 0; i < k_level; i++)
            {
                int max = time_s[i] * k;
                k_click[i, 0] = rnd.Next(0, max);
                max -= k_click[i, 0];
                k_click[i, 1] = rnd.Next(0, max);
                max -= k_click[i, 1];
                k_click[i, 2] = max;
            }

            richTextBox1.Text = $"{tasks[level-1]}:\n{k_click[level - 1, 0]} {name_botton[4]}\n{k_click[level - 1, 1]} {name_botton[5]}\n{k_click[level - 1, 2]} {name_botton[3]}\nУ вас есть {time_s[level-1]} секунд!";
            label1.Text = $"Кол-во {name_botton[4]}: 0";
            label2.Text = $"Кол-во {name_botton[5]}: 0";
            label3.Text = $"Кол-во {name_botton[3]}: 0";
        }
        void button(int b, int n)
        {
            if (k_botton[n] < k_click[level - 1, b])
            {
                k_botton[n]++;
                switch (b)
                {
                    case 0: label1.Text = $"Кол-во {name_botton[n]}: {k_botton[n]}"; break;
                    case 1: label2.Text = $"Кол-во {name_botton[n]}: {k_botton[n]}"; break;
                    case 2: label3.Text = $"Кол-во {name_botton[n]}: {k_botton[n]}"; break;
                }
            }
            else if (k_botton[n] == k_click[level - 1, b]) MessageBox.Show($"Вы набрали нужное количество {name_botton[n]}!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (level)
            {
                case 1: button(0, 4); break;
                case 2: button(0, 6); break;
                case 3: button(0, 1); break;
                case 4: button(0, 9); break;
                case 5: button(0, 7); break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (level)
            {
                case 1: button(1, 5); break;
                case 2: button(1, 0); break;
                case 3: button(1, 5); break;
                case 4: button(1, 10); break;
                case 5: button(1, 8); break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (level)
            {
                case 1: button(2, 3); break;
                case 2: button(2, 2); break;
                case 3: button(2, 2); break;
                case 4: button(2, 11); break;
                case 5: button(2, 3); break;
            }
        }

        void button_update(int n_1, int n_2, int n_3)
        {
            s = time_s[level - 1];
            k_botton[n_1] = 0; k_botton[n_2] = 0; k_botton[n_3] = 0;
            label1.Text = $"Кол-во {name_botton[n_1]}: 0";
            label2.Text = $"Кол-во {name_botton[n_2]}: 0";
            label3.Text = $"Кол-во {name_botton[n_3]}: 0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (level)
            {
                case 1: button_update(4, 5, 3); break;
                case 2: button_update(6, 0, 2); break;
                case 3: button_update(1, 5, 2); break;
                case 4: button_update(9, 10, 11); break;
                case 5: button_update(7, 8, 3); break;
            }

            timer1.Start();
        }

        void level_processing(int o_1, int o_2, int o_3, int n_1, int n_2, int n_3)
        {
            if (k_botton[o_1] == k_click[level - 1, 0] && k_botton[o_2] == k_click[level - 1, 1] && k_botton[o_3] == k_click[level - 1, 2] && s > 0)
            {
                timer1.Stop();
                DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.", 
                                                        "Уровень пройден", 
                                                        MessageBoxButtons.OK, 
                                                        MessageBoxIcon.Information, 
                                                        MessageBoxDefaultButton.Button1);

                if (dialog == DialogResult.OK)
                {
                    k_botton[n_1] = 0; k_botton[n_2] = 0; k_botton[n_3] = 0;
                    s = 0;
                    level += 1;
                    label1.Text = $"Кол-во {name_botton[n_1]}: 0";
                    label2.Text = $"Кол-во {name_botton[n_2]}: 0";
                    label3.Text = $"Кол-во {name_botton[n_3]}: 0";
                    richTextBox1.Text = $"{tasks[level - 1]}:\n{k_click[level - 1, 0]} {name_botton[n_1]}\n{k_click[level - 1, 1]} {name_botton[n_2]}\n{k_click[level - 1, 2]} {name_botton[n_3]}\nУ вас есть {time_s[level - 1]} секунд!";
                    button1.Image = Image.FromFile($"фотки\\кнопка {name_b[n_1]}.png");
                    button2.Image = Image.FromFile($"фотки\\кнопка {name_b[n_2]}.png");
                    button3.Image = Image.FromFile($"фотки\\кнопка {name_b[n_3]}.png");
                }
            }
            else if (s == 0)
            {
                timer1.Stop();
                DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: {name_botton[o_1]} {k_botton[o_1]}, {name_botton[o_3]} {k_botton[o_2]}, {name_botton[o_3]} {k_botton[o_3]}.", 
                                                        "Время вышло!", 
                                                        MessageBoxButtons.OK, 
                                                        MessageBoxIcon.Information, 
                                                        MessageBoxDefaultButton.Button1);

                if (dialog == DialogResult.OK)
                {
                    k_botton[o_1] = 0; k_botton[o_2] = 0; k_botton[o_3] = 0;
                    s = 0;
                    label1.Text = $"Кол-во {name_botton[o_1]} : 0";
                    label2.Text = $"Кол-во {name_botton[o_2]} : 0";
                    label3.Text = $"Кол-во {name_botton[o_3]} : 0";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s -= 1;
            switch (level)
            {
                case 1: level_processing(4, 5, 3, 6, 0, 2); break;
                case 2: level_processing(6, 0, 2, 1, 5, 2); break;
                case 3: level_processing(1, 5, 2, 9, 10, 11); break;
                case 4: level_processing(9, 10, 11, 7, 8, 3); break;
                case 5:
                    int n_1 = 7;
                    int n_2 = 8;
                    int n_3 = 3;
                    if (k_botton[n_1] == k_click[level - 1, 0] && k_botton[n_2] == k_click[level - 1, 1] && k_botton[n_3] == k_click[level - 1, 2] && s > 0)
                    {
                        timer1.Stop();
                        DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                          "Институт пройден!",
                                                          MessageBoxButtons.OK,
                                                          MessageBoxIcon.Information,
                                                          MessageBoxDefaultButton.Button1);
                        if (dialog == DialogResult.OK)
                        {
                            k_botton[n_1] = 0; k_botton[n_2] = 0; k_botton[n_3] = 0;
                            s = 0;
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
                    else if (s == 0)
                    {
                        timer1.Stop();
                        DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: {name_botton[n_1]} {k_botton[n_1]}, {name_botton[n_3]} {k_botton[n_2]}, {name_botton[n_3]} {k_botton[n_3]}.",
                                                        "Время вышло!",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information,
                                                        MessageBoxDefaultButton.Button1);

                        if (dialog == DialogResult.OK)
                        {
                            k_botton[n_1] = 0; k_botton[n_2] = 0; k_botton[n_3] = 0;
                            s = 0;
                            label1.Text = $"Кол-во {name_botton[n_1]} : 0";
                            label2.Text = $"Кол-во {name_botton[n_2]} : 0";
                            label3.Text = $"Кол-во {name_botton[n_3]} : 0";
                        }
                    }
                    break;
            }

            label6.Text = Convert.ToString(s);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Music.pl4.Stop();
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
                Music.pl4.Play();
            }
        }
    }
}
