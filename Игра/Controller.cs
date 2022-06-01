using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Drawing;

namespace Игра
{
    public class Controller
    {
        public static void Labelandsecond_update(Label label1, Label label2, Label label3, System.Windows.Forms.Timer timer1, 
            System.Windows.Forms.Timer timer2, System.Windows.Forms.Timer timer3, System.Windows.Forms.Timer timer4,
            int n_1, int n_2, int n_3, Model model)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            model.sec = model.time_sec[model.level - 1];
            model.number_clicks[n_1] = 0; model.number_clicks[n_2] = 0; model.number_clicks[n_3] = 0;
            View.Label_update(label1, label2, label3, model, n_1, n_2, n_3);
        }

        public static void Secondandlevel_update(Model model, int n_1, int n_2, int n_3, bool update_level)
        {
            model.number_clicks[n_1] = 0; model.number_clicks[n_2] = 0; model.number_clicks[n_3] = 0;
            model.sec = 0;
            model.level += update_level ? 1 : 0;
        }

        public static void Click_button(int n_button, Model model, Label label1, Label label2, Label label3)
        {
            int n = model.number_button[model.level - 1, n_button];

            if (model.number_clicks[n] < model.number_random_clicks[model.level - 1, n_button])
            {
                model.number_clicks[n]++;
                Statistics.number_clicks += 1;

                switch (n_button)
                {
                    case 0: View.Label_output_number_click(label1, model, n, 0); break;
                    case 1: View.Label_output_number_click(label2, model, n, 1); break;
                    case 2: View.Label_output_number_click(label3, model, n, 2); break;
                }
            }
        }

        public static void Random_number_generator(Model model)
        {
            for (int i = 0; i < model.count_levels; i++)
            {
                int max;
                int x;
                int y;
                int Ticks = Math.Abs((int)DateTime.Now.Ticks);
                x = int.Parse(Ticks.ToString().Substring(i, 4));
                for (int j = 0; j < 3; j++)
                {
                    max = model.time_sec[i] * model.complexity / 3;
                    y = int.Parse(((x * x).ToString().ToString() + new string('0', 8 - (x * x).ToString().ToString().Length)).Substring(2, 4));
                    x = y;
                    do
                    {
                        model.number_random_clicks[i, j] += y % 10 * (i + 1);
                        max -= y % 10 * (i + 1);
                        y /= 10;
                    }
                    while (max > 0 && y != 0);
                    if (model.number_random_clicks[i, j] < model.time_sec[i] * model.complexity / 3)
                        model.number_random_clicks[i, j] = model.time_sec[i] * model.complexity / 3;
                }
            }
        }

