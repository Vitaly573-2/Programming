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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ValueslistBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EnumslistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
