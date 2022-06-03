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
    public partial class ФЭИ : Form
    {
        static Model GetModel()
        {
            Model model = new Model
            {
                number_institute = 8,
                count_levels = 5,
                complexity = 4,
                number_clicks = new int[12],
                label_names = new string[] { "книг", "листов", "карандашей", "мозгов", "мячей", "спортсменов", "гирь","монет", "карт", "калькуляторов", "статистик", "человек" },
                path_names = new string[] { "книги2", "лист2", "карандаш", "мозг","мяч", "спортсмен", "гиря", "монета", "банк карта", "калькулятор", "статистика", "человек" },
                tasks = new string[] { "Сделать презентацию по социологии", "Практика по экономической безопасности", "Ходить на лекцию по экономике",
                    "Позаниматься физкультурой", "Контрольная по маркетингу" },
                number_button = new int[,] { { 11, 0, 3 },
                                             { 7, 1, 3 },
                                             { 8, 2, 9 },
                                             { 4, 5, 6 },
                                             { 10, 0, 9 } },
                time_sec = new int[] { 50, 100, 150, 200, 250 },
                number_random_clicks = new int[5, 3]
            };

            return model;
        }

        readonly Model model_FEI = GetModel();

        public ФЭИ()
        {
            InitializeComponent();

            button1_FEI.Visible = true;
            button2_FEI.Visible = true;
            button3_FEI.Visible = true;

            Controller.Random_number_generator(model_FEI);
            View.Task_output(richTextBox_FEI, model_FEI, model_FEI.number_button[0, 0], model_FEI.number_button[0, 1], model_FEI.number_button[0, 2]);
            View.Label_update(label1_number_clicks_FEI, label2_number_clicks_FEI, label3_number_clicks_FEI, model_FEI, model_FEI.number_button[0, 0], model_FEI.number_button[0, 1], model_FEI.number_button[0, 2]);
            Music.pl4.Play();
            Controller.Circle_coordinate_generator(model_FEI);
        }

        private void Button1_FEI_Click(object sender, EventArgs e) => Controller.Click_button(0, model_FEI, label1_number_clicks_FEI, label2_number_clicks_FEI, label3_number_clicks_FEI);

        private void Button2_FEI_Click(object sender, EventArgs e) => Controller.Click_button(1, model_FEI, label1_number_clicks_FEI, label2_number_clicks_FEI, label3_number_clicks_FEI);

        private void Button3_FEI_Click(object sender, EventArgs e) => Controller.Click_button(2, model_FEI, label1_number_clicks_FEI, label2_number_clicks_FEI, label3_number_clicks_FEI);

        private void Button_start_FEI_Click(object sender, EventArgs e) => Controller.Labelandsecond_update(label1_number_clicks_FEI, label2_number_clicks_FEI, label3_number_clicks_FEI, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, model_FEI.number_button[model_FEI.level - 1, 0], model_FEI.number_button[model_FEI.level - 1, 1], model_FEI.number_button[model_FEI.level - 1, 2], model_FEI);


        private void Timer_number_seconds_Tick(object sender, EventArgs e)
        {
            int n = model_FEI.level - 1;
            model_FEI.sec -= 1;
            if (model_FEI.level != model_FEI.count_levels)
                Controller.Level_processing(model_FEI, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_FEI, label2_number_clicks_FEI, label3_number_clicks_FEI, button1_FEI, button2_FEI, button3_FEI, richTextBox_FEI, model_FEI.number_button[n, 0], model_FEI.number_button[n, 1],
                model_FEI.number_button[n, 2], model_FEI.number_button[n + 1, 0], model_FEI.number_button[n + 1, 1], model_FEI.number_button[n + 1, 2]);
            else
                Controller.Level_end(model_FEI, timer_number_seconds, timer_move_button1, timer_move_button2, timer_move_button3, label1_number_clicks_FEI, label2_number_clicks_FEI, label3_number_clicks_FEI, button1_FEI, button2_FEI, button3_FEI, richTextBox_FEI, model_FEI.number_button[n, 0], model_FEI.number_button[n, 1],
                    model_FEI.number_button[n, 2]);

            label_number_seconds_FEI.Text = Convert.ToString(model_FEI.sec);
        }

        private void PictureBox_door_FEI_Click(object sender, EventArgs e) => Controller.Exit(this, e);

        private void Timer_move_button1_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button1_FEI, model_FEI, 1);

        private void Timer_move_button2_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button2_FEI, model_FEI, 2);

        private void Timer_move_button3_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button3_FEI, model_FEI, 3);

       
    }
}

