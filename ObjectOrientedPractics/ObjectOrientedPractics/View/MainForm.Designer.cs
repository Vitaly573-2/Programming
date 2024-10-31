namespace ObjectOrientedPractics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.itemsTab2 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.Carts = new System.Windows.Forms.TabPage();
            this.cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.Carts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.Carts);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MinimumSize = new System.Drawing.Size(741, 688);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 688);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.itemsTab2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(733, 662);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Item";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // itemsTab2
            // 
            this.itemsTab2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsTab2.Items = null;
            this.itemsTab2.Location = new System.Drawing.Point(0, 0);
            this.itemsTab2.MinimumSize = new System.Drawing.Size(730, 656);
            this.itemsTab2.Name = "itemsTab2";
            this.itemsTab2.Size = new System.Drawing.Size(730, 656);
            this.itemsTab2.TabIndex = 0;
            this.itemsTab2.Load += new System.EventHandler(this.itemsTab2_Load);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.customersTab1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(733, 662);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Customer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            this.customersTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersTab1.Customers = null;
            this.customersTab1.Location = new System.Drawing.Point(0, 6);
            this.customersTab1.MinimumSize = new System.Drawing.Size(730, 656);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Size = new System.Drawing.Size(734, 656);
            this.customersTab1.TabIndex = 0;
            // 
            // Carts
            // 
            this.Carts.Controls.Add(this.cartsTab1);
            this.Carts.Location = new System.Drawing.Point(4, 22);
            this.Carts.Name = "Carts";
            this.Carts.Size = new System.Drawing.Size(733, 662);
            this.Carts.TabIndex = 2;
            this.Carts.Text = "Carts";
            this.Carts.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            this.cartsTab1.Customers = null;
            this.cartsTab1.Items = null;
            this.cartsTab1.Location = new System.Drawing.Point(3, 3);
            this.cartsTab1.Name = "cartsTab1";
            this.cartsTab1.Size = new System.Drawing.Size(730, 656);
            this.cartsTab1.TabIndex = 0;
            this.cartsTab1.Load += new System.EventHandler(this.cartsTab1_Load);
            // 
            // itemsTab1
            // 
            this.itemsTab1.Items = null;
            this.itemsTab1.Location = new System.Drawing.Point(0, 0);
            this.itemsTab1.MinimumSize = new System.Drawing.Size(730, 656);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(730, 656);
            this.itemsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 687);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(752, 726);
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.Carts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private View.Tabs.ItemsTab itemsTab1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private View.Tabs.ItemsTab itemsTab2;
        private System.Windows.Forms.TabPage tabPage4;
        private View.Tabs.CustomersTab customersTab1;
        private System.Windows.Forms.TabPage Carts;
        private View.Tabs.CartsTab cartsTab1;
    }
}

