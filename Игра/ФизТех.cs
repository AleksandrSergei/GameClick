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
        static Model GetModel()
        {
            Model model = new Model
            {
                number_institute = 7,
                count_levels = 5,
                complexity = 5,
                number_clicks = new int[12],
                label_names = new string[] { "книг", "листов", "карандашей", "мозгов", "завтраков", "фруктов", "газировок", "ноутбуков", "атомов", "лампочек", "яблок", "марсоходов" },
                path_names = new string[] { "книги2", "лист2", "карандаш", "мозг", "завтрак", "фрукты", "газировка", "ноутбук", "атом", "лампочка", "яблоко", "марсоход" },
                tasks = new string[] { "Решить задачу по механике", "Сделать лабораторную работу по информатике", "Сходить в столовую",
                    "Лекция по технической физике", "Экзамен по физике" },
                number_button = new int[,] { { 11, 1, 10 },
                                             { 7, 3, 2 },
                                             { 4, 5, 6 },
                                             { 9, 0, 8 },
                                             { 11, 3, 8 } },
                time_sec = new int[] { 45, 95, 120, 160, 230 },
                number_random_clicks = new int[5, 3]
            };

            return model;
        }

        readonly Model model_FizTech = GetModel();

        public ФизТех()
        {
            InitializeComponent();

            button1_FizTech.Visible = true;
            button2_FizTech.Visible = true;
            button3_FizTech.Visible = true;

            Controller.Random_number_generator(model_FizTech);
            View.Task_output(richTextBox_FizTech, model_FizTech, model_FizTech.number_button[0, 0], model_FizTech.number_button[0, 1], model_FizTech.number_button[0, 2]);
            View.Label_update(label1_number_clicks_FizTech, label2_number_clicks_FizTech, label3_number_clicks_FizTech, model_FizTech, model_FizTech.number_button[0, 0], model_FizTech.number_button[0, 1], model_FizTech.number_button[0, 2]);
            Music.pl4.Play();
            Controller.Circle_coordinate_generator(model_FizTech);
        }

        private void Button1_FizTech_Click(object sender, EventArgs e) => Controller.Click_button(0, model_FizTech, label1_number_clicks_FizTech, label2_number_clicks_FizTech, label3_number_clicks_FizTech);

        private void Button2_FizTech_Click(object sender, EventArgs e) => Controller.Click_button(1, model_FizTech, label1_number_clicks_FizTech, label2_number_clicks_FizTech, label3_number_clicks_FizTech);

        private void Button3_FizTech_Click(object sender, EventArgs e) => Controller.Click_button(2, model_FizTech, label1_number_clicks_FizTech, label2_number_clicks_FizTech, label3_number_clicks_FizTech);

        private void Button_start_FizTech_Click(object sender, EventArgs e) => Controller.Labelandsecond_update(label1_number_clicks_FizTech, label2_number_clicks_FizTech, label3_number_clicks_FizTech, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, model_FizTech.number_button[model_FizTech.level - 1, 0], model_FizTech.number_button[model_FizTech.level - 1, 1], model_FizTech.number_button[model_FizTech.level - 1, 2], model_FizTech);


        private void Timer_number_seconds_Tick(object sender, EventArgs e)
        {
            int n = model_FizTech.level - 1;
            model_FizTech.sec -= 1;
            if (model_FizTech.level != model_FizTech.count_levels)
                Controller.Level_processing(model_FizTech, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_FizTech, label2_number_clicks_FizTech, label3_number_clicks_FizTech, button1_FizTech, button2_FizTech, button3_FizTech, richTextBox_FizTech, model_FizTech.number_button[n, 0], model_FizTech.number_button[n, 1],
                model_FizTech.number_button[n, 2], model_FizTech.number_button[n + 1, 0], model_FizTech.number_button[n + 1, 1], model_FizTech.number_button[n + 1, 2]);
            else
                Controller.Level_end(model_FizTech, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_FizTech, label2_number_clicks_FizTech, label3_number_clicks_FizTech, button1_FizTech, button2_FizTech, button3_FizTech, richTextBox_FizTech, model_FizTech.number_button[n, 0], model_FizTech.number_button[n, 1],
                    model_FizTech.number_button[n, 2]);

            label_number_seconds_FizTech.Text = Convert.ToString(model_FizTech.sec);
        }

        private void PictureBox_door_FizTech_Click(object sender, EventArgs e) => Controller.Exit(this, e);

        private void Timer_move_button1_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button1_FizTech, model_FizTech, 1);

        private void Timer_move_button2_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button2_FizTech, model_FizTech, 2);

        private void Timer_move_button3_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button3_FizTech, model_FizTech, 3);
    }
}
