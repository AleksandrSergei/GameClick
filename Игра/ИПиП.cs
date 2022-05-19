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
    public partial class ИПиП : Form
    {
        private int book = 0;
        private int sheet = 0;
        private int pencil = 0;
        private int brain = 0;
        private int students = 0;
        private int teacher = 0;
        private int notebook = 0;
        private int bell = 0;
        private int head = 0;
        private int breakfast = 0;
        private int fruits = 0;
        private int soda = 0;
        private int h = 0, m = 0, s = 0;

        private int level = 1;

        public ИПиП()
        {
            InitializeComponent();

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (breakfast < 15)
                {
                    breakfast++;
                    label1.Text = $"Кол-во завтраков: {breakfast}";
                }
                else if (breakfast == 15) MessageBox.Show("Вы набрали нужное количество завтраков!");
            }

            else if (level == 2)
            {
                if (bell < 20)
                {
                    bell++;
                    label1.Text = $"Кол-во звонков: {bell}";
                }
                else if (bell == 20) MessageBox.Show("Вы набрали нужное количество звонков!");
            }

            else if (level == 3)
            {
                if (notebook < 40)
                {
                    notebook++;
                    label1.Text = $"Кол-во тетрадей: {notebook}";
                }
                else if (notebook == 40) MessageBox.Show("Вы набрали нужное количество тетрадей!");
            }

            else if (level == 4)
            {
                if (head < 70)
                {
                    head++;
                    label1.Text = $"Кол-во голова: {head}";
                }
                else if (head == 70) MessageBox.Show("Вы набрали нужное количество голова!");
            }

            else if (level == 5)
            {
                if (notebook < 100)
                {
                    notebook++;
                    label1.Text = $"Кол-во тетрадей: {notebook}";
                }
                else if (notebook == 100) MessageBox.Show("Вы набрали нужное количество тетрадей!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (fruits < 10)
                {
                    fruits++;
                    label2.Text = $"Кол-во фруктов: {fruits}";
                }
                else if (fruits == 10) MessageBox.Show("Вы набрали нужное количество фруктов!");
            }

            else if (level == 2)
            {
                if (pencil < 15)
                {
                    pencil++;
                    label2.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 15) MessageBox.Show("Вы набрали нужное количество карандашей!");
            }

            else if (level == 3)
            {
                if (sheet < 30)
                {
                    sheet++;
                    label2.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 30) MessageBox.Show("Вы набрали нужное количество листов!");
            }

            else if (level == 4)
            {
                if (book < 30)
                {
                    book++;
                    label2.Text = $"Кол-во книг: {book}";
                }
                else if (book == 30) MessageBox.Show("Вы набрали нужное количество книг!");
            }

            else if (level == 5)
            {
                if (sheet < 100)
                {
                    sheet++;
                    label2.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 100) MessageBox.Show("Вы набрали нужное количество листов!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (soda < 5)
                {
                    soda++;
                    label3.Text = $"Кол-во газировок: {soda}";
                }
                else if (soda == 5) MessageBox.Show("Вы набрали нужное количество газировок!");
            }

            else if (level == 2)
            {
                if (teacher < 25)
                {
                    teacher++;
                    label3.Text = $"Кол-во учителей: {teacher}";
                }
                else if (teacher == 25) MessageBox.Show("Вы набрали нужное количество усителей!");
            }

            else if (level == 3)
            {
                if (students < 20)
                {
                    students++;
                    label3.Text = $"Кол-во учеников: {students}";
                }
                else if (students == 20) MessageBox.Show("Вы набрали нужное количество учеников!");
            }

            else if (level == 4)
            {
                if (brain < 50)
                {
                    brain++;
                    label3.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 50) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }

            else if (level == 5)
            {
                if (brain < 70)
                {
                    brain++;
                    label3.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 70) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                h = 0; m = 0; s = 10;
                breakfast = 0; fruits = 0; soda = 0;
                label1.Text = $"Кол-во завтраков: {breakfast}";
                label2.Text = $"Кол-во фруктов: {fruits}";
                label3.Text = $"Кол-во газировок: {soda}";
            }

            else if (level == 2)
            {
                h = 0; m = 0; s = 20;
                bell = 0; pencil = 0; teacher = 0;
                label1.Text = $"Кол-во звонков: {bell}";
                label2.Text = $"Кол-во карандашей: {pencil}";
                label3.Text = $"Кол-во учителей: {teacher}";
            }

            else if (level == 3)
            {
                h = 0; m = 0; s = 30;
                notebook = 0; sheet = 0; students = 0;
                label1.Text = $"Кол-во тетрадей: {notebook}";
                label2.Text = $"Кол-во листов: {sheet}";
                label3.Text = $"Кол-во учеников: {students}";
            }

            else if (level == 4)
            {
                h = 0; m = 0; s = 50;
                head = 0; book = 0; brain = 0;
                label1.Text = $"Кол-во голов: {head}";
                label2.Text = $"Кол-во книг: {book}";
                label3.Text = $"Кол-во мозгов: {brain}";
            }

            else if (level == 5)
            {
                h = 0; m = 1; s = 30;
                notebook = 0; sheet = 0; brain = 0;
                label1.Text = $"Кол-во тетрадей: {notebook}";
                label2.Text = $"Кол-во листов: {sheet}";
                label3.Text = $"Кол-во мозгов: {brain}";
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s -= 1;
            if (s == -1)
            {
                m -= 1;
                s = 59;
            }
            if (m == -1)
            {
                h -= 1;
                m = 59;
            }

            if (level == 1)
            {
                if ((breakfast == 15 && fruits == 10 && soda == 5) && (s > 0 || h > 0 || m > 0))
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
                        level = 2;
                        label1.Text = $"Кол-во звонков: {bell}";
                        label2.Text = $"Кол-во карандашей: {pencil}";
                        label3.Text = $"Кол-во учителей: {teacher}";
                        richTextBox1.Text = "Лекция по начальному образованию:\n20 звонков\n15 карандашей\n25 учителей\nУ вас есть 20 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка звонок.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка карандаш.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка учитель.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: завтраков {breakfast}, фруктоа {fruits}, газировок {soda}.",
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
                        label3.Text = $"Кол-во газировок: {soda}";
                    }
                }
            }

            else if (level == 2)
            {
                if ((bell == 20 && pencil == 15 && teacher == 25) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        bell = 0; pencil = 0; teacher = 0;
                        h = 0; m = 0; s = 0;
                        level = 3;
                        label1.Text = $"Кол-во тетрадей: {notebook}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во учеников: {students}";
                        richTextBox1.Text = "Презентация на тему 'Педагогическое образование':\n40 тетрадей\n30 листов\n20 учеников\nУ вас есть 30 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка тетрадь.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка ученики.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: звонков {bell}, карандашей {pencil}, учителей {teacher}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        bell = 0; pencil = 0; teacher = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во звонков: {bell}";
                        label2.Text = $"Кол-во карандашей: {pencil}";
                        label3.Text = $"Кол-во учителей: {teacher}";
                    }
                }
            }

            else if (level == 3)
            {
                if ((notebook == 40 && sheet == 30 && students == 20) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        notebook = 0; sheet = 0; students = 0;
                        h = 0; m = 0; s = 0;
                        level = 4;
                        label1.Text = $"Кол-во голов: {head}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во мозгов: {brain}";
                        richTextBox1.Text = "Практика по психологии:\n70 голов\n30 книг\n50 мозгов\nУ вас есть 50 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка голова.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка книги2.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: тетрадей {notebook}, листов {sheet}, учеников {students}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        notebook = 0; sheet = 0; students = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во тетрадей: {notebook}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во учеников: {students}";
                    }
                }
            }

            else if (level == 4)
            {
                if ((head == 70 && book == 30 && brain == 50) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        head = 0; book = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        level = 5;
                        label1.Text = $"Кол-во тетрадей: {notebook}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во мозгов: {brain}";
                        richTextBox1.Text = "Сдать зачет по социальной психологии:\n100 тетрадей\n100 листов\n70 мозгов\nУ вас есть 1 минута 30 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка тетрадь.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: карт {head}, мозгов {book}, глобусов {brain}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        head = 0; book = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во голов: {head}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во мозгов: {brain}";
                    }
                }
            }

            else if (level == 5)
            {
                if ((notebook == 100 && sheet == 100 && brain == 70) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Институт пройден!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        notebook = 0; sheet = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        level = 1;
                        label1.Text = $"";
                        label2.Text = $"";
                        label3.Text = $"";
                        richTextBox1.Text = "Институт пройден !!!";
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: тетрадей {notebook}, листов {sheet}, мозгов {brain}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        notebook = 0; sheet = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во тетрадей: {notebook}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во мозгов: {brain}";
                    }
                }
            }

            label4.Text = Convert.ToString(h);
            label5.Text = Convert.ToString(m);
            label6.Text = Convert.ToString(s);
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

    }
}
