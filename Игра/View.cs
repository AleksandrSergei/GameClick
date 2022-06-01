using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Игра
{
    class View
    {
        public static void Label_update(Label label1, Label label2, Label label3, Model model, int n_1, int n_2, int n_3)
        {
            label1.Text = $"Кол-во {model.label_names[n_1]}: 0 / {model.number_random_clicks[model.level - 1, 0]}";
            label2.Text = $"Кол-во {model.label_names[n_2]}: 0 / {model.number_random_clicks[model.level - 1, 1]}";
            label3.Text = $"Кол-во {model.label_names[n_3]}: 0 / {model.number_random_clicks[model.level - 1, 2]}";
        }

        public static void Label_output_number_click(Label label, Model model, int n, int n_button)
        {
            label.Text = $"Кол-во {model.label_names[n]}: {model.number_clicks[n]} / {model.number_random_clicks[model.level - 1, n_button]}";
        }

        public static void Task_output(RichTextBox richTextBox, Model model, int n_1, int n_2, int n_3)
        {
            richTextBox.Text = $"{model.tasks[model.level - 1]}:\n{model.number_random_clicks[model.level - 1, 0]} {model.label_names[n_1]}\n" +
                                        $"{model.number_random_clicks[model.level - 1, 1]} {model.label_names[n_2]}\n" +
                                        $"{model.number_random_clicks[model.level - 1, 2]} {model.label_names[n_3]}\n" +
                                        $"У вас есть {model.time_sec[model.level - 1]} секунд!";
        }

        public static void Button_update(Button button1, Button button2, Button button3, Model model, int n_1, int n_2, int n_3)
        {
            button1.Image = Image.FromFile($"фотки\\кнопка {model.path_names[n_1]}.png");
            button2.Image = Image.FromFile($"фотки\\кнопка {model.path_names[n_2]}.png");
            button3.Image = Image.FromFile($"фотки\\кнопка {model.path_names[n_3]}.png");
        }
    }

    public static class Button_image_map
    {
        public static string Image_IMiKN = $"фотки\\иконка ИМиКН.png";
        public static string Image_IMiKN_block = $"фотки\\иконка ИМиКН_block.png";
        public static bool Image_IMiKN_Enabled = true;
    }
}
