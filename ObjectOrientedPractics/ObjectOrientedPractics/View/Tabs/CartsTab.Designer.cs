﻿namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.ItemsOfList = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.CartsButton = new System.Windows.Forms.Button();
            this.CustomerComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.CartsListBox = new System.Windows.Forms.ListBox();
            this.DiscountPanel = new System.Windows.Forms.Panel();
            this.DiscountCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Amount = new System.Windows.Forms.Label();
            this.DiscoundAmountLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiscountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsOfList
            // 
            this.ItemsOfList.AutoSize = true;
            this.ItemsOfList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsOfList.Location = new System.Drawing.Point(10, 7);
            this.ItemsOfList.Name = "ItemsOfList";
            this.ItemsOfList.Size = new System.Drawing.Size(46, 17);
            this.ItemsOfList.TabIndex = 0;
            this.ItemsOfList.Text = "Items";
            this.ItemsOfList.Click += new System.EventHandler(this.Items_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(13, 27);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(275, 550);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.CartsListBox1_SelectedIndexChanged);
            // 
            // CartsButton
            // 
            this.CartsButton.Location = new System.Drawing.Point(13, 594);
            this.CartsButton.Name = "CartsButton";
            this.CartsButton.Size = new System.Drawing.Size(99, 40);
            this.CartsButton.TabIndex = 2;
            this.CartsButton.Text = "Add to Cart";
            this.CartsButton.UseVisualStyleBackColor = true;
            this.CartsButton.Click += new System.EventHandler(this.CartsButton_Click);
            // 
            // CustomerComboBox1
            // 
            this.CustomerComboBox1.FormattingEnabled = true;
            this.CustomerComboBox1.Location = new System.Drawing.Point(372, 44);
            this.CustomerComboBox1.Name = "CustomerComboBox1";
            this.CustomerComboBox1.Size = new System.Drawing.Size(335, 21);
            this.CustomerComboBox1.TabIndex = 3;
            this.CustomerComboBox1.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(294, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(294, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cart:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(635, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(635, 284);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(42, 17);
            this.CostLabel.TabIndex = 8;
            this.CostLabel.Text = "None";
            this.CostLabel.Click += new System.EventHandler(this.CostLabel_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(308, 308);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(99, 40);
            this.CreateOrderButton.TabIndex = 9;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Location = new System.Drawing.Point(618, 308);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(99, 40);
            this.ClearCartButton.TabIndex = 10;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(513, 308);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(99, 40);
            this.RemoveItemButton.TabIndex = 11;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // CartsListBox
            // 
            this.CartsListBox.FormattingEnabled = true;
            this.CartsListBox.Location = new System.Drawing.Point(297, 108);
            this.CartsListBox.Name = "CartsListBox";
            this.CartsListBox.Size = new System.Drawing.Size(420, 121);
            this.CartsListBox.TabIndex = 12;
            this.CartsListBox.SelectedIndexChanged += new System.EventHandler(this.CartsListBox_SelectedIndexChanged);
            // 
            // DiscountPanel
            // 
            this.DiscountPanel.Controls.Add(this.label4);
            this.DiscountPanel.Controls.Add(this.TotalLabel);
            this.DiscountPanel.Controls.Add(this.label5);
            this.DiscountPanel.Controls.Add(this.DiscoundAmountLabel);
            this.DiscountPanel.Controls.Add(this.Amount);
            this.DiscountPanel.Controls.Add(this.DiscountCheckedListBox);
            this.DiscountPanel.Location = new System.Drawing.Point(308, 354);
            this.DiscountPanel.Name = "DiscountPanel";
            this.DiscountPanel.Size = new System.Drawing.Size(409, 280);
            this.DiscountPanel.TabIndex = 13;
            // 
            // DiscountCheckedListBox
            // 
            this.DiscountCheckedListBox.FormattingEnabled = true;
            this.DiscountCheckedListBox.Location = new System.Drawing.Point(3, 20);
            this.DiscountCheckedListBox.Name = "DiscountCheckedListBox";
            this.DiscountCheckedListBox.Size = new System.Drawing.Size(265, 244);
            this.DiscountCheckedListBox.TabIndex = 0;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(271, 14);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(135, 17);
            this.Amount.TabIndex = 14;
            this.Amount.Text = "Discount Amount:";
            // 
            // DiscoundAmountLabel
            // 
            this.DiscoundAmountLabel.AutoSize = true;
            this.DiscoundAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscoundAmountLabel.Location = new System.Drawing.Point(274, 40);
            this.DiscoundAmountLabel.Name = "DiscoundAmountLabel";
            this.DiscoundAmountLabel.Size = new System.Drawing.Size(42, 17);
            this.DiscoundAmountLabel.TabIndex = 15;
            this.DiscoundAmountLabel.Text = "None";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalLabel.Location = new System.Drawing.Point(274, 246);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(42, 17);
            this.TotalLabel.TabIndex = 17;
            this.TotalLabel.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(271, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Discounts:";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DiscountPanel);
            this.Controls.Add(this.CartsListBox);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerComboBox1);
            this.Controls.Add(this.CartsButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsOfList);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(730, 656);
            this.Load += new System.EventHandler(this.CartsTab_Load);
            this.DiscountPanel.ResumeLayout(false);
            this.DiscountPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemsOfList;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button CartsButton;
        private System.Windows.Forms.ComboBox CustomerComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.ListBox CartsListBox;
        private System.Windows.Forms.Panel DiscountPanel;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.CheckedListBox DiscountCheckedListBox;
        private System.Windows.Forms.Label DiscoundAmountLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
