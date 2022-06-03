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
        static Model GetModel()
        {
            Model model = new Model
            {
                number_institute = 6,
                count_levels = 5,
                complexity = 5,
                number_clicks = new int[12],
                label_names = new string[] { "книг", "листов", "карандашей", "мозгов", "мячей", "кроссовок", "кубков", "зарядок", "гирь", "завтраков", "фруктов", "газировок" },
                path_names = new string[] { "книги2", "лист2", "карандаш", "мозг", "баскет мяч", "кроссовок", "кубок", "зарядка", "гиря", "завтрак", "фрукты", "газировка" },
                tasks = new string[] { "Тренировка по баскетболу", "Лекция на тему: 'Педагогика физической культуры'", "Презентация на тему: 'Физическая культура в России'",
                    "Нужно сходить поесть", "Зачет по тренирству" },
                number_button = new int[,] { { 4, 5, 3 },
                                             { 6, 0, 2 },
                                             { 1, 5, 2 },
                                             { 9, 10, 11 },
                                             { 7, 8, 3 } },
                time_sec = new int[] { 40, 80, 120, 160, 200 },
                number_random_clicks = new int[5, 3]
            };

            return model;
        }

        readonly Model model_IFK = GetModel();

        public ИФК()
        {
            InitializeComponent();

            button1_IFK.Visible = true;
            button2_IFK.Visible = true;
            button3_IFK.Visible = true;

            Controller.Random_number_generator(model_IFK);
            View.Task_output(richTextBox_IFK, model_IFK, model_IFK.number_button[0, 0], model_IFK.number_button[0, 1], model_IFK.number_button[0, 2]);
            View.Label_update(label1_number_clicks_IFK, label2_number_clicks_IFK, label3_number_clicks_IFK, model_IFK, model_IFK.number_button[0, 0], model_IFK.number_button[0, 1], model_IFK.number_button[0, 2]);
            Music.pl4.Play();
            Controller.Circle_coordinate_generator(model_IFK);
        }

        private void Button1_IFK_Click(object sender, EventArgs e) => Controller.Click_button(0, model_IFK, label1_number_clicks_IFK, label2_number_clicks_IFK, label3_number_clicks_IFK);

        private void Button2_IFK_Click(object sender, EventArgs e) => Controller.Click_button(1, model_IFK, label1_number_clicks_IFK, label2_number_clicks_IFK, label3_number_clicks_IFK);

        private void Button3_IFK_Click(object sender, EventArgs e) => Controller.Click_button(2, model_IFK, label1_number_clicks_IFK, label2_number_clicks_IFK, label3_number_clicks_IFK);

        private void Button_start_IFK_Click(object sender, EventArgs e) => Controller.Labelandsecond_update(label1_number_clicks_IFK, label2_number_clicks_IFK, label3_number_clicks_IFK, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, model_IFK.number_button[model_IFK.level - 1, 0], model_IFK.number_button[model_IFK.level - 1, 1], model_IFK.number_button[model_IFK.level - 1, 2], model_IFK);


        private void Timer_number_seconds_Tick(object sender, EventArgs e)
        {
            int n = model_IFK.level - 1;
            model_IFK.sec -= 1;
            if (model_IFK.level != model_IFK.count_levels)
                Controller.Level_processing(model_IFK, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_IFK, label2_number_clicks_IFK, label3_number_clicks_IFK, button1_IFK, button2_IFK, button3_IFK, richTextBox_IFK, model_IFK.number_button[n, 0], model_IFK.number_button[n, 1],
                model_IFK.number_button[n, 2], model_IFK.number_button[n + 1, 0], model_IFK.number_button[n + 1, 1], model_IFK.number_button[n + 1, 2]);
            else
                Controller.Level_end(model_IFK, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_IFK, label2_number_clicks_IFK, label3_number_clicks_IFK, button1_IFK, button2_IFK, button3_IFK, richTextBox_IFK, model_IFK.number_button[n, 0], model_IFK.number_button[n, 1],
                    model_IFK.number_button[n, 2]);

            label_number_seconds_IFK.Text = Convert.ToString(model_IFK.sec);
        }

        private void PictureBox_door_IFK_Click(object sender, EventArgs e) => Controller.Exit(this, e);

        private void Timer_move_button1_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button1_IFK, model_IFK, 1);

        private void Timer_move_button2_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button2_IFK, model_IFK, 2);

        private void Timer_move_button3_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button3_IFK, model_IFK, 3);
    }
}
