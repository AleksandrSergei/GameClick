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
    public partial class ИГиП : Form
    {
        static Model GetModel()
        {
            Model model = new Model
            {
                number_institute = 1,
                count_levels = 5,
                complexity = 1,
                number_clicks = new int[12],
                label_names = new string[] { "книг", "листов", "карандашей", "мозгов", "мячей", "спортсменов", "гирь", "весов", "молотов", "скрепок", "свитков", "папок" },
                path_names = new string[] { "книги2", "лист2", "карандаш", "мозг", "мяч", "спортсмен", "гиря", "веса", "судейский молот", "скрепка", "свиток", "папки" },
                tasks = new string[] { "Сдать практику по юриспруденции", "Пора размяться, пара физкультура", "Сделать презентацию на тему: 'Бухгалтерский отчёт'",
                    "Посетить лекцию по уголовному праву", "Сдать экзамен по истории государственного управления" },
                number_button = new int[,] { { 8, 3, 2 },
                                             { 4, 5, 6 },
                                             { 11, 9, 1 },
                                             { 7, 8, 2 },
                                             { 10, 0, 1 } },
                time_sec = new int[] { 30, 60, 80, 150, 240 },
                number_random_clicks = new int[5, 3]
            };

            return model;
        }

        readonly Model model_IGiP = GetModel();

        public ИГиП()
        {
            InitializeComponent();

            button1_IGiP.Visible = true;
            button2_IGiP.Visible = true;
            button3_IGiP.Visible = true;

            Controller.Random_number_generator(model_IGiP);
            View.Task_output(richTextBox_IGiP, model_IGiP, model_IGiP.number_button[0, 0], model_IGiP.number_button[0, 1], model_IGiP.number_button[0, 2]);
            View.Label_update(label1_number_clicks_IGiP, label2_number_clicks_IGiP, label3_number_clicks_IGiP, model_IGiP, model_IGiP.number_button[0, 0], model_IGiP.number_button[0, 1], model_IGiP.number_button[0, 2]);
            Music.pl4.Play();
            Controller.Circle_coordinate_generator(model_IGiP);
        }

        private void Button1_IGiP_Click(object sender, EventArgs e) => Controller.Click_button(0, model_IGiP, label1_number_clicks_IGiP, label2_number_clicks_IGiP, label3_number_clicks_IGiP);

        private void Button2_IGiP_Click(object sender, EventArgs e) => Controller.Click_button(1, model_IGiP, label1_number_clicks_IGiP, label2_number_clicks_IGiP, label3_number_clicks_IGiP);

        private void Button3_IGiP_Click(object sender, EventArgs e) => Controller.Click_button(2, model_IGiP, label1_number_clicks_IGiP, label2_number_clicks_IGiP, label3_number_clicks_IGiP);

        private void Button_start_IGiP_Click(object sender, EventArgs e) => Controller.Labelandsecond_update(label1_number_clicks_IGiP, label2_number_clicks_IGiP, label3_number_clicks_IGiP, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, model_IGiP.number_button[model_IGiP.level - 1, 0], model_IGiP.number_button[model_IGiP.level - 1, 1], model_IGiP.number_button[model_IGiP.level - 1, 2], model_IGiP);


        private void Timer_number_seconds_Tick(object sender, EventArgs e)
        {
            int n = model_IGiP.level - 1;
            model_IGiP.sec -= 1;
            if (model_IGiP.level != model_IGiP.count_levels)
                Controller.Level_processing(model_IGiP, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_IGiP, label2_number_clicks_IGiP, label3_number_clicks_IGiP, button1_IGiP, button2_IGiP, button3_IGiP, richTextBox_IGiP, model_IGiP.number_button[n, 0], model_IGiP.number_button[n, 1],
                model_IGiP.number_button[n, 2], model_IGiP.number_button[n + 1, 0], model_IGiP.number_button[n + 1, 1], model_IGiP.number_button[n + 1, 2]);
            else
                Controller.Level_end(model_IGiP, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_IGiP, label2_number_clicks_IGiP, label3_number_clicks_IGiP, button1_IGiP, button2_IGiP, button3_IGiP, richTextBox_IGiP, model_IGiP.number_button[n, 0], model_IGiP.number_button[n, 1],
                    model_IGiP.number_button[n, 2]);

            label_number_seconds_IGiP.Text = Convert.ToString(model_IGiP.sec);
        }

        private void PictureBox_door_IGiP_Click(object sender, EventArgs e) => Controller.Exit(this, e);

        private void Timer_move_button1_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button1_IGiP, model_IGiP, 1);

        private void Timer_move_button2_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button2_IGiP, model_IGiP, 2);

        private void Timer_move_button3_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button3_IGiP, model_IGiP, 3);
    }
}
