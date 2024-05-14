namespace Programming
{
    partial class MainForm
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl11 = new Programming.Veiw.Panels.RectanglesCollisionControl1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rectanglesControl11 = new Programming.Veiw.Panels.RectanglesControl1();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.seasonsHandle1 = new Programming.Veiw.Panels.SeasonHandleControl1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weekdayParsingControl11 = new Programming.Veiw.Panels.WeekdayParsingControl1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enumirationControl11 = new Programming.Veiw.Panels.EnumirationControl1();
            this.Rectangles = new System.Windows.Forms.TabControl();
            this.movieControl11 = new Programming.Veiw.Panels.MovieControl1();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Rectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rectanglesCollisionControl11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1029, 490);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rectangles";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // rectanglesCollisionControl11
            // 
            this.rectanglesCollisionControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl11.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl11.Name = "rectanglesCollisionControl11";
            this.rectanglesCollisionControl11.Size = new System.Drawing.Size(1023, 484);
            this.rectanglesCollisionControl11.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1029, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.movieControl11);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(510, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(470, 439);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Movie";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rectanglesControl11);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1029, 490);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rectangles";
            // 
            // rectanglesControl11
            // 
            this.rectanglesControl11.Location = new System.Drawing.Point(7, 29);
            this.rectanglesControl11.Margin = new System.Windows.Forms.Padding(4);
            this.rectanglesControl11.Name = "rectanglesControl11";
            this.rectanglesControl11.Size = new System.Drawing.Size(456, 428);
            this.rectanglesControl11.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1029, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.seasonsHandle1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(541, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 156);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Season Handle";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // seasonsHandle1
            // 
            this.seasonsHandle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonsHandle1.Location = new System.Drawing.Point(3, 19);
            this.seasonsHandle1.Margin = new System.Windows.Forms.Padding(4);
            this.seasonsHandle1.Name = "seasonsHandle1";
            this.seasonsHandle1.Size = new System.Drawing.Size(443, 134);
            this.seasonsHandle1.TabIndex = 0;
            this.seasonsHandle1.Load += new System.EventHandler(this.seasonsHandle1_Load);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.weekdayParsingControl11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 188);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weekday Paraing";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // weekdayParsingControl11
            // 
            this.weekdayParsingControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayParsingControl11.Location = new System.Drawing.Point(3, 19);
            this.weekdayParsingControl11.Margin = new System.Windows.Forms.Padding(4);
            this.weekdayParsingControl11.Name = "weekdayParsingControl11";
            this.weekdayParsingControl11.Size = new System.Drawing.Size(458, 166);
            this.weekdayParsingControl11.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enumirationControl11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 249);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumirationa";
            // 
            // enumirationControl11
            // 
            this.enumirationControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumirationControl11.Location = new System.Drawing.Point(3, 19);
            this.enumirationControl11.Margin = new System.Windows.Forms.Padding(4);
            this.enumirationControl11.Name = "enumirationControl11";
            this.enumirationControl11.Size = new System.Drawing.Size(1009, 227);
            this.enumirationControl11.TabIndex = 0;
            // 
            // Rectangles
            // 
            this.Rectangles.Controls.Add(this.tabPage1);
            this.Rectangles.Controls.Add(this.tabPage2);
            this.Rectangles.Controls.Add(this.tabPage3);
            this.Rectangles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rectangles.Location = new System.Drawing.Point(0, 0);
            this.Rectangles.Name = "Rectangles";
            this.Rectangles.SelectedIndex = 0;
            this.Rectangles.Size = new System.Drawing.Size(1037, 516);
            this.Rectangles.TabIndex = 0;
            this.Rectangles.SelectedIndexChanged += new System.EventHandler(this.Enums_SelectedIndexChanged);
            // 
            // movieControl11
            // 
            this.movieControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieControl11.Location = new System.Drawing.Point(3, 19);
            this.movieControl11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movieControl11.Name = "movieControl11";
            this.movieControl11.Size = new System.Drawing.Size(464, 417);
            this.movieControl11.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 516);
            this.Controls.Add(this.Rectangles);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Rectangles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl Rectangles;
        private Veiw.Panels.RectanglesCollisionControl1 rectanglesCollisionControl11;
        private Veiw.Panels.EnumirationControl1 enumirationControl11;
        private Veiw.Panels.WeekdayParsingControl1 weekdayParsingControl11;
        private Veiw.Panels.SeasonHandleControl1 seasonsHandle1;
        private Veiw.Panels.RectanglesControl1 rectanglesControl11;
        private Veiw.Panels.MovieControl1 movieControl11;
    }
}

