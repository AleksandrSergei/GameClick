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
        private int[] number_of_clicks = new int[13]; // количество нажатий на кнопку

        // Названия для label
        private string[] label_names = { "книг", "листов", "карандашей", "мозгов", "ноутбуков", "принтеров", "калькуляторов", "мячей", "спортсменов", "гирь", "завтраков", "фруктов", "газировок" };
        
        // Названия для пути к кнопкам
        private string[] path_names = { "книги2", "лист2", "карандаш", "мозг", "ноутбук", "принтер", "калькулятор", "мяч", "спортсмен", "гиря", "завтрак", "фрукты", "газировка" };
        
        // Задания 
        private string[] tasks = { "Тебе нужно написать реферат по математике", "Сделать лабораторную работу по информатике", "Придти и прослушать лекцию по программированию", "Решить задачу по дискретной математике",
            "Сделать практику по компьютерной безопасности", "Написать контрольную по базам данных", "Пора позаниматься спортом, пара физкультуры", "После успешной тренировки, нужно подкрепиться",
            "Нужно подготовить презентация по информационным системам", "Сдать зачет по программированию"};
        
        // Номер кнопок по уровням
        private int[,] number_button = { { 0, 1, 5 },
                                        { 4, 3, 2 },
                                        { 0, 1, 5 },
                                        { 6, 1, 3 },
                                        { 0, 3, 5 },
                                        { 4, 1, 2 },
                                        { 7, 8, 9 },
                                        { 10, 11, 12 },
                                        { 4, 3, 5 },
                                        { 4, 1, 2 }};

        private int s = 0; // количесво секунд

        private int level = 1; // уровень

        private int k = 3; // сложность

        private int k_level = 10; // количество уровней

        private int[] time_s = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; // массив с секундами на каждый уровень

        private int[,] number_clicks = new int[10, 3]; // массив для количества кликов на каждую кнопку и каждый уровень

        public ИМиКН()
        {
            InitializeComponent();

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;

            Random rnd = new Random();

            for (int i = 0; i < k_level; i++)
            {
                int max = time_s[i] * k;
                number_clicks[i, 0] = rnd.Next(1, max / 2);
                max -= number_clicks[i, 0];
                number_clicks[i, 1] = rnd.Next(1, max / 2);
                max -= number_clicks[i, 1];
                number_clicks[i, 2] = max;
            }
            richTextBox1.Text = $"{tasks[level - 1]}:\n{number_clicks[level - 1, 0]} {label_names[number_button[0, 0]]}\n" +
                $"{number_clicks[level - 1, 1]} {label_names[number_button[0, 1]]}\n" +
                $"{number_clicks[level - 1, 2]} {label_names[number_button[0, 2]]}\nУ вас есть {time_s[level - 1]} секунд!";
            label1.Text = $"Кол-во {label_names[number_button[0, 0]]}: 0";
            label2.Text = $"Кол-во {label_names[number_button[0, 1]]}: 0";
            label3.Text = $"Кол-во {label_names[number_button[0, 2]]}: 0";

            Music.pl4.Play();
        }

        void button(int n_button)
        {
            int n = 0;
            switch (level)
            {
                case 1: n = number_button[0, n_button]; break;
                case 2: n = number_button[1, n_button]; break;
                case 3: n = number_button[2, n_button]; break;
                case 4: n = number_button[3, n_button]; break;
                case 5: n = number_button[4, n_button]; break;
                case 6: n = number_button[5, n_button]; break;
                case 7: n = number_button[6, n_button]; break;
                case 8: n = number_button[7, n_button]; break;
                case 9: n = number_button[8, n_button]; break;
                case 10: n = number_button[9, n_button]; break;
            }

            if (number_of_clicks[n] < number_clicks[level - 1, n_button])
            {
                number_of_clicks[n]++;
                switch (n_button)
                {
                    case 0: label1.Text = $"Кол-во {label_names[n]}: {number_of_clicks[n]}"; break;
                    case 1: label2.Text = $"Кол-во {label_names[n]}: {number_of_clicks[n]}"; break;
                    case 2: label3.Text = $"Кол-во {label_names[n]}: {number_of_clicks[n]}"; break;
                }
            }
            else if (number_of_clicks[n] == number_clicks[level - 1, n_button]) MessageBox.Show($"Вы набрали нужное количество {label_names[n]}!");
        }

        void button_update(int n_1, int n_2, int n_3)
        {
            s = time_s[level - 1];
            number_of_clicks[n_1] = 0; number_of_clicks[n_2] = 0; number_of_clicks[n_3] = 0;
            label1.Text = $"Кол-во {label_names[n_1]}: 0";
            label2.Text = $"Кол-во {label_names[n_2]}: 0";
            label3.Text = $"Кол-во {label_names[n_3]}: 0";
        }

        void level_processing(int o_1, int o_2, int o_3, int n_1, int n_2, int n_3)
        {
            if (number_of_clicks[o_1] == number_clicks[level - 1, 0] && number_of_clicks[o_2] == number_clicks[level - 1, 1] && 
                number_of_clicks[o_3] == number_clicks[level - 1, 2] && s > 0)
            {
                timer1.Stop();
                DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                        "Уровень пройден",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information,
                                                        MessageBoxDefaultButton.Button1);

                if (dialog == DialogResult.OK)
                {
                    number_of_clicks[n_1] = 0; number_of_clicks[n_2] = 0; number_of_clicks[n_3] = 0;

                    s = 0;
                    level += 1;
                    label1.Text = $"Кол-во {label_names[n_1]}: 0";
                    label2.Text = $"Кол-во {label_names[n_2]}: 0";
                    label3.Text = $"Кол-во {label_names[n_3]}: 0";
                    richTextBox1.Text = $"{tasks[level - 1]}:\n{number_clicks[level - 1, 0]} {label_names[n_1]}\n{number_clicks[level - 1, 1]} {label_names[n_2]}\n{number_clicks[level - 1, 2]} {label_names[n_3]}\nУ вас есть {time_s[level - 1]} секунд!";
                    button1.Image = Image.FromFile($"фотки\\кнопка {path_names[n_1]}.png");
                    button2.Image = Image.FromFile($"фотки\\кнопка {path_names[n_2]}.png");
                    button3.Image = Image.FromFile($"фотки\\кнопка {path_names[n_3]}.png");
                }
            }
            else if (s == 0)
            {
                timer1.Stop();
                DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: {label_names[o_1]} {number_of_clicks[o_1]}, {label_names[o_3]} {number_of_clicks[o_2]}, {label_names[o_3]} {number_of_clicks[o_3]}.",
                                                        "Время вышло!",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information,
                                                        MessageBoxDefaultButton.Button1);

                if (dialog == DialogResult.OK)
                {
                    number_of_clicks[o_1] = 0; number_of_clicks[o_2] = 0; number_of_clicks[o_3] = 0;
                    s = 0;
                    label1.Text = $"Кол-во {label_names[o_1]} : 0";
                    label2.Text = $"Кол-во {label_names[o_2]} : 0";
                    label3.Text = $"Кол-во {label_names[o_3]} : 0";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button(0);
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            button(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (level)
            {
                case 1: button_update(number_button[0, 0], number_button[0, 1], number_button[0, 2]); break;
                case 2: button_update(number_button[1, 0], number_button[1, 1], number_button[1, 2]); break;
                case 3: button_update(number_button[2, 0], number_button[2, 1], number_button[2, 2]); break;
                case 4: button_update(number_button[3, 0], number_button[3, 1], number_button[3, 2]); break;
                case 5: button_update(number_button[4, 0], number_button[4, 1], number_button[4, 2]); break;
                case 6: button_update(number_button[5, 0], number_button[5, 1], number_button[5, 2]); break;
                case 7: button_update(number_button[6, 0], number_button[6, 1], number_button[6, 2]); break;
                case 8: button_update(number_button[7, 0], number_button[7, 1], number_button[7, 2]); break;
                case 9: button_update(number_button[8, 0], number_button[8, 1], number_button[8, 2]); break;
                case 10: button_update(number_button[9, 0], number_button[9, 1], number_button[9, 2]); break;
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int n;
            s -= 1;
            switch (level)
            {
                case 1: n = 0; level_processing(number_button[n, 0], number_button[n, 1], number_button[n, 2], number_button[n+1, 0], number_button[n+1, 1], number_button[n+1, 2]); break;
                case 2: n = 1; level_processing(number_button[n, 0], number_button[n, 1], number_button[n, 2], number_button[n+1, 0], number_button[n+1, 1], number_button[n+1, 2]); break;
                case 3: n = 2; level_processing(number_button[n, 0], number_button[n, 1], number_button[n, 2], number_button[n+1, 0], number_button[n+1, 1], number_button[n+1, 2]); break;
                case 4: n = 3; level_processing(number_button[n, 0], number_button[n, 1], number_button[n, 2], number_button[n+1, 0], number_button[n+1, 1], number_button[n+1, 2]); break;
                case 5: n = 4; level_processing(number_button[n, 0], number_button[n, 1], number_button[n, 2], number_button[n+1, 0], number_button[n+1, 1], number_button[n+1, 2]); break;
                case 6: n = 5; level_processing(number_button[n, 0], number_button[n, 1], number_button[n, 2], number_button[n+1, 0], number_button[n+1, 1], number_button[n+1, 2]); break;
                case 7: n = 6; level_processing(number_button[n, 0], number_button[n, 1], number_button[n, 2], number_button[n+1, 0], number_button[n+1, 1], number_button[n+1, 2]); break;
                case 8: n = 7; level_processing(number_button[n, 0], number_button[n, 1], number_button[n, 2], number_button[n+1, 0], number_button[n+1, 1], number_button[n+1, 2]); break;
                case 9: n = 8; level_processing(number_button[n, 0], number_button[n, 1], number_button[n, 2], number_button[n+1, 0], number_button[n+1, 1], number_button[n+1, 2]); break;
                case 10:
                    int n_1 = number_button[9, 0];
                    int n_2 = number_button[9, 1];
                    int n_3 = number_button[9, 2];
                    if (number_of_clicks[n_1] == number_clicks[level - 1, 0] && number_of_clicks[n_2] == number_clicks[level - 1, 1] && number_of_clicks[n_3] == number_clicks[level - 1, 2] && s > 0)
                    {
                        timer1.Stop();
                        DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                          "Институт пройден!",
                                                          MessageBoxButtons.OK,
                                                          MessageBoxIcon.Information,
                                                          MessageBoxDefaultButton.Button1);
                        if (dialog == DialogResult.OK)
                        {
                            number_of_clicks[n_1] = 0; number_of_clicks[n_2] = 0; number_of_clicks[n_3] = 0;
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
                        DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: {label_names[n_1]} {number_of_clicks[n_1]}, {label_names[n_3]} {number_of_clicks[n_2]}, {label_names[n_3]} {number_of_clicks[n_3]}.",
                                                        "Время вышло!",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information,
                                                        MessageBoxDefaultButton.Button1);

                        if (dialog == DialogResult.OK)
                        {
                            number_of_clicks[n_1] = 0; number_of_clicks[n_2] = 0; number_of_clicks[n_3] = 0;
                            s = 0;
                            label1.Text = $"Кол-во {label_names[n_1]} : 0";
                            label2.Text = $"Кол-во {label_names[n_2]} : 0";
                            label3.Text = $"Кол-во {label_names[n_3]} : 0";
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
