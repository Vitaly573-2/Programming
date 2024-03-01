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
            this.Enums = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnumstextBox1 = new System.Windows.Forms.TextBox();
            this.EnumslistBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueslistBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnumstextBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EnumstextBox3 = new System.Windows.Forms.TextBox();
            this.Enums.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.tabPage1);
            this.Enums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enums.Location = new System.Drawing.Point(0, 0);
            this.Enums.Name = "Enums";
            this.Enums.SelectedIndex = 0;
            this.Enums.Size = new System.Drawing.Size(1037, 516);
            this.Enums.TabIndex = 0;
            this.Enums.SelectedIndexChanged += new System.EventHandler(this.Enums_SelectedIndexChanged);
            // 
            // tabPage1
            // 
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EnumstextBox3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.EnumstextBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 144);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weekday Paraing";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EnumstextBox1);
            this.groupBox1.Controls.Add(this.EnumslistBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ValueslistBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 249);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumirationa";
            // 
            // EnumstextBox1
            // 
            this.EnumstextBox1.Location = new System.Drawing.Point(471, 70);
            this.EnumstextBox1.Name = "EnumstextBox1";
            this.EnumstextBox1.Size = new System.Drawing.Size(100, 23);
            this.EnumstextBox1.TabIndex = 6;
            this.EnumstextBox1.TextChanged += new System.EventHandler(this.EnumstextBox1_TextChanged);
            // 
            // EnumslistBox1
            // 
            this.EnumslistBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnumslistBox1.FormattingEnabled = true;
            this.EnumslistBox1.ItemHeight = 16;
            this.EnumslistBox1.Items.AddRange(new object[] {
            "Color",
            "Education",
            "Genre",
            "Season",
            "Smartphone",
            "Weekday"});
            this.EnumslistBox1.Location = new System.Drawing.Point(23, 70);
            this.EnumslistBox1.Name = "EnumslistBox1";
            this.EnumslistBox1.ScrollAlwaysVisible = true;
            this.EnumslistBox1.Size = new System.Drawing.Size(135, 132);
            this.EnumslistBox1.TabIndex = 0;
            this.EnumslistBox1.SelectedIndexChanged += new System.EventHandler(this.EnumslistBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(468, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Int value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose enumiration:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(259, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose value:";
            // 
            // ValueslistBox2
            // 
            this.ValueslistBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueslistBox2.FormattingEnabled = true;
            this.ValueslistBox2.ItemHeight = 16;
            this.ValueslistBox2.Location = new System.Drawing.Point(262, 70);
            this.ValueslistBox2.Name = "ValueslistBox2";
            this.ValueslistBox2.ScrollAlwaysVisible = true;
            this.ValueslistBox2.Size = new System.Drawing.Size(135, 132);
            this.ValueslistBox2.TabIndex = 3;
            this.ValueslistBox2.SelectedIndexChanged += new System.EventHandler(this.ValueslistBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type value for parcing\r\n:";
            // 
            // EnumstextBox2
            // 
            this.EnumstextBox2.Location = new System.Drawing.Point(9, 52);
            this.EnumstextBox2.Name = "EnumstextBox2";
            this.EnumstextBox2.Size = new System.Drawing.Size(191, 23);
            this.EnumstextBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnumstextBox3
            // 
            this.EnumstextBox3.Location = new System.Drawing.Point(9, 95);
            this.EnumstextBox3.Name = "EnumstextBox3";
            this.EnumstextBox3.Size = new System.Drawing.Size(191, 23);
            this.EnumstextBox3.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 516);
            this.Controls.Add(this.Enums);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Enums.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Enums;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox EnumslistBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ValueslistBox2;
        private System.Windows.Forms.TextBox EnumstextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EnumstextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EnumstextBox3;
    }
}

