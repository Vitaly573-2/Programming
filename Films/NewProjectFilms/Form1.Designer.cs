namespace NewProjectFilms
{
    partial class Form1
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
            this.FilmsListBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.RemoveButton2 = new System.Windows.Forms.Button();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinutesTextBox3 = new System.Windows.Forms.TextBox();
            this.RatingTextBox4 = new System.Windows.Forms.TextBox();
            this.GenreComboBox1 = new System.Windows.Forms.ComboBox();
            this.YearTextBox2 = new System.Windows.Forms.TextBox();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilmsListBox1
            // 
            this.FilmsListBox1.FormattingEnabled = true;
            this.FilmsListBox1.Location = new System.Drawing.Point(12, 54);
            this.FilmsListBox1.Name = "FilmsListBox1";
            this.FilmsListBox1.Size = new System.Drawing.Size(336, 433);
            this.FilmsListBox1.TabIndex = 0;
            this.FilmsListBox1.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.RemoveButton2);
            this.groupBox1.Controls.Add(this.Addbutton1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MinutesTextBox3);
            this.groupBox1.Controls.Add(this.RatingTextBox4);
            this.groupBox1.Controls.Add(this.GenreComboBox1);
            this.groupBox1.Controls.Add(this.YearTextBox2);
            this.groupBox1.Controls.Add(this.NameTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(383, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 428);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильмы";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Изменение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RemoveButton2
            // 
            this.RemoveButton2.Location = new System.Drawing.Point(179, 375);
            this.RemoveButton2.Name = "RemoveButton2";
            this.RemoveButton2.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton2.TabIndex = 11;
            this.RemoveButton2.Text = "Удаление";
            this.RemoveButton2.UseVisualStyleBackColor = true;
            this.RemoveButton2.Click += new System.EventHandler(this.RemoveButton2_Click);
            // 
            // Addbutton1
            // 
            this.Addbutton1.Location = new System.Drawing.Point(41, 375);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(75, 23);
            this.Addbutton1.TabIndex = 10;
            this.Addbutton1.Text = "Добавть";
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Продолжительность";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Рейтинг";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Жанр";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Год выпуска";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MinutesTextBox3
            // 
            this.MinutesTextBox3.Location = new System.Drawing.Point(74, 310);
            this.MinutesTextBox3.Name = "MinutesTextBox3";
            this.MinutesTextBox3.Size = new System.Drawing.Size(100, 20);
            this.MinutesTextBox3.TabIndex = 4;
            this.MinutesTextBox3.TextChanged += new System.EventHandler(this.MinutesTextBox3_TextChanged);
            // 
            // RatingTextBox4
            // 
            this.RatingTextBox4.Location = new System.Drawing.Point(74, 247);
            this.RatingTextBox4.Name = "RatingTextBox4";
            this.RatingTextBox4.Size = new System.Drawing.Size(100, 20);
            this.RatingTextBox4.TabIndex = 3;
            this.RatingTextBox4.TextChanged += new System.EventHandler(this.RatingTextBox4_TextChanged);
            // 
            // GenreComboBox1
            // 
            this.GenreComboBox1.FormattingEnabled = true;
            this.GenreComboBox1.Location = new System.Drawing.Point(74, 182);
            this.GenreComboBox1.Name = "GenreComboBox1";
            this.GenreComboBox1.Size = new System.Drawing.Size(121, 21);
            this.GenreComboBox1.TabIndex = 2;
            this.GenreComboBox1.SelectedIndexChanged += new System.EventHandler(this.GenreComboBox1_SelectedIndexChanged);
            // 
            // YearTextBox2
            // 
            this.YearTextBox2.Location = new System.Drawing.Point(74, 124);
            this.YearTextBox2.Name = "YearTextBox2";
            this.YearTextBox2.Size = new System.Drawing.Size(100, 20);
            this.YearTextBox2.TabIndex = 1;
            this.YearTextBox2.TextChanged += new System.EventHandler(this.YearTextBox2_TextChanged);
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Location = new System.Drawing.Point(74, 61);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox1.TabIndex = 0;
            this.NameTextBox1.TextChanged += new System.EventHandler(this.NameTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список фильмов";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FilmsListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FilmsListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinutesTextBox3;
        private System.Windows.Forms.TextBox RatingTextBox4;
        private System.Windows.Forms.ComboBox GenreComboBox1;
        private System.Windows.Forms.TextBox YearTextBox2;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button RemoveButton2;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

