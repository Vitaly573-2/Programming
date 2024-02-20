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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnumstextBox1 = new System.Windows.Forms.TextBox();
            this.EnumslistBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueslistBox2 = new System.Windows.Forms.ListBox();
            this.Enums.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1015, 359);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "enuirations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EnumstextBox1
            // 
            this.EnumstextBox1.Location = new System.Drawing.Point(471, 70);
            this.EnumstextBox1.Name = "EnumstextBox1";
            this.EnumstextBox1.Size = new System.Drawing.Size(100, 23);
            this.EnumstextBox1.TabIndex = 6;
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
    }
}

