namespace Игра
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Play = new System.Windows.Forms.Button();
            this.Map = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(298, 135);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(197, 42);
            this.Play.TabIndex = 0;
            this.Play.Text = "Играть";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Map
            // 
            this.Map.Location = new System.Drawing.Point(298, 234);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(197, 42);
            this.Map.TabIndex = 3;
            this.Map.Text = "Карта";
            this.Map.UseVisualStyleBackColor = true;
            this.Map.Click += new System.EventHandler(this.Map_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(298, 282);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(197, 42);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Загрузки";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.Play);
            this.Name = "Menu";
            this.Text = "Меню";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Map;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button1;
    }
}

