namespace Programming.Veiw.Panels
{
    partial class WeekdayParsingControl1
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
            this.EnumstextBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EnumstextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnumstextBox3
            // 
            this.EnumstextBox3.Location = new System.Drawing.Point(13, 73);
            this.EnumstextBox3.Name = "EnumstextBox3";
            this.EnumstextBox3.Size = new System.Drawing.Size(223, 20);
            this.EnumstextBox3.TabIndex = 13;
            this.EnumstextBox3.TextChanged += new System.EventHandler(this.EnumstextBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnumstextBox2
            // 
            this.EnumstextBox2.Location = new System.Drawing.Point(13, 33);
            this.EnumstextBox2.Name = "EnumstextBox2";
            this.EnumstextBox2.Size = new System.Drawing.Size(223, 20);
            this.EnumstextBox2.TabIndex = 12;
            this.EnumstextBox2.TextChanged += new System.EventHandler(this.EnumstextBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type value for parcing\r\n:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // WeekdayParsingControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumstextBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnumstextBox2);
            this.Controls.Add(this.label4);
            this.Name = "WeekdayParsingControl1";
            this.Size = new System.Drawing.Size(349, 113);
            this.Load += new System.EventHandler(this.WeekdayParsingControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnumstextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EnumstextBox2;
        private System.Windows.Forms.Label label4;
    }
}
