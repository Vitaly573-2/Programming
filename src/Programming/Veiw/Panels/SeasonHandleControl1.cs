using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Programming.Veiw.Panels
{
    public partial class SeasonHandleControl1 : UserControl
    {
        /// <summary>
        /// Длбавление перечислений в ListBox.
        /// </summary>
        public SeasonHandleControl1()
        {
            InitializeComponent();
            object[] seasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            SeasonCombotBox.Items.AddRange(seasonValues);
        }

        public event EventHandler SeasonChanged;

        protected virtual void OnSeasonChanged(EventArgs e)
        {
            SeasonChanged?.Invoke(this, e);
        }


        /// <summary>
        /// Обработчик события для вывода действий по индексу.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (SeasonCombotBox.SelectedItem == null)
            {
                SeasonCombotBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            SeasonCombotBox.BackColor = System.Drawing.Color.White;
            switch (SeasonCombotBox.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура, солнце");
                    break;
                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Winter:
                    MessageBox.Show("БРР, Холодно");
                    break;
                case Season.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;

            }
            // После обработки изменения времени года вызываем метод OnSeasonChanged для генерации события
            OnSeasonChanged(EventArgs.Empty);


        }

        /// <summary>
        /// Возращает выбранный сезон.
        /// </summary>
        public Season SelectedSeason
        {
            get
            {
                return (Season)SeasonCombotBox.SelectedItem;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void ValueslistBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeasonCombotBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void SeasonHandleControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
