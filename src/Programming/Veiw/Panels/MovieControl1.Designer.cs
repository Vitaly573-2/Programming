namespace Programming.Veiw.Panels
{
    partial class MovieControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label13 = new System.Windows.Forms.Label();
            this.RatingtextBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GenretextBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.YeartextBox1 = new System.Windows.Forms.TextBox();
            this.MinutestextBox2 = new System.Windows.Forms.TextBox();
            this.NametextBox3 = new System.Windows.Forms.TextBox();
            this.MovielistBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(239, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Rating:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // RatingtextBox5
            // 
            this.RatingtextBox5.Location = new System.Drawing.Point(242, 258);
            this.RatingtextBox5.Name = "RatingtextBox5";
            this.RatingtextBox5.Size = new System.Drawing.Size(132, 20);
            this.RatingtextBox5.TabIndex = 23;
            this.RatingtextBox5.TextChanged += new System.EventHandler(this.RatingtextBox5_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(239, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Genre:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // GenretextBox4
            // 
            this.GenretextBox4.Location = new System.Drawing.Point(242, 201);
            this.GenretextBox4.Name = "GenretextBox4";
            this.GenretextBox4.Size = new System.Drawing.Size(132, 20);
            this.GenretextBox4.TabIndex = 21;
            this.GenretextBox4.TextChanged += new System.EventHandler(this.GenretextBox4_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Find";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(239, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Year:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(239, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Minutes:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(239, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Name:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // YeartextBox1
            // 
            this.YeartextBox1.Location = new System.Drawing.Point(242, 147);
            this.YeartextBox1.Name = "YeartextBox1";
            this.YeartextBox1.Size = new System.Drawing.Size(132, 20);
            this.YeartextBox1.TabIndex = 16;
            this.YeartextBox1.TextChanged += new System.EventHandler(this.YeartextBox1_TextChanged);
            // 
            // MinutestextBox2
            // 
            this.MinutestextBox2.Location = new System.Drawing.Point(242, 90);
            this.MinutestextBox2.Name = "MinutestextBox2";
            this.MinutestextBox2.Size = new System.Drawing.Size(132, 20);
            this.MinutestextBox2.TabIndex = 15;
            this.MinutestextBox2.TextChanged += new System.EventHandler(this.MinutestextBox2_TextChanged);
            // 
            // NametextBox3
            // 
            this.NametextBox3.Location = new System.Drawing.Point(242, 34);
            this.NametextBox3.Name = "NametextBox3";
            this.NametextBox3.Size = new System.Drawing.Size(132, 20);
            this.NametextBox3.TabIndex = 14;
            this.NametextBox3.TextChanged += new System.EventHandler(this.NametextBox3_TextChanged);
            // 
            // MovielistBox1
            // 
            this.MovielistBox1.FormattingEnabled = true;
            this.MovielistBox1.Location = new System.Drawing.Point(3, 24);
            this.MovielistBox1.Name = "MovielistBox1";
            this.MovielistBox1.Size = new System.Drawing.Size(197, 264);
            this.MovielistBox1.TabIndex = 13;
            this.MovielistBox1.SelectedIndexChanged += new System.EventHandler(this.MovielistBox1_SelectedIndexChanged);
            // 
            // MovieControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.RatingtextBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.GenretextBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.YeartextBox1);
            this.Controls.Add(this.MinutestextBox2);
            this.Controls.Add(this.NametextBox3);
            this.Controls.Add(this.MovielistBox1);
            this.Name = "MovieControl1";
            this.Size = new System.Drawing.Size(390, 390);
            this.Load += new System.EventHandler(this.MovieControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox RatingtextBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox GenretextBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox YeartextBox1;
        private System.Windows.Forms.TextBox MinutestextBox2;
        private System.Windows.Forms.TextBox NametextBox3;
        private System.Windows.Forms.ListBox MovielistBox1;
    }
}
