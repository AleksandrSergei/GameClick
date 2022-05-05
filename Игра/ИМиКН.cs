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
    public partial class ИМиКН : Form
    {
        private int book = 0;
        private int sheet = 0;
        private int printer = 0;
        private int laptop = 0;
        private int brain = 0;
        private int pencil = 0;
        private int calculator = 0;
        private int ball = 0;
        private int athlete = 0;
        private int dumbbells = 0;
        private int breakfast = 0;
        private int fruits = 0;
        private int soda = 0;

        private int h = 0, m = 0, s = 0;

        private int level = 1;

        public ИМиКН()
        {
            InitializeComponent();

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;

            //Music.pl4.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (book < 5)
                {
                    book++;
                    label1.Text = $"Кол-во книг: {book}";
                }
                else if (book == 5) MessageBox.Show("Вы набрали нужное количество книг!");
            }

            else if (level == 2)
            {
                if (laptop < 20)
                {
                    laptop++;
                    label1.Text = $"Кол-во ноутбуков: {laptop}";
                }
                else if (laptop == 20) MessageBox.Show("Вы набрали нужное количество ноутбуков!");
            }

            else if (level == 3)
            {
                if (book < 30)
                {
                    book++;
                    label1.Text = $"Кол-во книг: {book}";
                }
                else if (book == 30) MessageBox.Show("Вы набрали нужное количество книг!");
            }

            else if (level == 4)
            {
                if (calculator < 50)
                {
                    calculator++;
                    label1.Text = $"Кол-во калькуляторов: {calculator}";
                }
                else if (calculator == 50) MessageBox.Show("Вы набрали нужное количество калькуляторов!");
            }

            else if (level == 5)
            {
                if (book < 70)
                {
                    book++;
                    label1.Text = $"Кол-во книг: {book}";
                }
                else if (book == 70) MessageBox.Show("Вы набрали нужное количество книг!");
            }

            else if (level == 6)
            {
                if (book < 100)
                {
                    book++;
                    label1.Text = $"Кол-во книг: {book}";
                }
                else if (book == 100) MessageBox.Show("Вы набрали нужное количество книг!");
            }

            else if (level == 7)
            {
                if (ball < 150)
                {
                    ball++;
                    label1.Text = $"Кол-во мячей: {ball}";
                }
                else if (ball == 150) MessageBox.Show("Вы набрали нужное количество мячей!");
            }

            else if (level == 8)
            {
                if (breakfast < 80)
                {
                    breakfast++;
                    label1.Text = $"Кол-во завтраков: {breakfast}";
                }
                else if (breakfast == 80) MessageBox.Show("Вы набрали нужное количество завтраков!");
            }

            else if (level == 9)
            {
                if (book < 150)
                {
                    book++;
                    label1.Text = $"Кол-во книг: {book}";
                }
                else if (book == 150) MessageBox.Show("Вы набрали нужное количество книг!");
            }

            else if (level == 10)
            {
                if (laptop < 250)
                {
                    laptop++;
                    label1.Text = $"Кол-во ноутбуков: {laptop}";
                }
                else if (laptop == 250) MessageBox.Show("Вы набрали нужное количество ноутбуков!");
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (sheet < 10)
                {
                    sheet++;
                    label2.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 10) MessageBox.Show("Вы набрали нужное количество листов!");
            }

            else if (level == 2)
            {
                if (brain < 30)
                {
                    brain++;
                    label2.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 30) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }

            else if (level == 3)
            {
                if (sheet < 40)
                {
                    sheet++;
                    label2.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 40) MessageBox.Show("Вы набрали нужное количество листов!");
            }

            else if (level == 4)
            {
                if (sheet < 60)
                {
                    sheet++;
                    label2.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 60) MessageBox.Show("Вы набрали нужное количество листов!");
            }

            else if (level == 5)
            {
                if (laptop < 80)
                {
                    laptop++;
                    label2.Text = $"Кол-во ноутбуков: {laptop}";
                }
                else if (laptop == 80) MessageBox.Show("Вы набрали нужное количество ноутбуков!");
            }

            else if (level == 6)
            {
                if (sheet < 120)
                {
                    sheet++;
                    label2.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 120) MessageBox.Show("Вы набрали нужное количество листов!");
            }

            else if (level == 7)
            {
                if (athlete < 90)
                {
                    athlete++;
                    label2.Text = $"Кол-во спортсменов: {athlete}";
                }
                else if (athlete == 90) MessageBox.Show("Вы набрали нужное количество спортсменов!");
            }

            else if (level == 8)
            {
                if (fruits < 40)
                {
                    fruits++;
                    label2.Text = $"Кол-во фруктов: {fruits}";
                }
                else if (fruits == 40) MessageBox.Show("Вы набрали нужное количество фруктов!");
            }

            else if (level == 9)
            {
                if (laptop < 200)
                {
                    laptop++;
                    label2.Text = $"Кол-во ноутбуков: {laptop}";
                }
                else if (laptop == 200) MessageBox.Show("Вы набрали нужное количество ноутбуков!");
            }

            else if (level == 10)
            {
                if (sheet < 200)
                {
                    sheet++;
                    label2.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 200) MessageBox.Show("Вы набрали нужное количество листов!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (printer < 1)
                {
                    printer++;
                    label3.Text = $"Кол-во принтеров: {printer}";
                }
                else if (printer == 1) MessageBox.Show("Вы набрали нужное количество принтеров!");
            }

            else if (level == 2)
            {
                if (pencil < 10)
                {
                    pencil++;
                    label3.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 10) MessageBox.Show("Вы набрали нужное количество карандашей!");
            }

            else if (level == 4)
            {
                if (pencil < 40)
                {
                    pencil++;
                    label3.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 40) MessageBox.Show("Вы набрали нужное количество карандашей!");
            }

            else if (level == 6)
            {
                if (pencil < 80)
                {
                    pencil++;
                    label3.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 80) MessageBox.Show("Вы набрали нужное количество карандашей!");
            }

            else if (level == 7)
            {
                if (dumbbells < 30)
                {
                    dumbbells++;
                    label3.Text = $"Кол-во гантелей: {dumbbells}";
                }
                else if (dumbbells == 30) MessageBox.Show("Вы набрали нужное количество гантелей!");
            }

            else if (level == 8)
            {
                if (soda < 90)
                {
                    soda++;
                    label3.Text = $"Кол-во газировки: {soda}";
                }
                else if (soda == 90) MessageBox.Show("Вы набрали нужное количество газировки!");
            }

            else if (level == 9)
            {
                if (printer < 60)
                {
                    printer++;
                    label3.Text = $"Кол-во принтеров: {printer}";
                }
                else if (printer == 60) MessageBox.Show("Вы набрали нужное количество принтеров!");
            }

            else if (level == 10)
            {
                if (pencil < 190)
                {
                    pencil++;
                    label3.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 190) MessageBox.Show("Вы набрали нужное количество карандашей!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (level == 6)
            {
                if (brain < 90)
                {
                    brain++;
                    label9.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 90) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }

            else if (level == 9)
            {
                if (brain < 160)
                {
                    brain++;
                    label9.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 160) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }

            else if (level == 10)
            {
                if (brain < 300)
                {
                    brain++;
                    label9.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 300) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                h = 0; m = 0; s = 10;
                book = 0; sheet = 0; printer = 0;
                label1.Text = $"Кол-во книг: {book}";
                label2.Text = $"Кол-во листов: {sheet}";
                label3.Text = $"Кол-во принтеров: {printer}";
            }

            else if (level == 2)
            {
                h = 0; m = 0; s = 30;
                laptop = 0; brain = 0; pencil = 0;
                label1.Text = $"Кол-во ноутбуков: {laptop}";
                label2.Text = $"Кол-во мозгов: {brain}";
                label3.Text = $"Кол-во карандашей: {pencil}";
            }

            else if (level == 3)
            {
                h = 0; m = 0; s = 30;
                book = 0; sheet = 0;
                label1.Text = $"Кол-во книг: {book}";
                label2.Text = $"Кол-во листов: {sheet}";
                label3.Text = $"";
            }

            else if (level == 4)
            {
                h = 0; m = 0; s = 50;
                calculator = 0; sheet = 0; pencil = 0;
                label1.Text = $"Кол-во калькуляторов: {calculator}";
                label2.Text = $"Кол-во листов: {sheet}";
                label3.Text = $"Кол-во карандашей: {pencil}";
            }

            else if (level == 5)
            {
                h = 0; m = 0; s = 50;
                book = 0; laptop = 0;
                label1.Text = $"Кол-во книг: {book}";
                label2.Text = $"Кол-во ноутбуков: {laptop}";
                label3.Text = $"";
            }

            else if (level == 6)
            {
                h = 0; m = 1; s = 40;
                book = 0; sheet = 0; pencil = 0; brain = 0;
                label1.Text = $"Кол-во книг: {book}";
                label2.Text = $"Кол-во листов: {sheet}";
                label3.Text = $"Кол-во карандашей: {pencil}";
                label9.Text = $"Кол-во мозгов: {brain}";
            }

            else if (level == 7)
            {
                h = 0; m = 2; s = 30;
                ball = 0; athlete = 0; dumbbells = 0;
                label1.Text = $"Кол-во мячей: {ball}";
                label2.Text = $"Кол-во спортсменов: {athlete}";
                label3.Text = $"Кол-во гантелей: {dumbbells}";
            }

            else if (level == 8)
            {
                h = 0; m = 1; s = 40;
                breakfast = 0; fruits = 0; soda = 0;
                label1.Text = $"Кол-во завтраков: {breakfast}";
                label2.Text = $"Кол-во фруктов: {fruits}";
                label3.Text = $"Кол-во газировки: {soda}";
            }

            else if (level == 9)
            {
                h = 0; m = 2; s = 50;
                book = 0; laptop = 0; printer = 0; brain = 0;
                label1.Text = $"Кол-во книг: {book}";
                label2.Text = $"Кол-во ноутбуков: {laptop}";
                label3.Text = $"Кол-во принтеров: {printer}";
                label9.Text = $"Кол-во мозгов: {brain}";
            }

            else if (level == 10)
            {
                h = 0; m = 3; s = 20;
                laptop = 0; sheet = 0; pencil = 0; brain = 0;
                label1.Text = $"Кол-во ноутбуков: {laptop}";
                label2.Text = $"Кол-во листов: {sheet}";
                label3.Text = $"Кол-во карандашей: {pencil}";
                label9.Text = $"Кол-во мозгов: {brain}";
            }

            timer1.Start();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Music.pl4.Stop();
            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите выйти?",
                                                  "Выход",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information,
                                                  MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                Hide();
                Map map = new Map();
                map.ShowDialog();
            }
            if (dialogResult == DialogResult.No)
            {
                //Music.pl4.Play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s -= 1;
            if(s == -1)
            {
                m -= 1;
                s = 59;
            }
            if(m == -1)
            {
                h -= 1;
                m = 59;
            }

            if (level == 1)
            {
                if ((book == 5 && sheet == 10 && printer == 1) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; sheet = 0; printer = 0;
                        h = 0; m = 0; s = 0;
                        level = 2;
                        label1.Text = $"Кол-во ноутбуков: {laptop}";
                        label2.Text = $"Кол-во мозгов: {brain}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                        richTextBox1.Text = "Сделать лабораторную работу по информатике:\n20 ноутбуков\n30 мозгов\n10 карандашей\nУ вас есть 30 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка ноутбук.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка карандаш.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: книг {book}, листов {sheet}, принтеров {printer}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; sheet = 0; printer = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во книг: {book}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во принтеров: {printer}";
                    }
                }
            }

            else if (level == 2)
            {
                if ((laptop == 20 && brain == 30 && pencil ==10) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        laptop = 0; brain = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        level = 3;
                        label1.Text = $"Кол-во книг: {book}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"";
                        richTextBox1.Text = "Придти и прослушать лекцию по программированию:\n30 книг\n40 листов\nУ вас есть 30 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка книги2.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                        button3.Visible = false;
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: ноутбуков {laptop}, мозгов {brain}, карандашей {pencil}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        laptop = 0; brain = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во ноутбуков: {laptop}";
                        label2.Text = $"Кол-во мозгов: {brain}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                    }
                }
            }

            else if (level == 3)
            {
                if ((book == 30 && sheet == 40) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; sheet = 0;
                        h = 0; m = 0; s = 0;
                        level = 4;
                        label1.Text = $"Кол-во калькуляторов: {calculator}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                        richTextBox1.Text = "Решить задачу по дискретной математике:\n50 калькуляторов\n60 листов\n40 карандашей\nУ вас есть 30 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка калькулятор.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                        button3.Visible = true;
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка карандаш.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: книг {book}, листов {sheet}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; sheet = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во книг: {book}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"";
                    }
                }
            }

            else if (level == 4)
            {
                if ((calculator == 50 && sheet == 60 && pencil == 40) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        calculator = 0; sheet = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        level = 5;
                        label1.Text = $"Кол-во книг: {book}";
                        label2.Text = $"Кол-во ноутбуков: {laptop}";
                        label3.Text = $"";
                        richTextBox1.Text = "Сделать практику по компьютерной безопасности:\n70 книг\n80 ноутбуков\nУ вас есть 50 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка книги2.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка ноутбук.png");
                        button3.Visible = false;
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: калькуляторов {calculator}, листов {sheet}, карандашей {pencil}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        calculator = 0; sheet = 0; pencil = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во калькуляторов: {calculator}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                    }
                }
            }

            else if (level == 5)
            {
                if ((book == 70 && laptop == 80) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; laptop = 0;
                        h = 0; m = 0; s = 0;
                        level = 6;
                        label1.Text = $"Кол-во книг: {book}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                        label9.Text = $"Кол-во мозгов: {brain}";
                        richTextBox1.Text = "Написать контрольную по базам данных:\n100 книг\n120 листов\n80 карандашей\n90 мозгов\nУ вас есть 1 минута и 40 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка книги2.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                        button3.Visible = true;
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка карандаш.png");
                        button5.Visible = true;
                        button5.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: книг {book}, ноутбуков {laptop}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; laptop = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во книг: {book}";
                        label2.Text = $"Кол-во ноутбуков: {laptop}";
                        label3.Text = $"";
                    }
                }
            }

            else if (level == 6)
            {
                if ((book == 100 && sheet == 120 && pencil == 80 && brain == 90) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; sheet = 0;  pencil = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        level = 7;
                        label1.Text = $"Кол-во мячей: {ball}";
                        label2.Text = $"Кол-во спортсменов: {athlete}";
                        label3.Text = $"Кол-во гантелей: {dumbbells}";
                        label9.Text = $"";
                        richTextBox1.Text = "Пора позаниматься спортом, пара физкультуры:\n150 мячей\n90 спортсменов\n30 гантелей\nУ вас есть 2 минута и 30 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мяч.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка спортсмен.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка гантели.png");
                        button5.Visible = false;
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: книг {book}, листов {sheet}, карандашей {pencil}, мозгов {brain}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; sheet = 0; pencil = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во книг: {book}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                        label9.Text = $"Кол-во мозгов: {brain}";
                    }
                }
            }

            else if (level == 7)
            {
                if ((ball == 150 && athlete == 90 && dumbbells == 30) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        ball = 0; athlete = 0; dumbbells = 0;
                        h = 0; m = 0; s = 0;
                        level = 8;
                        label1.Text = $"Кол-во завтраков: {breakfast}";
                        label2.Text = $"Кол-во фруктов: {fruits}";
                        label3.Text = $"Кол-во газировки: {soda}";
                        label9.Text = $"";
                        richTextBox1.Text = "После успешной тренировки, нужно подкрепиться:\n80 завтраков\n40 фруктов\n90 газировки\nУ вас есть 1 минута и 40 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка завтрак.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка фрукты.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка газировка.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: мячей {ball}, спортсменов {athlete}, гантелей {dumbbells}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        ball = 0; athlete = 0; dumbbells = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во мячей: {ball}";
                        label2.Text = $"Кол-во спортсменов: {athlete}";
                        label3.Text = $"Кол-во гантелей: {dumbbells}";
                        label9.Text = $"";
                    }
                }
            }

            else if (level == 8)
            {
                if ((breakfast == 80 && fruits == 40 && soda == 90) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        breakfast = 0; fruits = 0; soda = 0;
                        h = 0; m = 0; s = 0;
                        level = 9;
                        label1.Text = $"Кол-во книг: {book}";
                        label2.Text = $"Кол-во ноутбуков: {laptop}";
                        label3.Text = $"Кол-во принтеров: {printer}";
                        label9.Text = $"Кол-во мозгов: {brain}";
                        richTextBox1.Text = "Нужно подготовить презентация по информационным системам:\n150 книг\n200 ноутбуков\n60 принтеров\n160 мозгов\nУ вас есть 2 минута и 50 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка книги2.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка ноутбук.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка принтер.png");
                        button5.Visible = true;
                        button5.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: завтраков {breakfast}, фруктов {fruits}, газировки {soda}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        breakfast = 0; fruits = 0; soda = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во завтраков: {breakfast}";
                        label2.Text = $"Кол-во фруктов: {fruits}";
                        label3.Text = $"Кол-во газировки: {soda}";
                        label9.Text = $"";
                    }
                }
            }

            else if (level == 9)
            {
                if ((book == 150 && laptop == 200 && printer == 60 && brain == 160) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; laptop = 0; printer = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        level = 10;
                        label1.Text = $"Кол-во ноутбуков: {laptop}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                        label9.Text = $"Кол-во мозгов: {brain}";
                        richTextBox1.Text = "Сдать зачет по программированию:\n250 ноутбуков\n200 листов\n190 карандашей\n300 мозгов\nУ вас есть 3 минута и 20 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка ноутбук.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка карандаш.png");
                        button5.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: книг {book}, ноутбуков {laptop}, принтеров {printer}, мозгов {brain}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        book = 0; laptop = 0; printer = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во книг: {book}";
                        label2.Text = $"Кол-во ноутбуков: {laptop}";
                        label3.Text = $"Кол-во принтеров: {printer}";
                        label9.Text = $"Кол-во мозгов: {brain}";
                    }
                }
            }

            else if (level == 10)
            {
                if ((laptop == 250 && sheet == 200 && pencil == 190 && brain == 300) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Институт пройден!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        laptop = 0; sheet = 0; pencil = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        level = 1;
                        label1.Text = $"";
                        label2.Text = $"";
                        label3.Text = $"";
                        label9.Text = $"";
                        richTextBox1.Text = "Институт пройден !!!";
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button5.Visible = false;
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: ноутбуков {laptop}, листов {sheet}, карандашей {pencil}, мозгов {brain}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        laptop = 0; sheet = 0; pencil = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во ноутбуков: {laptop}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во карандашей: {pencil}";
                        label9.Text = $"Кол-во мозгов: {brain}";
                    }
                }
            }

            label4.Text = Convert.ToString(h);
            label5.Text = Convert.ToString(m);
            label6.Text = Convert.ToString(s);
        }
    }
}
