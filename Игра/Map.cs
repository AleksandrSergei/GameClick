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
            Load += new EventHandler(Form1_Load);
            View.InitializeMap(label1, label4, panel1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
                pictureBox7, pictureBox8, pictureBox10, pictureBox11);
        }

        void Form1_Load(object sender, EventArgs e) => View.LoadMap(pictureBox2, pictureBox3, pictureBox4,
            pictureBox5, pictureBox7, pictureBox8, pictureBox10, pictureBox11);

        private void Button1_Map_Click(object sender, EventArgs e) => View.PictureBoxMap_Click(this, 1);
        private void Button2_Map_Click(object sender, EventArgs e) => View.PictureBoxMap_Click(this, 1);
        private void PictureBox2_Map_Click(object sender, EventArgs e) => View.PictureBoxMap_Click(this, 2);
        private void PictureBox3_Map_Click(object sender, EventArgs e) => View.PictureBoxMap_Click(this, 3);
        public void PictureBox4_Map_Click(object sender, EventArgs e) => View.PictureBoxMap_Click(this, 4);
        private void PictureBox5_Map_Click(object sender, EventArgs e) => View.PictureBoxMap_Click(this, 5);
        private void PictureBox7_Map_Click(object sender, EventArgs e) => View.PictureBoxMap_Click(this, 7);
        private void PictureBox8_Map_Click(object sender, EventArgs e) => View.PictureBoxMap_Click(this, 8);
        private void PictureBox10_Map_Click(object sender, EventArgs e) => View.PictureBoxMap_Click(this, 10);
        private void PictureBox11_Map_Click(object sender, EventArgs e) => View.PictureBoxMap_Click(this, 11);
    }
}
