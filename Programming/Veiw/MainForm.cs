using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            seasonsHandle1.SeasonChanged += seasonsHandle1_SeasonChanged;

        }

        private Season selectedSeason;

        private void seasonsHandle1_SeasonChanged(object sender, EventArgs e)
        {
            selectedSeason = seasonsHandle1.SelectedSeason;
            switch (selectedSeason)
            {
                case Season.Summer:
                    MessageBox.Show("Ура, солнце");
                    break;
                case Season.Autumn:
                    // Меняем цвета для контролов внутри GroupBox на вкладке "Enum"
                    ChangeBackColorForGroupBoxControls(groupBox1); // Измените на ваш выбранный оранжевый цвет
                    ChangeBackColorForGroupBoxControls(groupBox2); // Измените на ваш выбранный оранжевый цвет
                    break;
                case Season.Winter:
                    MessageBox.Show("БРР, Холодно");
                    break;
                case Season.Spring:
                    // Меняем цвета для контролов внутри GroupBox на вкладке "Enum"
                    ChangeBackColorForGroupBoxControls2(groupBox1); // Измените на ваш выбранный оранжевый цвет
                    ChangeBackColorForGroupBoxControls2(groupBox2); // Измените на ваш выбранный оранжевый цвет
                    break;
            }
        }

            

        private void ChangeBackColorForGroupBoxControls(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                control.BackColor = ColorTranslator.FromHtml("#559c45"); ;
            }
        }

        private void ChangeBackColorForGroupBoxControls2(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                control.BackColor = ColorTranslator.FromHtml("#e29c45");
            }
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


        private void EnumstextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void ValueslistBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void RatingtextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenretextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }


        private void YeartextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinutestextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NametextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MovielistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CentertextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CenterYtextBox1_TextChanged(object sender, EventArgs e)
        {

        }   

        private void idtextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void PaneltextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CanvasPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void EnumstextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnumstextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void seasonsHandle1_Load(object sender, EventArgs e)
        {

        }
    }
}
