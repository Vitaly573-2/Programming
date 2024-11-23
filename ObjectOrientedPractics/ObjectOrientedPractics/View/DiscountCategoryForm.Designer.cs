namespace ObjectOrientedPractics.View
{
    partial class DiscountCategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DiscountAddButton = new System.Windows.Forms.Button();
            this.DiscountCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Percent Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(100, 54);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(268, 21);
            this.CategoryComboBox.TabIndex = 2;
            // 
            // DiscountAddButton
            // 
            this.DiscountAddButton.Location = new System.Drawing.Point(177, 110);
            this.DiscountAddButton.Name = "DiscountAddButton";
            this.DiscountAddButton.Size = new System.Drawing.Size(103, 36);
            this.DiscountAddButton.TabIndex = 3;
            this.DiscountAddButton.Text = "Add";
            this.DiscountAddButton.UseVisualStyleBackColor = true;
            this.DiscountAddButton.Click += new System.EventHandler(this.DiscountAddButton_Click);
            // 
            // DiscountCancelButton
            // 
            this.DiscountCancelButton.Location = new System.Drawing.Point(286, 110);
            this.DiscountCancelButton.Name = "DiscountCancelButton";
            this.DiscountCancelButton.Size = new System.Drawing.Size(103, 36);
            this.DiscountCancelButton.TabIndex = 4;
            this.DiscountCancelButton.Text = "Cancel";
            this.DiscountCancelButton.UseVisualStyleBackColor = true;
            this.DiscountCancelButton.Click += new System.EventHandler(this.DiscountCancelButton_Click);
            // 
            // DiscountCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 171);
            this.Controls.Add(this.DiscountCancelButton);
            this.Controls.Add(this.DiscountAddButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DiscountCategoryForm";
            this.Text = "Add Discount";
            this.Load += new System.EventHandler(this.DiscountCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button DiscountAddButton;
        private System.Windows.Forms.Button DiscountCancelButton;
    }
}