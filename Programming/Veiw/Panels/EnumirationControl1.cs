using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Veiw.Panels
{
    public partial class EnumirationControl1 : UserControl
    {
        public EnumirationControl1()
        {
            InitializeComponent();
            ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Color)).Cast<object>().ToArray());
        }

        private void EnumirationControl1_Load(object sender, EventArgs e)
        {

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ValueslistBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numericValue = (int)ValueslistBox2.SelectedItem;
            EnumstextBox1.Text = numericValue.ToString();
        }
    }
}
