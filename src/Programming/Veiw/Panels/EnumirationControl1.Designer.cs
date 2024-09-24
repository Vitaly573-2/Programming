namespace Programming.Veiw.Panels
{
    partial class EnumirationControl1
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
            this.EnumstextBox1 = new System.Windows.Forms.TextBox();
            this.EnumslistBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueslistBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EnumstextBox1
            // 
            this.EnumstextBox1.Location = new System.Drawing.Point(454, 50);
            this.EnumstextBox1.Name = "EnumstextBox1";
            this.EnumstextBox1.Size = new System.Drawing.Size(100, 20);
            this.EnumstextBox1.TabIndex = 12;
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
            this.EnumslistBox1.Location = new System.Drawing.Point(6, 50);
            this.EnumslistBox1.Name = "EnumslistBox1";
            this.EnumslistBox1.ScrollAlwaysVisible = true;
            this.EnumslistBox1.Size = new System.Drawing.Size(135, 132);
            this.EnumslistBox1.TabIndex = 7;
            this.EnumslistBox1.SelectedIndexChanged += new System.EventHandler(this.EnumslistBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(451, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Int value:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose enumiration:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(242, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose value:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ValueslistBox2
            // 
            this.ValueslistBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueslistBox2.FormattingEnabled = true;
            this.ValueslistBox2.ItemHeight = 16;
            this.ValueslistBox2.Location = new System.Drawing.Point(245, 50);
            this.ValueslistBox2.Name = "ValueslistBox2";
            this.ValueslistBox2.ScrollAlwaysVisible = true;
            this.ValueslistBox2.Size = new System.Drawing.Size(135, 132);
            this.ValueslistBox2.TabIndex = 10;
            this.ValueslistBox2.SelectedIndexChanged += new System.EventHandler(this.ValueslistBox2_SelectedIndexChanged);
            // 
            // EnumirationControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumstextBox1);
            this.Controls.Add(this.EnumslistBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ValueslistBox2);
            this.Name = "EnumirationControl1";
            this.Size = new System.Drawing.Size(575, 194);
            this.Load += new System.EventHandler(this.EnumirationControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnumstextBox1;
        private System.Windows.Forms.ListBox EnumslistBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ValueslistBox2;
    }
}
