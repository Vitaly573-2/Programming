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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ValueslistBox3 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EnumstextBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EnumstextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnumstextBox1 = new System.Windows.Forms.TextBox();
            this.EnumslistBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueslistBox2 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RatingtextBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GenretextBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.YeartextBox1 = new System.Windows.Forms.TextBox();
            this.MinutestextBox2 = new System.Windows.Forms.TextBox();
            this.NametextBox3 = new System.Windows.Forms.TextBox();
            this.MovielistBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.idtextBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CenterYtextBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CenterXtextBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ColortextBox3 = new System.Windows.Forms.TextBox();
            this.WidthtextBox2 = new System.Windows.Forms.TextBox();
            this.LengthtextBox1 = new System.Windows.Forms.TextBox();
            this.EnumslistBox4 = new System.Windows.Forms.ListBox();
            this.Enums.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.tabPage1);
            this.Enums.Controls.Add(this.tabPage2);
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
            this.tabPage1.Controls.Add(this.groupBox3);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ValueslistBox3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(401, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 144);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Season Handle";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Choose season:";
            // 
            // ValueslistBox3
            // 
            this.ValueslistBox3.FormattingEnabled = true;
            this.ValueslistBox3.ItemHeight = 16;
            this.ValueslistBox3.Items.AddRange(new object[] {
            "Winter",
            "Summer",
            "Spring",
            "Autumn"});
            this.ValueslistBox3.Location = new System.Drawing.Point(6, 55);
            this.ValueslistBox3.Name = "ValueslistBox3";
            this.ValueslistBox3.ScrollAlwaysVisible = true;
            this.ValueslistBox3.Size = new System.Drawing.Size(120, 68);
            this.ValueslistBox3.TabIndex = 7;
            this.ValueslistBox3.SelectedIndexChanged += new System.EventHandler(this.ValueslistBox3_SelectedIndexChanged);
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
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // EnumstextBox3
            // 
            this.EnumstextBox3.Location = new System.Drawing.Point(9, 95);
            this.EnumstextBox3.Name = "EnumstextBox3";
            this.EnumstextBox3.Size = new System.Drawing.Size(223, 23);
            this.EnumstextBox3.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnumstextBox2
            // 
            this.EnumstextBox2.Location = new System.Drawing.Point(9, 55);
            this.EnumstextBox2.Name = "EnumstextBox2";
            this.EnumstextBox2.Size = new System.Drawing.Size(223, 23);
            this.EnumstextBox2.TabIndex = 8;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1029, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.RatingtextBox5);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.GenretextBox4);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.YeartextBox1);
            this.groupBox5.Controls.Add(this.MinutestextBox2);
            this.groupBox5.Controls.Add(this.NametextBox3);
            this.groupBox5.Controls.Add(this.MovielistBox1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(510, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(470, 351);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Movie";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(251, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Rating:";
            // 
            // RatingtextBox5
            // 
            this.RatingtextBox5.Location = new System.Drawing.Point(254, 263);
            this.RatingtextBox5.Name = "RatingtextBox5";
            this.RatingtextBox5.Size = new System.Drawing.Size(132, 23);
            this.RatingtextBox5.TabIndex = 11;
            this.RatingtextBox5.TextChanged += new System.EventHandler(this.RatingtextBox5_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(251, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Genre:";
            // 
            // GenretextBox4
            // 
            this.GenretextBox4.Location = new System.Drawing.Point(254, 206);
            this.GenretextBox4.Name = "GenretextBox4";
            this.GenretextBox4.Size = new System.Drawing.Size(132, 23);
            this.GenretextBox4.TabIndex = 9;
            this.GenretextBox4.TextChanged += new System.EventHandler(this.GenretextBox4_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(254, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Find";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(251, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Year:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(251, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Minutes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(251, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Name:";
            // 
            // YeartextBox1
            // 
            this.YeartextBox1.Location = new System.Drawing.Point(254, 152);
            this.YeartextBox1.Name = "YeartextBox1";
            this.YeartextBox1.Size = new System.Drawing.Size(132, 23);
            this.YeartextBox1.TabIndex = 4;
            this.YeartextBox1.TextChanged += new System.EventHandler(this.YeartextBox1_TextChanged);
            // 
            // MinutestextBox2
            // 
            this.MinutestextBox2.Location = new System.Drawing.Point(254, 95);
            this.MinutestextBox2.Name = "MinutestextBox2";
            this.MinutestextBox2.Size = new System.Drawing.Size(132, 23);
            this.MinutestextBox2.TabIndex = 3;
            this.MinutestextBox2.TextChanged += new System.EventHandler(this.MinutestextBox2_TextChanged);
            // 
            // NametextBox3
            // 
            this.NametextBox3.Location = new System.Drawing.Point(254, 39);
            this.NametextBox3.Name = "NametextBox3";
            this.NametextBox3.Size = new System.Drawing.Size(132, 23);
            this.NametextBox3.TabIndex = 2;
            this.NametextBox3.TextChanged += new System.EventHandler(this.NametextBox3_TextChanged);
            // 
            // MovielistBox1
            // 
            this.MovielistBox1.FormattingEnabled = true;
            this.MovielistBox1.ItemHeight = 16;
            this.MovielistBox1.Location = new System.Drawing.Point(15, 29);
            this.MovielistBox1.Name = "MovielistBox1";
            this.MovielistBox1.Size = new System.Drawing.Size(197, 276);
            this.MovielistBox1.TabIndex = 1;
            this.MovielistBox1.SelectedIndexChanged += new System.EventHandler(this.MovielistBox1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.idtextBox1);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.CenterYtextBox1);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.CenterXtextBox1);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.ColortextBox3);
            this.groupBox4.Controls.Add(this.WidthtextBox2);
            this.groupBox4.Controls.Add(this.LengthtextBox1);
            this.groupBox4.Controls.Add(this.EnumslistBox4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(18, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 464);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rectangles";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(254, 336);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "ID";
            // 
            // idtextBox1
            // 
            this.idtextBox1.Location = new System.Drawing.Point(254, 356);
            this.idtextBox1.Name = "idtextBox1";
            this.idtextBox1.ReadOnly = true;
            this.idtextBox1.Size = new System.Drawing.Size(132, 23);
            this.idtextBox1.TabIndex = 13;
            this.idtextBox1.TextChanged += new System.EventHandler(this.idtextBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(254, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Center Y:";
            // 
            // CenterYtextBox1
            // 
            this.CenterYtextBox1.Location = new System.Drawing.Point(254, 297);
            this.CenterYtextBox1.Name = "CenterYtextBox1";
            this.CenterYtextBox1.ReadOnly = true;
            this.CenterYtextBox1.Size = new System.Drawing.Size(132, 23);
            this.CenterYtextBox1.TabIndex = 11;
            this.CenterYtextBox1.TextChanged += new System.EventHandler(this.CenterYtextBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(254, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Center X:";
            // 
            // CenterXtextBox1
            // 
            this.CenterXtextBox1.Location = new System.Drawing.Point(254, 235);
            this.CenterXtextBox1.Name = "CenterXtextBox1";
            this.CenterXtextBox1.ReadOnly = true;
            this.CenterXtextBox1.Size = new System.Drawing.Size(132, 23);
            this.CenterXtextBox1.TabIndex = 9;
            this.CenterXtextBox1.TextChanged += new System.EventHandler(this.CentertextBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(251, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Color:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(251, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Width:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(251, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lenght:";
            // 
            // ColortextBox3
            // 
            this.ColortextBox3.Location = new System.Drawing.Point(254, 178);
            this.ColortextBox3.Name = "ColortextBox3";
            this.ColortextBox3.Size = new System.Drawing.Size(132, 23);
            this.ColortextBox3.TabIndex = 4;
            this.ColortextBox3.TextChanged += new System.EventHandler(this.ColortextBox3_TextChanged);
            // 
            // WidthtextBox2
            // 
            this.WidthtextBox2.Location = new System.Drawing.Point(254, 115);
            this.WidthtextBox2.Name = "WidthtextBox2";
            this.WidthtextBox2.Size = new System.Drawing.Size(132, 23);
            this.WidthtextBox2.TabIndex = 3;
            this.WidthtextBox2.TextChanged += new System.EventHandler(this.WidthtextBox2_TextChanged);
            // 
            // LengthtextBox1
            // 
            this.LengthtextBox1.Location = new System.Drawing.Point(254, 52);
            this.LengthtextBox1.Name = "LengthtextBox1";
            this.LengthtextBox1.Size = new System.Drawing.Size(132, 23);
            this.LengthtextBox1.TabIndex = 2;
            this.LengthtextBox1.TextChanged += new System.EventHandler(this.LengthtextBox1_TextChanged);
            // 
            // EnumslistBox4
            // 
            this.EnumslistBox4.FormattingEnabled = true;
            this.EnumslistBox4.ItemHeight = 16;
            this.EnumslistBox4.Location = new System.Drawing.Point(15, 29);
            this.EnumslistBox4.Name = "EnumslistBox4";
            this.EnumslistBox4.Size = new System.Drawing.Size(197, 276);
            this.EnumslistBox4.TabIndex = 1;
            this.EnumslistBox4.SelectedIndexChanged += new System.EventHandler(this.EnumslistBox4_SelectedIndexChanged);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ValueslistBox3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox EnumslistBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ColortextBox3;
        private System.Windows.Forms.TextBox WidthtextBox2;
        private System.Windows.Forms.TextBox LengthtextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox YeartextBox1;
        private System.Windows.Forms.TextBox MinutestextBox2;
        private System.Windows.Forms.TextBox NametextBox3;
        private System.Windows.Forms.ListBox MovielistBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox GenretextBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox RatingtextBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CenterXtextBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox CenterYtextBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox idtextBox1;
    }
}

