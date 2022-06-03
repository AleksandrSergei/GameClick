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
        static Model GetModel()
        {
            Model model = new Model
            {
                number_institute = 4,
                count_levels = 5,
                complexity = 4,
                number_clicks = new int[12],
                label_names = new string[] { "книг", "листов", "карандашей", "мозгов", "завтраков", "фруктов", "газировок", "карт", "глобусов", "компасов", "палаток", "планет" },
                path_names = new string[] { "книги2", "лист2", "карандаш", "мозг", "завтрак", "фрукты", "газировка", "географ карта", "глобус", "компас", "палатка", "планета" },
                tasks = new string[] { "Сходить на лекцию по географии", "Сделать реферат на тему: 'Экология Тюменской области'", "Время покушать, столовая",
                    "Контрольая по картографии", "Практика по природопользованию" },
                number_button = new int[,] { { 7, 0, 9 },
                                             { 11, 1, 2 },
                                             { 4, 5, 6 },
                                             { 7, 3, 8 },
                                             { 10, 1, 9 } },
                time_sec = new int[] { 40, 60, 90, 120, 150 },
                number_random_clicks = new int[5, 3]
            };

            return model;
        }

        readonly Model model_InZem = GetModel();

        public ИнЗем()
        {
            InitializeComponent();

            button1_InZem.Visible = true;
            button2_InZem.Visible = true;
            button3_InZem.Visible = true;

            Controller.Random_number_generator(model_InZem);
            View.Task_output(richTextBox_InZem, model_InZem, model_InZem.number_button[0, 0], model_InZem.number_button[0, 1], model_InZem.number_button[0, 2]);
            View.Label_update(label1_number_clicks_InZem, label2_number_clicks_InZem, label3_number_clicks_InZem, model_InZem, model_InZem.number_button[0, 0], model_InZem.number_button[0, 1], model_InZem.number_button[0, 2]);
            Music.pl4.Play();
            Controller.Circle_coordinate_generator(model_InZem);
        }

        private void Button1_InZem_Click(object sender, EventArgs e) => Controller.Click_button(0, model_InZem, label1_number_clicks_InZem, label2_number_clicks_InZem, label3_number_clicks_InZem);

        private void Button2_InZem_Click(object sender, EventArgs e) => Controller.Click_button(1, model_InZem, label1_number_clicks_InZem, label2_number_clicks_InZem, label3_number_clicks_InZem);

        private void Button3_InZem_Click(object sender, EventArgs e) => Controller.Click_button(2, model_InZem, label1_number_clicks_InZem, label2_number_clicks_InZem, label3_number_clicks_InZem);

        private void Button_start_InZem_Click(object sender, EventArgs e) => Controller.Labelandsecond_update(label1_number_clicks_InZem, label2_number_clicks_InZem, label3_number_clicks_InZem, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, model_InZem.number_button[model_InZem.level - 1, 0], model_InZem.number_button[model_InZem.level - 1, 1], model_InZem.number_button[model_InZem.level - 1, 2], model_InZem);


        private void Timer_number_seconds_Tick(object sender, EventArgs e)
        {
            int n = model_InZem.level - 1;
            model_InZem.sec -= 1;
            if (model_InZem.level != model_InZem.count_levels)
                Controller.Level_processing(model_InZem, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_InZem, label2_number_clicks_InZem, label3_number_clicks_InZem, button1_InZem, button2_InZem, button3_InZem, richTextBox_InZem, model_InZem.number_button[n, 0], model_InZem.number_button[n, 1],
                model_InZem.number_button[n, 2], model_InZem.number_button[n + 1, 0], model_InZem.number_button[n + 1, 1], model_InZem.number_button[n + 1, 2]);
            else
                Controller.Level_end(model_InZem, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_InZem, label2_number_clicks_InZem, label3_number_clicks_InZem, button1_InZem, button2_InZem, button3_InZem, richTextBox_InZem, model_InZem.number_button[n, 0], model_InZem.number_button[n, 1],
                    model_InZem.number_button[n, 2]);

            label_number_seconds_InZem.Text = Convert.ToString(model_InZem.sec);
        }

        private void PictureBox_door_InZem_Click(object sender, EventArgs e) => Controller.Exit(this, e);

        private void Timer_move_button1_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button1_InZem, model_InZem, 1);

        private void Timer_move_button2_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button2_InZem, model_InZem, 2);

        private void Timer_move_button3_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button3_InZem, model_InZem, 3);
    }
}
