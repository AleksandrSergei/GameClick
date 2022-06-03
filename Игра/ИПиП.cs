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
    public partial class ИПиП : Form
    {
        static Model GetModel()
        {
            Model model = new Model
            {
                number_institute = 5,
                count_levels = 5,
                complexity = 3,
                number_clicks = new int[12],
                label_names = new string[] { "книг", "листов", "карандашей", "мозгов", "завтраков", "фруктов", "газировок", "учеников", "учителей", "звонков", "тетрадей", "голов" },
                path_names = new string[] { "книги2", "лист2", "карандаш", "мозг", "завтрак", "фрукты", "газировка", "ученики", "учитель", "звонок", "тетрадь", "голова" },
                tasks = new string[] { "Перед занятиями нужно подкрепиться", "Лекция по начальному образованию", "Презентация на тему: 'Педагогическое образование'",
                    "Практика по психологии", "Сдать зачет по социальной психологии" },
                number_button = new int[,] { { 4, 5, 6 },
                                             { 9, 2, 8 },
                                             { 10, 1, 7 },
                                             { 11, 0, 3 },
                                             { 10, 1, 3 } },
                time_sec = new int[] { 20, 30, 40, 50, 90 },
                number_random_clicks = new int[5, 3]
            };

            return model;
        }

        readonly Model model_IPiP = GetModel();

        public ИПиП()
        {
            InitializeComponent();

            button1_IPiP.Visible = true;
            button2_IPiP.Visible = true;
            button3_IPiP.Visible = true;

            Controller.Random_number_generator(model_IPiP);
            View.Task_output(richTextBox_IPiP, model_IPiP, model_IPiP.number_button[0, 0], model_IPiP.number_button[0, 1], model_IPiP.number_button[0, 2]);
            View.Label_update(label1_number_clicks_IPiP, label2_number_clicks_IPiP, label3_number_clicks_IPiP, model_IPiP, model_IPiP.number_button[0, 0], model_IPiP.number_button[0, 1], model_IPiP.number_button[0, 2]);
            Music.pl4.Play();
            Controller.Circle_coordinate_generator(model_IPiP);
        }

        private void Button1_IPiP_Click(object sender, EventArgs e) => Controller.Click_button(0, model_IPiP, label1_number_clicks_IPiP, label2_number_clicks_IPiP, label3_number_clicks_IPiP);

        private void Button2_IPiP_Click(object sender, EventArgs e) => Controller.Click_button(1, model_IPiP, label1_number_clicks_IPiP, label2_number_clicks_IPiP, label3_number_clicks_IPiP);

        private void Button3_IPiP_Click(object sender, EventArgs e) => Controller.Click_button(2, model_IPiP, label1_number_clicks_IPiP, label2_number_clicks_IPiP, label3_number_clicks_IPiP);

        private void Button_start_IPiP_Click(object sender, EventArgs e) => Controller.Labelandsecond_update(label1_number_clicks_IPiP, label2_number_clicks_IPiP, label3_number_clicks_IPiP, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, model_IPiP.number_button[model_IPiP.level - 1, 0], model_IPiP.number_button[model_IPiP.level - 1, 1], model_IPiP.number_button[model_IPiP.level - 1, 2], model_IPiP);


        private void Timer_number_seconds_Tick(object sender, EventArgs e)
        {
            int n = model_IPiP.level - 1;
            model_IPiP.sec -= 1;
            if (model_IPiP.level != model_IPiP.count_levels)
                Controller.Level_processing(model_IPiP, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_IPiP, label2_number_clicks_IPiP, label3_number_clicks_IPiP, button1_IPiP, button2_IPiP, button3_IPiP, richTextBox_IPiP, model_IPiP.number_button[n, 0], model_IPiP.number_button[n, 1],
                model_IPiP.number_button[n, 2], model_IPiP.number_button[n + 1, 0], model_IPiP.number_button[n + 1, 1], model_IPiP.number_button[n + 1, 2]);
            else
                Controller.Level_end(model_IPiP, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_IPiP, label2_number_clicks_IPiP, label3_number_clicks_IPiP, button1_IPiP, button2_IPiP, button3_IPiP, richTextBox_IPiP, model_IPiP.number_button[n, 0], model_IPiP.number_button[n, 1],
                    model_IPiP.number_button[n, 2]);

            label_number_seconds_IPiP.Text = Convert.ToString(model_IPiP.sec);
        }

        private void PictureBox_door_IPiP_Click(object sender, EventArgs e) => Controller.Exit(this, e);

        private void Timer_move_button1_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button1_IPiP, model_IPiP, 1);

        private void Timer_move_button2_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button2_IPiP, model_IPiP, 2);

        private void Timer_move_button3_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button3_IPiP, model_IPiP, 3);
    }
}