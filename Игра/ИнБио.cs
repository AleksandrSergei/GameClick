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
        static Model GetModel()
        {
            Model model = new Model
            {
                number_institute = 3,
                count_levels = 5,
                complexity = 2,
                number_clicks = new int[11],
                label_names = new string[] { "книг", "листов", "карандашей", "мозгов", "колб", "растений", "микроскопов", "ДНК", "завтраков", "фруктов", "газировок" },
                path_names = new string[] { "книги2", "лист2", "карандаш", "мозг", "колбы", "растение", "микроскоп", "днк", "завтрак", "фрукты", "газировка" },
                tasks = new string[] { "Сходить на лекцию по биологии", "Сдать лабораторную работу по биоинженерии", "Время покушать, столовая",
                    "Решить задачу по биотехнологиям", "Сделать реферат на тему: 'Анатомия растений'" },
                number_button = new int[,] { { 0, 5, 2 },
                                             { 6, 5, 3 },
                                             { 8, 9, 10 },
                                             { 7, 4, 1 },
                                             { 6, 5, 1 } },
                time_sec = new int[] { 20, 40, 60, 80, 100 },
                number_random_clicks = new int[5, 3]
            };

            return model;
        }

        readonly Model model_InBio = GetModel();

        public ИнБио()
        {
            InitializeComponent();

            button1_InBio.Visible = true;
            button2_InBio.Visible = true;
            button3_InBio.Visible = true;

            Controller.Random_number_generator(model_InBio);
            View.Task_output(richTextBox_InBio, model_InBio, model_InBio.number_button[0, 0], model_InBio.number_button[0, 1], model_InBio.number_button[0, 2]);
            View.Label_update(label1_number_clicks_InBio, label2_number_clicks_InBio, label3_number_clicks_InBio, model_InBio, model_InBio.number_button[0, 0], model_InBio.number_button[0, 1], model_InBio.number_button[0, 2]);
            Music.pl4.Play();
            Controller.Circle_coordinate_generator(model_InBio);
        }

        private void Button1_InBio_Click(object sender, EventArgs e) => Controller.Click_button(0, model_InBio, label1_number_clicks_InBio, label2_number_clicks_InBio, label3_number_clicks_InBio);

        private void Button2_InBio_Click(object sender, EventArgs e) => Controller.Click_button(1, model_InBio, label1_number_clicks_InBio, label2_number_clicks_InBio, label3_number_clicks_InBio);

        private void Button3_InBio_Click(object sender, EventArgs e) => Controller.Click_button(2, model_InBio, label1_number_clicks_InBio, label2_number_clicks_InBio, label3_number_clicks_InBio);

        private void Button_start_InBio_Click(object sender, EventArgs e) => Controller.Labelandsecond_update(label1_number_clicks_InBio, label2_number_clicks_InBio, label3_number_clicks_InBio, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, model_InBio.number_button[model_InBio.level - 1, 0], model_InBio.number_button[model_InBio.level - 1, 1], model_InBio.number_button[model_InBio.level - 1, 2], model_InBio);


        private void Timer_number_seconds_Tick(object sender, EventArgs e)
        {
            int n = model_InBio.level - 1;
            model_InBio.sec -= 1;
            if (model_InBio.level != model_InBio.count_levels)
                Controller.Level_processing(model_InBio, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_InBio, label2_number_clicks_InBio, label3_number_clicks_InBio, button1_InBio, button2_InBio, button3_InBio, richTextBox_InBio, model_InBio.number_button[n, 0], model_InBio.number_button[n, 1],
                model_InBio.number_button[n, 2], model_InBio.number_button[n + 1, 0], model_InBio.number_button[n + 1, 1], model_InBio.number_button[n + 1, 2]);
            else
                Controller.Level_end(model_InBio, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_InBio, label2_number_clicks_InBio, label3_number_clicks_InBio, button1_InBio, button2_InBio, button3_InBio, richTextBox_InBio, model_InBio.number_button[n, 0], model_InBio.number_button[n, 1],
                    model_InBio.number_button[n, 2]);

            label_number_seconds_InBio.Text = Convert.ToString(model_InBio.sec);
        }

        private void PictureBox_door_InBio_Click(object sender, EventArgs e) => Controller.Exit(this, e);

        private void Timer_move_button1_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button1_InBio, model_InBio, 1);

        private void Timer_move_button2_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button2_InBio, model_InBio, 2);

        private void Timer_move_button3_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button3_InBio, model_InBio, 3);
    }
}

