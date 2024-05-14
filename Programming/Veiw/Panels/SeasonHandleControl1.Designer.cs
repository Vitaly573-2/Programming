namespace Programming.Veiw.Panels
{
    partial class SeasonHandleControl1
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
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SeasonCombotBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Choose season:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SeasonCombotBox
            // 
            this.SeasonCombotBox.FormattingEnabled = true;
            this.SeasonCombotBox.Location = new System.Drawing.Point(12, 36);
            this.SeasonCombotBox.Name = "SeasonCombotBox";
            this.SeasonCombotBox.Size = new System.Drawing.Size(121, 21);
            this.SeasonCombotBox.TabIndex = 13;
            this.SeasonCombotBox.SelectedIndexChanged += new System.EventHandler(this.SeasonCombotBox_SelectedIndexChanged);
            // 
            // SeasonHandleControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonCombotBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Name = "SeasonHandleControl1";
            this.Size = new System.Drawing.Size(215, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SeasonCombotBox;
    }
}
