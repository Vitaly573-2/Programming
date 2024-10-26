namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersFullNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomersIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustoemersAddButton = new System.Windows.Forms.Button();
            this.CstomersRemoveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(9, 28);
            this.CustomersListBox.MinimumSize = new System.Drawing.Size(283, 563);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(283, 563);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CustomersListBox_MouseClick);
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersFullNameTextBox
            // 
            this.CustomersFullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersFullNameTextBox.Location = new System.Drawing.Point(95, 66);
            this.CustomersFullNameTextBox.MinimumSize = new System.Drawing.Size(301, 20);
            this.CustomersFullNameTextBox.Name = "CustomersFullNameTextBox";
            this.CustomersFullNameTextBox.Size = new System.Drawing.Size(301, 20);
            this.CustomersFullNameTextBox.TabIndex = 6;
            this.CustomersFullNameTextBox.TextChanged += new System.EventHandler(this.CustomersFullNameTextBox_TextChanged_1);
            // 
            // CustomersIdTextBox
            // 
            this.CustomersIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersIdTextBox.Location = new System.Drawing.Point(95, 39);
            this.CustomersIdTextBox.MinimumSize = new System.Drawing.Size(301, 20);
            this.CustomersIdTextBox.Name = "CustomersIdTextBox";
            this.CustomersIdTextBox.ReadOnly = true;
            this.CustomersIdTextBox.Size = new System.Drawing.Size(301, 20);
            this.CustomersIdTextBox.TabIndex = 5;
            this.CustomersIdTextBox.TextChanged += new System.EventHandler(this.CustomersIdTextBox_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Full Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Customer";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CustoemersAddButton
            // 
            this.CustoemersAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustoemersAddButton.Location = new System.Drawing.Point(9, 594);
            this.CustoemersAddButton.MaximumSize = new System.Drawing.Size(120, 60);
            this.CustoemersAddButton.MinimumSize = new System.Drawing.Size(95, 40);
            this.CustoemersAddButton.Name = "CustoemersAddButton";
            this.CustoemersAddButton.Size = new System.Drawing.Size(95, 40);
            this.CustoemersAddButton.TabIndex = 2;
            this.CustoemersAddButton.Text = "Add";
            this.CustoemersAddButton.UseVisualStyleBackColor = true;
            this.CustoemersAddButton.Click += new System.EventHandler(this.CustoemersAddButton_Click_1);
            // 
            // CstomersRemoveButton
            // 
            this.CstomersRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CstomersRemoveButton.Location = new System.Drawing.Point(123, 594);
            this.CstomersRemoveButton.MaximumSize = new System.Drawing.Size(120, 60);
            this.CstomersRemoveButton.MinimumSize = new System.Drawing.Size(95, 40);
            this.CstomersRemoveButton.Name = "CstomersRemoveButton";
            this.CstomersRemoveButton.Size = new System.Drawing.Size(95, 40);
            this.CstomersRemoveButton.TabIndex = 3;
            this.CstomersRemoveButton.Text = "Remove";
            this.CstomersRemoveButton.UseVisualStyleBackColor = true;
            this.CstomersRemoveButton.Click += new System.EventHandler(this.CstomersRemoveButton_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.addressControl1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CustomersIdTextBox);
            this.panel1.Controls.Add(this.CustomersFullNameTextBox);
            this.panel1.Location = new System.Drawing.Point(308, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(408, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 588);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addressControl1
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            this.addressControl1.Address = address1;
            this.addressControl1.Location = new System.Drawing.Point(3, 125);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(400, 190);
            this.addressControl1.TabIndex = 7;
            this.addressControl1.Load += new System.EventHandler(this.addressControl1_Load_1);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CstomersRemoveButton);
            this.Controls.Add(this.CustoemersAddButton);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(730, 656);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(730, 656);
            this.Load += new System.EventHandler(this.CustomersTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.TextBox CustomersFullNameTextBox;
        private System.Windows.Forms.TextBox CustomersIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CustoemersAddButton;
        private System.Windows.Forms.Button CstomersRemoveButton;
        private System.Windows.Forms.Panel panel1;
        private Controls.AddressControl addressControl1;
    }
}
