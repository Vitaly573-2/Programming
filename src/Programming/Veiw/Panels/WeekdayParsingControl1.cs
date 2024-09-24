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
    public partial class WeekdayParsingControl1 : UserControl
    {
        public WeekdayParsingControl1()
        {
            InitializeComponent();
        }

        private void WeekdayParsingControl1_Load(object sender, EventArgs e)
        {

        }

        private void EnumstextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработчик событий для проверки дня недели по индексу или по слову.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = EnumstextBox2.Text.Trim();
            if (Enum.TryParse<Weekday>(userInput, out Weekday parsedWeekday))
            {
                int numericValue = (int)parsedWeekday;
                if (numericValue <= 7)
                {
                    EnumstextBox3.Text = $"Этот день недели {parsedWeekday} = {numericValue}";
                }
                else
                {
                    EnumstextBox3.Text = "Нет такого дня недели";
                }

            }
            else
            {
                EnumstextBox3.Text = "Нет такого дня недели";
            }
        }

        private void EnumstextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
