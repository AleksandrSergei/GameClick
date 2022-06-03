using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Игра
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            Music.pl2.Play();
            this.Load += new EventHandler(Form1_Load);
            label1.Text = Statistics.number_clicks.ToString();
            pictureBox3.Image = Image.FromFile(Button_image_map.Image_IMiKN);
            pictureBox3.Enabled = Button_image_map.Image_IMiKN_Enabled;
            pictureBox2.Image = Image.FromFile(Button_image_map.Image_IGiP);
            pictureBox2.Enabled = Button_image_map.Image_IGiP_Enabled;
            pictureBox4.Image = Image.FromFile(Button_image_map.Image_InBio);
            pictureBox4.Enabled = Button_image_map.Image_InBio_Enabled;
            pictureBox5.Image = Image.FromFile(Button_image_map.Image_InZem);
            pictureBox5.Enabled = Button_image_map.Image_InZem_Enabled;
            pictureBox7.Image = Image.FromFile(Button_image_map.Image_IPiP);
            pictureBox7.Enabled = Button_image_map.Image_IPiP_Enabled;
            pictureBox8.Image = Image.FromFile(Button_image_map.Image_IFK);
            pictureBox8.Enabled = Button_image_map.Image_IFK_Enabled;
            pictureBox10.Image = Image.FromFile(Button_image_map.Image_FizTech);
            pictureBox10.Enabled = Button_image_map.Image_FizTech_Enabled;
            pictureBox11.Image = Image.FromFile(Button_image_map.Image_FEI);
            pictureBox11.Enabled = Button_image_map.Image_FEI_Enabled;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 3, 88, 90);
            Region rgn = new Region(path);
            pictureBox2.Region = rgn;
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Region = rgn;
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox4.Region = rgn;
            pictureBox4.BackColor = SystemColors.ActiveCaption;
            pictureBox5.Region = rgn;
            pictureBox5.BackColor = SystemColors.ActiveCaption;
            pictureBox7.Region = rgn;
            pictureBox7.BackColor = SystemColors.ActiveCaption;
            pictureBox8.Region = rgn;
            pictureBox8.BackColor = SystemColors.ActiveCaption;
            pictureBox10.Region = rgn;
            pictureBox10.BackColor = SystemColors.ActiveCaption;
            pictureBox11.Region = rgn;
            pictureBox11.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hide();
            Music.pl2.Stop();
            ИМиКН иМиКН = new ИМиКН();
            иМиКН.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Music.pl2.Stop();
            Game game = new Game();
            game.ShowDialog();
            Close();
        }

        public void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Hide();
            Music.pl2.Stop();
            ИнБио инБио = new ИнБио();
            инБио.ShowDialog();
            Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Hide();
            Music.pl2.Stop();
            ФЭИ фэи = new ФЭИ();
            фэи.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Hide();
            Music.pl2.Stop();
            ФизТех физТех = new ФизТех();
            физТех.ShowDialog();
            Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Hide();
            Music.pl2.Stop();
            ИФК иФК = new ИФК();
            иФК.ShowDialog();
            Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Hide();
            Music.pl2.Stop();
            ИПиП иПиП = new ИПиП();
            иПиП.ShowDialog();
            Close();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Hide();
            Music.pl2.Stop();
            ИнЗем инЗем = new ИнЗем();
            инЗем.ShowDialog();
            Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Hide();
            Music.pl2.Stop();
            ИГиП иГиП = new ИГиП();
            иГиП.ShowDialog();
            Close();
        }
    }
}
