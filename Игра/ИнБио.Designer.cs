
namespace Игра
{
    partial class ИнБио
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ИнБио));
            this.button1_InBio = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3_InBio = new System.Windows.Forms.Button();
            this.button2_InBio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_number_seconds = new System.Windows.Forms.Timer(this.components);
            this.timer_move_button1 = new System.Windows.Forms.Timer(this.components);
            this.timer_move_button2 = new System.Windows.Forms.Timer(this.components);
            this.timer_move_button3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_InBio
            // 
            this.button1_InBio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1_InBio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1_InBio.ForeColor = System.Drawing.Color.Transparent;
            this.button1_InBio.Image = ((System.Drawing.Image)(resources.GetObject("button1_InBio.Image")));
            this.button1_InBio.Location = new System.Drawing.Point(51, 348);
            this.button1_InBio.Margin = new System.Windows.Forms.Padding(0);
            this.button1_InBio.Name = "button1_InBio";
            this.button1_InBio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1_InBio.Size = new System.Drawing.Size(130, 130);
            this.button1_InBio.TabIndex = 84;
            this.button1_InBio.UseVisualStyleBackColor = false;
            this.button1_InBio.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1050, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(113)))));
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(668, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 75;
            this.label3.Text = "Кол-во карандашей:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(113)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(668, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 72;
            this.label2.Text = "Кол-во растений:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(113)))));
            this.label8.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(471, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 26);
            this.label8.TabIndex = 82;
            this.label8.Text = "Институт биологии";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(125, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 31);
            this.button4.TabIndex = 81;
            this.button4.Text = "Начать";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 80;
            this.label7.Text = "ТАЙМЕР";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F);
            this.label6.Location = new System.Drawing.Point(82, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 22);
            this.label6.TabIndex = 79;
            this.label6.Text = "0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(113)))));
            this.richTextBox1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(242, 83);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(425, 160);
            this.richTextBox1.TabIndex = 76;
            this.richTextBox1.Text = "Прийти на лекция по биологии и записать материал:\n20 книг\n20 растений\n40 карандаш" +
    "ей\nУ вас есть 20 секунд!";
            // 
            // button3_InBio
            // 
            this.button3_InBio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3_InBio.Image = ((System.Drawing.Image)(resources.GetObject("button3_InBio.Image")));
            this.button3_InBio.Location = new System.Drawing.Point(947, 243);
            this.button3_InBio.Name = "button3_InBio";
            this.button3_InBio.Size = new System.Drawing.Size(130, 130);
            this.button3_InBio.TabIndex = 74;
            this.button3_InBio.UseVisualStyleBackColor = false;
            this.button3_InBio.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2_InBio
            // 
            this.button2_InBio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2_InBio.Image = ((System.Drawing.Image)(resources.GetObject("button2_InBio.Image")));
            this.button2_InBio.Location = new System.Drawing.Point(542, 362);
            this.button2_InBio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2_InBio.Name = "button2_InBio";
            this.button2_InBio.Size = new System.Drawing.Size(130, 130);
            this.button2_InBio.TabIndex = 73;
            this.button2_InBio.UseVisualStyleBackColor = false;
            this.button2_InBio.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(113)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(668, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Кол-во книг:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 616);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // timer_number_seconds
            // 
            this.timer_number_seconds.Interval = 1000;
            this.timer_number_seconds.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ИнБио
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.button1_InBio);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3_InBio);
            this.Controls.Add(this.button2_InBio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ИнБио";
            this.Text = "ИнБио";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_InBio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3_InBio;
        private System.Windows.Forms.Button button2_InBio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_number_seconds;
        private System.Windows.Forms.Timer timer_move_button1;
        private System.Windows.Forms.Timer timer_move_button2;
        private System.Windows.Forms.Timer timer_move_button3;
    }
}