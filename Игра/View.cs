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

        public static void InitializeMap(Label label1, Label label4, Panel panel1, PictureBox pictureBox2, PictureBox pictureBox3, PictureBox pictureBox4,
            PictureBox pictureBox5, PictureBox pictureBox7, PictureBox pictureBox8, PictureBox pictureBox10, PictureBox pictureBox11)
        {
            label1.Text = Statistics.number_clicks.ToString();
            label4.Text = Statistics.number_clicks.ToString();
            panel1.Visible = false;
            BlockPictureBox(pictureBox2, Button_image_map.Image_IGiP, Button_image_map.Image_IGiP_Enabled);
            BlockPictureBox(pictureBox3, Button_image_map.Image_IMiKN, Button_image_map.Image_IMiKN_Enabled);
            BlockPictureBox(pictureBox4, Button_image_map.Image_InBio, Button_image_map.Image_InBio_Enabled);
            BlockPictureBox(pictureBox5, Button_image_map.Image_InZem, Button_image_map.Image_InZem_Enabled);
            BlockPictureBox(pictureBox7, Button_image_map.Image_IPiP, Button_image_map.Image_IPiP_Enabled);
            BlockPictureBox(pictureBox8, Button_image_map.Image_IFK, Button_image_map.Image_IFK_Enabled);
            BlockPictureBox(pictureBox10, Button_image_map.Image_FizTech, Button_image_map.Image_FizTech_Enabled);
            BlockPictureBox(pictureBox11, Button_image_map.Image_FEI, Button_image_map.Image_FEI_Enabled);

            if (!pictureBox2.Enabled && !pictureBox3.Enabled && !pictureBox4.Enabled && !pictureBox5.Enabled && !pictureBox7.Enabled
                && !pictureBox8.Enabled && !pictureBox10.Enabled && !pictureBox11.Enabled)
                panel1.Visible = true;
        }

        public static void BlockPictureBox(PictureBox pictureBox, string path_image, bool enabled_image)
        {
            pictureBox.Image = Image.FromFile(path_image);
            pictureBox.Enabled = enabled_image;
        }

        public static void LoadMap(PictureBox pictureBox2, PictureBox pictureBox3, PictureBox pictureBox4, PictureBox pictureBox5,
            PictureBox pictureBox7, PictureBox pictureBox8, PictureBox pictureBox10, PictureBox pictureBox11)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 3, 88, 90);
            Region rgn = new Region(path);
            PictureBoxСircle(pictureBox2, rgn);
            PictureBoxСircle(pictureBox3, rgn);
            PictureBoxСircle(pictureBox4, rgn);
            PictureBoxСircle(pictureBox5, rgn);
            PictureBoxСircle(pictureBox7, rgn);
            PictureBoxСircle(pictureBox8, rgn);
            PictureBoxСircle(pictureBox10, rgn);
            PictureBoxСircle(pictureBox11, rgn);
        }

        public static void PictureBoxСircle(PictureBox pictureBox, Region rgn)
        {
            pictureBox.Region = rgn;
            pictureBox.BackColor = SystemColors.ActiveCaption;
        }

        public static void PictureBoxMap_Click(Map map, int number_picturebox)
        {
            map.Hide();
            Music.pl2.Stop();
            switch (number_picturebox)
            {
                case 1:
                    Game game = new Game();
                    game.ShowDialog();
                    break;
                case 2:
                    ИГиП иГиП = new ИГиП();
                    иГиП.ShowDialog();
                    break;
                case 3:
                    ИМиКН иМиКН = new ИМиКН();
                    иМиКН.ShowDialog();
                    break;
                case 4:
                    ИнБио инБио = new ИнБио();
                    инБио.ShowDialog();
                    break;
                case 5:
                    ИнЗем инЗем = new ИнЗем();
                    инЗем.ShowDialog();
                    break;
                case 7:
                    ИПиП иПиП = new ИПиП();
                    иПиП.ShowDialog();
                    break;
                case 8:
                    ИФК иФК = new ИФК();
                    иФК.ShowDialog();
                    break;
                case 10:
                    ФизТех физТех = new ФизТех();
                    физТех.ShowDialog();
                    break;
                case 11:
                    ФЭИ фэи = new ФЭИ();
                    фэи.ShowDialog();
                    break;
            }

            map.Close();
        }

        public static void InitializeGame(Label label1, PictureBox pictureBox7, PictureBox pictureBox8, PictureBox pictureBox9,
            PictureBox pictureBox10, PictureBox pictureBox11, PictureBox pictureBox12, PictureBox pictureBox14, Panel panel2)
        {
            label1.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox14.Visible = false;
            panel2.Visible = false;
        }

        public static void TimerGame(PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3, PictureBox pictureBox4,
            PictureBox pictureBox5, PictureBox pictureBox6, PictureBox pictureBox7, PictureBox pictureBox8, PictureBox pictureBox9,
            PictureBox pictureBox10, PictureBox pictureBox11, PictureBox pictureBox12, PictureBox pictureBox14, PictureBox pictureBox15,
            Label label1)
        {
            TimerGamePictureBoxVisible(pictureBox1, pictureBox7);
            TimerGamePictureBoxVisible(pictureBox2, pictureBox8);
            TimerGamePictureBoxVisible(pictureBox3, pictureBox9);
            TimerGamePictureBoxVisible(pictureBox4, pictureBox10);
            TimerGamePictureBoxVisible(pictureBox5, pictureBox11);
            TimerGamePictureBoxVisible(pictureBox6, pictureBox12);
            TimerGamePictureBoxVisible(pictureBox15, pictureBox14);
            label1.Visible = true;
        }

        public static void TimerGamePictureBoxVisible(PictureBox pictureBox1, PictureBox pictureBox2)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }
    }
}
