namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CategoryComboBox1 = new System.Windows.Forms.ComboBox();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CosttextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Removebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.ItemslistBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FindSubstringTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SortedByComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CategoryComboBox1);
            this.panel1.Controls.Add(this.DescriptiontextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CosttextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.IdtextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NametextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(301, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(423, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 653);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Category:";
            // 
            // CategoryComboBox1
            // 
            this.CategoryComboBox1.FormattingEnabled = true;
            this.CategoryComboBox1.Location = new System.Drawing.Point(83, 80);
            this.CategoryComboBox1.Name = "CategoryComboBox1";
            this.CategoryComboBox1.Size = new System.Drawing.Size(178, 21);
            this.CategoryComboBox1.TabIndex = 11;
            this.CategoryComboBox1.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox1_SelectedIndexChanged);
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptiontextBox.Location = new System.Drawing.Point(3, 253);
            this.DescriptiontextBox.MinimumSize = new System.Drawing.Size(419, 165);
            this.DescriptiontextBox.Multiline = true;
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.Size = new System.Drawing.Size(419, 165);
            this.DescriptiontextBox.TabIndex = 10;
            this.DescriptiontextBox.TextChanged += new System.EventHandler(this.DescriptiontextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Item";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // CosttextBox
            // 
            this.CosttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CosttextBox.Location = new System.Drawing.Point(83, 54);
            this.CosttextBox.MinimumSize = new System.Drawing.Size(178, 20);
            this.CosttextBox.Name = "CosttextBox";
            this.CosttextBox.Size = new System.Drawing.Size(178, 20);
            this.CosttextBox.TabIndex = 6;
            this.CosttextBox.TextChanged += new System.EventHandler(this.CosttextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Description:";
            this.label6.Click += new System.EventHandler(this.label6_Click_2);
            // 
            // IdtextBox
            // 
            this.IdtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdtextBox.Location = new System.Drawing.Point(83, 26);
            this.IdtextBox.MinimumSize = new System.Drawing.Size(178, 20);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.ReadOnly = true;
            this.IdtextBox.Size = new System.Drawing.Size(178, 20);
            this.IdtextBox.TabIndex = 5;
            this.IdtextBox.TextChanged += new System.EventHandler(this.IdtextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID:";
            this.label5.Click += new System.EventHandler(this.label5_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // NametextBox
            // 
            this.NametextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NametextBox.Location = new System.Drawing.Point(3, 121);
            this.NametextBox.MinimumSize = new System.Drawing.Size(419, 86);
            this.NametextBox.Multiline = true;
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(419, 86);
            this.NametextBox.TabIndex = 8;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cost:";
            this.label4.Click += new System.EventHandler(this.label4_Click_2);
            // 
            // Removebutton
            // 
            this.Removebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Removebutton.Location = new System.Drawing.Point(123, 594);
            this.Removebutton.MaximumSize = new System.Drawing.Size(120, 60);
            this.Removebutton.MinimumSize = new System.Drawing.Size(95, 40);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(95, 40);
            this.Removebutton.TabIndex = 8;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = true;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Items";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Addbutton
            // 
            this.Addbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Addbutton.Location = new System.Drawing.Point(9, 594);
            this.Addbutton.MaximumSize = new System.Drawing.Size(120, 60);
            this.Addbutton.MinimumSize = new System.Drawing.Size(95, 40);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(95, 40);
            this.Addbutton.TabIndex = 7;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // ItemslistBox
            // 
            this.ItemslistBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemslistBox.FormattingEnabled = true;
            this.ItemslistBox.Location = new System.Drawing.Point(9, 60);
            this.ItemslistBox.MaximumSize = new System.Drawing.Size(4, 290);
            this.ItemslistBox.MinimumSize = new System.Drawing.Size(283, 463);
            this.ItemslistBox.Name = "ItemslistBox";
            this.ItemslistBox.Size = new System.Drawing.Size(283, 459);
            this.ItemslistBox.TabIndex = 6;
            this.ItemslistBox.SelectedIndexChanged += new System.EventHandler(this.ItemslistBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Find:";
            // 
            // FindSubstringTextBox
            // 
            this.FindSubstringTextBox.Location = new System.Drawing.Point(58, 32);
            this.FindSubstringTextBox.Name = "FindSubstringTextBox";
            this.FindSubstringTextBox.Size = new System.Drawing.Size(234, 20);
            this.FindSubstringTextBox.TabIndex = 11;
            this.FindSubstringTextBox.TextChanged += new System.EventHandler(this.FindSubstringTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 535);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "SortedBy:";
            // 
            // SortedByComboBox
            // 
            this.SortedByComboBox.FormattingEnabled = true;
            this.SortedByComboBox.Location = new System.Drawing.Point(82, 535);
            this.SortedByComboBox.Name = "SortedByComboBox";
            this.SortedByComboBox.Size = new System.Drawing.Size(210, 21);
            this.SortedByComboBox.TabIndex = 13;
            this.SortedByComboBox.SelectedIndexChanged += new System.EventHandler(this.SortedByComboBox_SelectedIndexChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SortedByComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FindSubstringTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.ItemslistBox);
            this.MinimumSize = new System.Drawing.Size(730, 656);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(730, 656);
            this.Load += new System.EventHandler(this.ItemsTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CosttextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.ListBox ItemslistBox;
        private System.Windows.Forms.ComboBox CategoryComboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FindSubstringTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SortedByComboBox;
    }
}
