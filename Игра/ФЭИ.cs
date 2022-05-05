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
        private int book = 0;
        private int sheet = 0;
        private int pencil = 0;
        private int brain = 0;
        private int human = 0;
        private int coin = 0;
        private int bankcard = 0;
        private int calculator = 0;
        private int statistics = 0;
        private int ball = 0;
        private int athlete = 0;
        private int dumbbells = 0;
        private int h = 0, m = 0, s = 0;

        private int level = 1;
        public ФЭИ()
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
                if (human < 100)
                {
                    human++;
                    label1.Text = $"Кол-во человек: {human}";
                }
                else if (human == 100) MessageBox.Show("Вы набрали нужное количесвто человек!");
            }

            else if (level == 2)
            {
                if (coin < 300)
                {
                    coin++;
                    label1.Text = $"Кол-во монет: {coin}";
                }
                else if (coin == 300) MessageBox.Show("Вы набрали нужное количество монет!");
            }

            else if (level == 3)
            {
                if (bankcard < 250)
                {
                    bankcard++;
                    label1.Text = $"Кол-во карт: {bankcard}";
                }
                else if (bankcard == 250) MessageBox.Show("Вы набрали нужное количество карт!");
            }

            else if (level == 4)
            {
                if (ball < 400)
                {
                    ball++;
                    label1.Text = $"Кол-во мячей: {ball}";
                }
                else if (ball == 400) MessageBox.Show("Вы набрали нужное количество мячей!");
            }

            else if (level == 5)
            {
                if (statistics < 500)
                {
                    statistics++;
                    label1.Text = $"Кол-во статистик: {statistics}";
                }
                else if (statistics == 500) MessageBox.Show("Вы набрали нужное количество статистик!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (book < 70)
                {
                    book++;
                    label2.Text = $"Кол-во книг: {book}";
                }
                else if (book == 70) MessageBox.Show("Вы набрали нужное количесвто книг!");
            }

            else if (level == 2)
            {
                if (sheet < 100)
                {
                    sheet++;
                    label2.Text = $"Кол-во листов: {sheet}";
                }
                else if (sheet == 100) MessageBox.Show("Вы набрали нужное количество листов!");
            }

            else if (level == 3)
            {
                if (pencil < 250)
                {
                    pencil++;
                    label2.Text = $"Кол-во карандашей: {pencil}";
                }
                else if (pencil == 250) MessageBox.Show("Вы набрали нужное количество карандашей!");
            }

            else if (level == 4)
            {
                if (athlete < 400)
                {
                    athlete++;
                    label2.Text = $"Кол-во спортсменов: {athlete}";
                }
                else if (athlete == 400) MessageBox.Show("Вы набрали нужное количество спортсменов!");
            }

            else if (level == 5)
            {
                if (book < 350)
                {
                    book++;
                    label2.Text = $"Кол-во книг: {book}";
                }
                else if (book == 350) MessageBox.Show("Вы набрали нужное количество книг!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                if (brain < 80)
                {
                    brain++;
                    label3.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 80) MessageBox.Show("Вы набрали нужное количесвто мозгов!");
            }

            else if (level == 2)
            {
                if (brain < 100)
                {
                    brain++;
                    label3.Text = $"Кол-во мозгов: {brain}";
                }
                else if (brain == 100) MessageBox.Show("Вы набрали нужное количество мозгов!");
            }

            else if (level == 3)
            {
                if (calculator < 250)
                {
                    calculator++;
                    label3.Text = $"Кол-во калькуляторов: {calculator}";
                }
                else if (calculator == 250) MessageBox.Show("Вы набрали нужное количество калькуляторов!");
            }

            else if (level == 4)
            {
                if (dumbbells < 200)
                {
                    dumbbells++;
                    label3.Text = $"Кол-во гантелей: {dumbbells}";
                }
                else if (dumbbells == 200) MessageBox.Show("Вы набрали нужное количество гантелей!");
            }

            else if (level == 5)
            {
                if (calculator < 400)
                {
                    calculator++;
                    label3.Text = $"Кол-во калькуляторов: {calculator}";
                }
                else if (calculator == 400) MessageBox.Show("Вы набрали нужное количество калькуляторов!");
            }
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
                if ((human == 100 && book == 70 && brain == 80) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        human = 0; book = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        level = 2;
                        label1.Text = $"Кол-во монет: {coin}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во мозгов: {brain}";
                        richTextBox1.Text = "Практика по экономической безопасности:\n300 монет\n100 листов\n100 мозгов\nУ вас есть 1 минута 40 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка монета.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка лист2.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мозг.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: человек {human}, книг {book}, мозгов {brain}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        human = 0; book = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во челове: {human}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во мозгов: {brain}";
                    }
                }
            }

            else if (level == 2)
            {
                if ((coin == 300 && sheet == 100 && brain == 100) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        coin = 0; sheet = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        level = 3;
                        label1.Text = $"Кол-во карт: {bankcard}";
                        label2.Text = $"Кол-во карандашей: {pencil}";
                        label3.Text = $"Кол-во калькулятор: {calculator}";
                        richTextBox1.Text = "Сходить на лекцию по экономике:\n250 карт\n250 карандашей\n250 калькуляторов\nУ вас есть 2 минута 30 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка банк карта.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка карандаш.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка калькулятор.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: монет {brain}, листов {sheet}, мозгов {brain}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        coin = 0; sheet = 0; brain = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во монет: {coin}";
                        label2.Text = $"Кол-во листов: {sheet}";
                        label3.Text = $"Кол-во мозгов: {brain}";
                    }
                }
            }

            else if (level == 3)
            {
                if ((bankcard == 250 && pencil == 250 && calculator == 250) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Уровень пройден",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        bankcard = 0; pencil = 0; calculator = 0;
                        h = 0; m = 0; s = 0;
                        level = 4;
                        label1.Text = $"Кол-во мячей: {ball}";
                        label2.Text = $"Кол-во спортсменов: {athlete}";
                        label3.Text = $"Кол-во гантель: {dumbbells}";
                        richTextBox1.Text = "Позаниматься физукультурой:\n400 мячей\n400 спортсменов\n200 гантелей\nУ вас есть 3 минуты 20 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка мяч.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка спортсмен.png");
                        button3.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка гантели.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: карт {bankcard}, карандашей {pencil}, калькуляторов {calculator}.",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        bankcard = 0; pencil = 0; calculator = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во карт: {bankcard}";
                        label2.Text = $"Кол-во карандашей: {pencil}";
                        label3.Text = $"Кол-во калькулятор: {calculator}";
                    }
                }
            }

            else if (level == 4)
            {
                if ((ball == 400 && athlete == 400 && dumbbells == 200) && (s > 0 || h > 0 || m > 0))
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
                        level = 5;
                        label1.Text = $"Кол-во статистик: {statistics}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во калькуляторов: {calculator}";
                        richTextBox1.Text = "Контрольная по маркетингу:\n500 статистик\n350 книг\n400 калькуляторов\nУ вас есть 4 минуты 10 секунд!";
                        button1.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка статистика.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка книги2.png");
                        button2.Image = Image.FromFile("C:\\Users\\Александр\\Desktop\\Игра\\Игра\\bin\\Debug\\фотки\\кнопка калькулятор.png");
                    }
                }
                else if (h == 0 && m == 0 && s == 0)
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: мячей {ball}, спортсменов {athlete},гантелей {dumbbells}.",
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
                        label3.Text = $"Кол-во гантель: {dumbbells}";
                    }
                }
            }

            else if (level == 5)
            {
                if ((statistics == 500 && book == 350 && calculator == 400) && (s > 0 || h > 0 || m > 0))
                {
                    timer1.Stop();
                    DialogResult dialog = MessageBox.Show($"Поздравляю! Вы справились.",
                                                      "Институт пройден!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        statistics = 0; book = 0; calculator = 0;
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
                    DialogResult dialog = MessageBox.Show($"Ваш результат: Кол-во: статистик {statistics}, книг {book}, калькуляторов {calculator}",
                                                      "Время вышло",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.OK)
                    {
                        statistics = 0; book = 0; calculator = 0;
                        h = 0; m = 0; s = 0;
                        label1.Text = $"Кол-во статистик: {statistics}";
                        label2.Text = $"Кол-во книг: {book}";
                        label3.Text = $"Кол-во калькуляторов: {calculator}";
                    }
                }
            }

            label4.Text = Convert.ToString(h);
            label5.Text = Convert.ToString(m);
            label6.Text = Convert.ToString(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                h = 0; m = 0; s = 50;
                human = 0; book = 0; brain = 0;
                label1.Text = $"Кол-во челове: {human}";
                label2.Text = $"Кол-во книг: {book}";
                label3.Text = $"Кол-во мозгов: {brain}";
            }

            else if (level == 2)
            {
                h = 0; m = 1; s = 40;
                coin = 0; sheet = 0; brain = 0;
                label1.Text = $"Кол-во монет: {coin}";
                label2.Text = $"Кол-во листов: {sheet}";
                label3.Text = $"Кол-во мозгов: {brain}";
            }

            else if (level == 3)
            {
                h = 0; m = 2; s = 30;
                bankcard = 0; pencil = 0; calculator = 0;
                label1.Text = $"Кол-во карт: {bankcard}";
                label2.Text = $"Кол-во карандашей: {pencil}";
                label3.Text = $"Кол-во калькулятор: {calculator}";
            }

            else if (level == 4)
            {
                h = 0; m = 3; s = 20;
                ball = 0; athlete = 0; dumbbells = 0;
                label1.Text = $"Кол-во мячей: {ball}";
                label2.Text = $"Кол-во спортсменов: {athlete}";
                label3.Text = $"Кол-во гантелей: {dumbbells}";
            }

            else if (level == 5)
            {
                h = 0; m = 4; s = 10;
                statistics = 0; book = 0; calculator = 0;
                label1.Text = $"Кол-во статистик: {statistics}";
                label2.Text = $"Кол-во книг: {book}";
                label3.Text = $"Кол-во калькуляторов: {calculator}";
            }

            timer1.Start();
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
