using System;
using System.Windows.Forms;

namespace Игра
{
    public partial class ИМиКН : Form
    {
        static Model GetModel()
        {
            Model model = new Model();

            model.count_levels = 5;
            model.complexity = 3;
            model.number_clicks = new int[10];
            model.label_names = new string[] { "книг", "листов", "карандашей", "мозгов", "ноутбуков", "принтеров", "калькуляторов", "мячей", "спортсменов", "гирь"};
            model.path_names = new string[] { "книги2", "лист2", "карандаш", "мозг", "ноутбук", "принтер", "калькулятор", "мяч", "спортсмен", "гиря"};
            model.tasks = new string[] {"Сделать лабораторную работу по информатике", "Сделать практику по компьютерной безопасности", "Написать контрольную по базам данных", 
                "Пора позаниматься спортом, пара физкультуры", "Сдать зачет по программированию"};
            model.number_button = new int [,] { { 4, 3, 2 },
                                                { 0, 3, 5 },
                                                { 4, 1, 6 },
                                                { 7, 8, 9 },
                                                { 4, 1, 2 }};
            model.time_sec = new int [] { 10, 20, 30, 40, 50};
            model.number_random_clicks = new int[5, 3];

            return model;
        }

        Model model = GetModel();

        public ИМиКН()
        {
            InitializeComponent();

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;

            Controller.Random_number_generator(model);
            View.Task_output(richTextBox1, model, model.number_button[0, 0], model.number_button[0, 1], model.number_button[0, 2]);
            View.Label_update(label1, label2, label3, model, model.number_button[0, 0], model.number_button[0, 1], model.number_button[0, 2]);
            Music.pl4.Play();
            Controller.Circle_coordinate_generator(model);
        }

        private void button1_Click(object sender, EventArgs e) => Controller.Click_button(0, model, label1, label2, label3);

        private void button2_Click(object sender, EventArgs e) => Controller.Click_button(1, model, label1, label2, label3);

        private void button3_Click(object sender, EventArgs e) => Controller.Click_button(2, model, label1, label2, label3);

        private void button4_Click(object sender, EventArgs e)
        {
            Controller.Labelandsecond_update(label1, label2, label3, model.number_button[model.level - 1, 0], model.number_button[model.level - 1, 1], model.number_button[model.level - 1, 2], model);
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int n = model.level-1;
            model.sec -= 1;
            if (model.level != model.count_levels)
                Controller.Level_processing(model, timer1, timer2, timer3, timer4, label1, label2, label3, button1, button2, button3, richTextBox1, model.number_button[n, 0], model.number_button[n, 1],
                model.number_button[n, 2], model.number_button[n + 1, 0], model.number_button[n + 1, 1], model.number_button[n + 1, 2]);
            else
                Controller.Level_end(model, timer1, label1, label2, label3, button1, button2, button3, richTextBox1, model.number_button[n + 1, 0], model.number_button[n + 1, 1],
                    model.number_button[n + 1, 2]);

            label6.Text = Convert.ToString(model.sec);
        }

        private void pictureBox2_Click(object sender, EventArgs e) => Controller.Exit(this, e);

        private void timer2_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button1, model, 1);

        private void timer3_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button2, model, 2);

        private void timer4_Tick(object sender, EventArgs e) => Controller.Movement_buttons(button3, model, 3);
    }
}
