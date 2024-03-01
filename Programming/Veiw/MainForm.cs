using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Color)).Cast<object>().ToArray());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Enums_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValueslistBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numericValue = (int)ValueslistBox2.SelectedItem;
            EnumstextBox1.Text = numericValue.ToString();
        }

        private void EnumslistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueslistBox2.Items.Clear();
            switch (EnumslistBox1.SelectedIndex)
            {
                case 0:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Color)).Cast<object>().ToArray());
                    break;
                case 1:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Education)).Cast<object>().ToArray());
                    break;
                case 2:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Genre)).Cast<object>().ToArray());
                    break;
                case 3:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
                    break;
                case 4:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Smartphone)).Cast<object>().ToArray());
                    break;
                case 5:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Weekday)).Cast<object>().ToArray());
                    break;
            }
        }

        private void EnumstextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = EnumstextBox2.Text.Trim();
            if (Enum.TryParse<Weekday>(userInput, out Weekday parsedWeekday))
            {
                int numericValue = (int)parsedWeekday;
                EnumstextBox3.Text = $"Этот день недели {parsedWeekday} = {numericValue}";
            }
            else
            {
                EnumstextBox3.Text = "Нет такого дня недели";
            }

        }
    }
}
