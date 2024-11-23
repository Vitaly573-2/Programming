using ObjectOrientedPractics.Model.Discounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    public partial class DiscountCategoryForm : Form
    {
        //свойтсво процентная скидка
        public PercentDiscount Discount { get; set; } = new PercentDiscount();

        public DiscountCategoryForm()
        {
            InitializeComponent();
            //реализация ComboBox
            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
        }

        private void DiscountCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void DiscountAddButton_Click(object sender, EventArgs e)
        {
            if(CategoryComboBox.SelectedItem != null)
            {
                //присваивает скидке выбранную категорию
                Discount.DiscountCategory = (Category)CategoryComboBox.SelectedItem;
                //позволяет вызывающему коду узнать, что пользователь подтвердил
                DialogResult = DialogResult.OK;
                //закрываем форму
                Close();
            }
        }

        private void DiscountCancelButton_Click(object sender, EventArgs e)
        {
            //позволяет вызывающему коду узнать, что пользователь подтвердил
            DialogResult = DialogResult.Cancel; 
            Close();
        }
    }
}
