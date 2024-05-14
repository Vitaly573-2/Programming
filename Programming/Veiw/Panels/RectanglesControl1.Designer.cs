namespace Programming.Veiw.Panels
{
    partial class RectanglesControl1
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
            this.label16 = new System.Windows.Forms.Label();
            this.idtextBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CenterYtextBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CenterXtextBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ColortextBox3 = new System.Windows.Forms.TextBox();
            this.WidthtextBox2 = new System.Windows.Forms.TextBox();
            this.LengthtextBox1 = new System.Windows.Forms.TextBox();
            this.EnumslistBox4 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(251, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "ID";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // idtextBox1
            // 
            this.idtextBox1.Location = new System.Drawing.Point(251, 339);
            this.idtextBox1.Name = "idtextBox1";
            this.idtextBox1.ReadOnly = true;
            this.idtextBox1.Size = new System.Drawing.Size(132, 20);
            this.idtextBox1.TabIndex = 27;
            this.idtextBox1.TextChanged += new System.EventHandler(this.idtextBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(251, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Center Y:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // CenterYtextBox1
            // 
            this.CenterYtextBox1.Location = new System.Drawing.Point(251, 280);
            this.CenterYtextBox1.Name = "CenterYtextBox1";
            this.CenterYtextBox1.ReadOnly = true;
            this.CenterYtextBox1.Size = new System.Drawing.Size(132, 20);
            this.CenterYtextBox1.TabIndex = 25;
            this.CenterYtextBox1.TextChanged += new System.EventHandler(this.CenterYtextBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(251, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Center X:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // CenterXtextBox1
            // 
            this.CenterXtextBox1.Location = new System.Drawing.Point(251, 218);
            this.CenterXtextBox1.Name = "CenterXtextBox1";
            this.CenterXtextBox1.ReadOnly = true;
            this.CenterXtextBox1.Size = new System.Drawing.Size(132, 20);
            this.CenterXtextBox1.TabIndex = 23;
            this.CenterXtextBox1.TextChanged += new System.EventHandler(this.CenterXtextBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(248, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Color:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(248, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Width:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(248, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lenght:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ColortextBox3
            // 
            this.ColortextBox3.Location = new System.Drawing.Point(251, 161);
            this.ColortextBox3.Name = "ColortextBox3";
            this.ColortextBox3.Size = new System.Drawing.Size(132, 20);
            this.ColortextBox3.TabIndex = 18;
            this.ColortextBox3.TextChanged += new System.EventHandler(this.ColortextBox3_TextChanged);
            // 
            // WidthtextBox2
            // 
            this.WidthtextBox2.Location = new System.Drawing.Point(251, 98);
            this.WidthtextBox2.Name = "WidthtextBox2";
            this.WidthtextBox2.Size = new System.Drawing.Size(132, 20);
            this.WidthtextBox2.TabIndex = 17;
            this.WidthtextBox2.TextChanged += new System.EventHandler(this.WidthtextBox2_TextChanged);
            // 
            // LengthtextBox1
            // 
            this.LengthtextBox1.Location = new System.Drawing.Point(251, 35);
            this.LengthtextBox1.Name = "LengthtextBox1";
            this.LengthtextBox1.Size = new System.Drawing.Size(132, 20);
            this.LengthtextBox1.TabIndex = 16;
            this.LengthtextBox1.TextChanged += new System.EventHandler(this.LengthtextBox1_TextChanged);
            // 
            // EnumslistBox4
            // 
            this.EnumslistBox4.FormattingEnabled = true;
            this.EnumslistBox4.Location = new System.Drawing.Point(12, 12);
            this.EnumslistBox4.Name = "EnumslistBox4";
            this.EnumslistBox4.Size = new System.Drawing.Size(197, 264);
            this.EnumslistBox4.TabIndex = 15;
            this.EnumslistBox4.SelectedIndexChanged += new System.EventHandler(this.EnumslistBox4_SelectedIndexChanged);
            // 
            // RectanglesControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.idtextBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CenterYtextBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CenterXtextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ColortextBox3);
            this.Controls.Add(this.WidthtextBox2);
            this.Controls.Add(this.LengthtextBox1);
            this.Controls.Add(this.EnumslistBox4);
            this.Name = "RectanglesControl1";
            this.Size = new System.Drawing.Size(403, 428);
            this.Load += new System.EventHandler(this.RectanglesControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox idtextBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox CenterYtextBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CenterXtextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ColortextBox3;
        private System.Windows.Forms.TextBox WidthtextBox2;
        private System.Windows.Forms.TextBox LengthtextBox1;
        private System.Windows.Forms.ListBox EnumslistBox4;
    }
}
