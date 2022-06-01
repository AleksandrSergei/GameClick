using System;
using System.Windows.Forms;

namespace Игра
{
    public partial class ИМиКН : Form
    {
        static Model GetModel()
        {
            Model model = new Model
            {
                count_levels = 5,
                complexity = 3,
                number_clicks = new int[10],
                label_names = new string[] { "книг", "листов", "карандашей", "мозгов", "ноутбуков", "принтеров", "калькуляторов", "мячей", "спортсменов", "гирь" },
                path_names = new string[] { "книги2", "лист2", "карандаш", "мозг", "ноутбук", "принтер", "калькулятор", "мяч", "спортсмен", "гиря" },
                tasks = new string[] { "Сделать лабораторную работу по информатике", "Сделать практику по компьютерной безопасности", "Написать контрольную по базам данных",
                    "Пора позаниматься спортом, пара физкультуры", "Сдать зачет по программированию" },
                number_button = new int[,] { { 4, 3, 2 },
                                             { 0, 3, 5 },
                                             { 4, 1, 6 },
                                             { 7, 8, 9 },
                                             { 4, 1, 2 } },
                time_sec = new int[] { 10, 20, 30, 40, 50 },
                number_random_clicks = new int[5, 3]
            };

            return model;
        }

        readonly Model model_IMiKN = GetModel();

        public ИМиКН()
        {
            InitializeComponent();

            button1_IMiKN.Visible = true;
            button2_IMiKN.Visible = true;
            button3_IMiKN.Visible = true;

            Controller.Random_number_generator(model_IMiKN);
            View.Task_output(richTextBox__IMiKN, model_IMiKN, model_IMiKN.number_button[0, 0], model_IMiKN.number_button[0, 1], model_IMiKN.number_button[0, 2]);
            View.Label_update(label1_number_clicks_IMiKN, label2_number_clicks_IMiKN, label3_number_clicks_IMiKN, model_IMiKN, model_IMiKN.number_button[0, 0], model_IMiKN.number_button[0, 1], model_IMiKN.number_button[0, 2]);
            Music.pl4.Play();
            Controller.Circle_coordinate_generator(model_IMiKN);
        }

        private void Button1_IMiKN_Click(object sender, EventArgs e) => Controller.Click_button(0, model_IMiKN, label1_number_clicks_IMiKN, label2_number_clicks_IMiKN, label3_number_clicks_IMiKN);

        private void Button2_IMiKN_Click(object sender, EventArgs e) => Controller.Click_button(1, model_IMiKN, label1_number_clicks_IMiKN, label2_number_clicks_IMiKN, label3_number_clicks_IMiKN);

        private void Button3_IMiKN_Click(object sender, EventArgs e) => Controller.Click_button(2, model_IMiKN, label1_number_clicks_IMiKN, label2_number_clicks_IMiKN, label3_number_clicks_IMiKN);

        private void Button_start_IMiKN_Click(object sender, EventArgs e) => Controller.Labelandsecond_update(label1_number_clicks_IMiKN, label2_number_clicks_IMiKN, label3_number_clicks_IMiKN, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, model_IMiKN.number_button[model_IMiKN.level - 1, 0], model_IMiKN.number_button[model_IMiKN.level - 1, 1], model_IMiKN.number_button[model_IMiKN.level - 1, 2], model_IMiKN);


        private void Timer_number_seconds_Tick(object sender, EventArgs e)
        {
            int n = model_IMiKN.level-1;
            model_IMiKN.sec -= 1;
            if (model_IMiKN.level != model_IMiKN.count_levels)
                Controller.Level_processing(model_IMiKN, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_IMiKN, label2_number_clicks_IMiKN, label3_number_clicks_IMiKN, button1_IMiKN, button2_IMiKN, button3_IMiKN, richTextBox__IMiKN, model_IMiKN.number_button[n, 0], model_IMiKN.number_button[n, 1],
                model_IMiKN.number_button[n, 2], model_IMiKN.number_button[n + 1, 0], model_IMiKN.number_button[n + 1, 1], model_IMiKN.number_button[n + 1, 2]);
            else
                Controller.Level_end(model_IMiKN, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_IMiKN, label2_number_clicks_IMiKN, label3_number_clicks_IMiKN, button1_IMiKN, button2_IMiKN, button3_IMiKN, richTextBox__IMiKN, model_IMiKN.number_button[n, 0], model_IMiKN.number_button[n, 1],
                    model_IMiKN.number_button[n, 2], Button_image_map.Image_IMiKN, Button_image_map.Image_IMiKN_block, Button_image_map.Image_IMiKN_Enabled);

            label_number_seconds_IMiKN.Text = Convert.ToString(model_IMiKN.sec);
        }

        private void PictureBox_door_IMiKN_Click(object sender, EventArgs e) => Controller.Exit(this, e);

        private void Timer_move_button1_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button1_IMiKN, model_IMiKN, 1);

        private void Timer_move_button2_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button2_IMiKN, model_IMiKN, 2);

        private void Timer_move_button3_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button3_IMiKN, model_IMiKN, 3);
    }
}