        public static void Exit(object form, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ((Control)form).Hide();
                Map map = new Map();
                Music.pl4.Stop();
                map.ShowDialog();
            }
        }

        public static void Level_processing(Model model, System.Windows.Forms.Timer timer1, System.Windows.Forms.Timer timer2, System.Windows.Forms.Timer timer3, System.Windows.Forms.Timer timer4, 
            Label label1, Label label2, Label label3, Button button1, Button button2, Button button3, RichTextBox richTextBox, int o_1, int o_2, int o_3, int n_1, int n_2, int n_3)
        {
            if (model.number_clicks[o_1] == model.number_random_clicks[model.level - 1, 0] && model.number_clicks[o_2] == model.number_random_clicks[model.level - 1, 1] &&
                model.number_clicks[o_3] == model.number_random_clicks[model.level - 1, 2] && model.sec > 0)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.", "Уровень пройден",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (dialog == DialogResult.OK)
                {
                    Secondandlevel_update(model, n_1, n_2, n_3, true);
                    View.Label_update(label1, label2, label3, model, n_1, n_2, n_3);
                    View.Task_output(richTextBox, model, model.number_button[model.level - 1, 0], model.number_button[model.level - 1, 1], model.number_button[model.level - 1, 2]);
                    View.Button_update(button1, button2, button3, model, n_1, n_2, n_3);
                }
            }
            else if (model.sec == 0)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: {model.label_names[o_1]} {model.number_clicks[o_1]}, {model.label_names[o_3]} {model.number_clicks[o_2]}, {model.label_names[o_3]} {model.number_clicks[o_3]}.",
                    "Время вышло!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (dialog == DialogResult.OK)
                {
                    Secondandlevel_update(model, n_1, n_2, n_3, false);
                    View.Label_update(label1, label2, label3, model, o_1, o_2, o_3);
                }
            }
        }

        public static void Level_end(Model model, System.Windows.Forms.Timer timer1, System.Windows.Forms.Timer timer2, System.Windows.Forms.Timer timer3, System.Windows.Forms.Timer timer4, Label label1, Label label2, Label label3, Button button1, Button button2, Button button3,
            RichTextBox richTextBox, int n_1, int n_2, int n_3, string Image, string Image_block, bool Image_Enabled)
        {
            if (model.number_clicks[n_1] == model.number_random_clicks[model.level - 1, 0] && model.number_clicks[n_2] == model.number_random_clicks[model.level - 1, 1] && model.number_clicks[n_3] == model.number_random_clicks[model.level - 1, 2] && model.sec > 0)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.", "Институт пройден!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (dialog == DialogResult.OK)
                {
                    Image = Image_block;
                    Image_Enabled = false;
                    model.number_clicks[n_1] = model.number_clicks[n_2] = model.number_clicks[n_3] = 0;
                    model.sec = 0;
                    model.level = 1;
                    label1.Text = label2.Text = label3.Text = $"";
                    richTextBox.Text = "Институт пройден !!!";
                    button1.Visible = button2.Visible = button3.Visible = false;
                }
            }
            else if (model.sec == 0)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: {model.label_names[n_1]} {model.number_clicks[n_1]}, {model.label_names[n_3]} {model.number_clicks[n_2]}, {model.label_names[n_3]} {model.number_clicks[n_3]}.",
                                                "Время вышло!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (dialog == DialogResult.OK)
                {
                    Secondandlevel_update(model, n_1, n_2, n_3, false);
                    View.Label_update(label1, label2, label3, model, n_1, n_2, n_3);
                }
            }
        }

        public static void Circle_coordinate_generator(Model model)
        {
            int[] centerX = new int[3] { 100, 500, 880 }; 
            int[] centerY = new int[3] { 350, 300, 250 };
            int radius = 90;

            for (var degree = 0; degree < 360; degree++)
            {
                var radians = degree * Math.PI / 180;
                model.coordinate_1[degree,0] = Convert.ToInt32(centerX[0] + radius * Math.Cos(radians));
                model.coordinate_1[degree, 1] = Convert.ToInt32(centerY[0] + radius * Math.Sin(radians));
                model.coordinate_2[degree, 0] = Convert.ToInt32(centerX[1] + radius * Math.Cos(radians));
                model.coordinate_2[degree, 1] = Convert.ToInt32(centerY[1] + radius * Math.Sin(radians));
                model.coordinate_3[degree, 0] = Convert.ToInt32(centerX[2] + radius * Math.Cos(radians));
                model.coordinate_3[degree, 1] = Convert.ToInt32(centerY[2] + radius * Math.Sin(radians));
            }
        }

        public static void Movement_buttons(Button button, Model model, int number_button)
        {
            switch (number_button)
            {
                case 1:
                    {
                        if (model.index_coordinate1 == 359)
                            model.index_coordinate1 = 0;

                        button.Location = new Point(model.coordinate_1[model.index_coordinate1, 0], model.coordinate_1[model.index_coordinate1, 1]);
                        model.index_coordinate1++;
                        break;
                    }
                case 2:
                    {
                        if (model.index_coordinate2 == 359)
                            model.index_coordinate2 = 0;

                        button.Location = new Point(model.coordinate_2[model.index_coordinate2, 0], model.coordinate_2[model.index_coordinate2, 1]);
                        model.index_coordinate2++;
                        break;
                    }
                case 3:
                    {
                        if (model.index_coordinate3 == 359)
                            model.index_coordinate3 = 0;

                        button.Location = new Point(model.coordinate_3[model.index_coordinate3, 0], model.coordinate_3[model.index_coordinate3, 1]);
                        model.index_coordinate3++;
                        break;
                    }

            }
        }
    }
}
