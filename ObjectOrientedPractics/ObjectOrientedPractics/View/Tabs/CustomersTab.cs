using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        //список
        private List<Customer> _customers = new List<Customer>();
        //объект
        private Customer _currentCustomer = new Customer();
        //список объектов в ListBox
        private List<string> CustomersListBoxItems = new List<string>();

        //свойтво явязанное со списком 
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public CustomersTab()       
        {
            InitializeComponent();
        }




        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*addressControl1.ListBoxfromCustomersTabState(CustomersListBox.SelectedIndex);*/
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                addressControl1.ListBoxNull = true;
                CustoemersAddButton.Enabled = true;
                CustomersIdTextBox.Text = "";

                CustomersFullNameTextBox.Text = "";
                //флажок выключен
                IsPriorityCheckBox.Checked = false;
                //очистка окно скидок 
                DiscountsListBox.Items.Clear();
                addressControl1.ClearForm();

                /*AddressRichTextBox.Text = "";*/

            }
            else
            {
                //очистка окна скидок перед заполнением 
                DiscountsListBox.Items.Clear();
                addressControl1.ListBoxNull = false;

                CustoemersAddButton.Enabled = false;


                int selectedIndex = CustomersListBox.SelectedIndex;
                if (selectedIndex == -1) return;

                _currentCustomer = Customers[selectedIndex];

                CustomersIdTextBox.Text = _currentCustomer.Id.ToString();
                CustomersFullNameTextBox.Text = _currentCustomer.FullName;
                //флажок равняется свойству в классе customer
                IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;

                addressControl1.ShowValues(_currentCustomer.Address);
                /*AddressRichTextBox.Text = _currentCustomer.Address;*/

                //отображение скидки у данного покупателя 
                foreach(var discount in _currentCustomer.Discounts)
                {
                    DiscountsListBox.Items.Add(discount.Info);
                }
            }
        }


        private void CustomersPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void CustomersTab_Load(object sender, EventArgs e)
        {

        }

        private void CustomersPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void CustomersFullNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if ((CustomersListBox.SelectedIndex != -1))
            {
                _currentCustomer.FullName = CustomersFullNameTextBox.Text;
            }
        }

        private void CustomersIdTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CstomersRemoveButton_Click_1(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;


            if (selectedIndex == -1) return;

            Customers.RemoveAt(selectedIndex);
            CustomersListBoxItems.RemoveAt(selectedIndex);
            CustomersListBox.Items.RemoveAt(selectedIndex);

            CustomersFullNameTextBox.Text = "";
            /*IsPriorityCheckBox.Checked = false;*/
            /*AddressRichTextBox.Text = "";*/
        }

        private void CustomersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CustomersListBox.IndexFromPoint(e.Location) == -1)
            {
                // Если кликнули на пустое место, сбрасываем выбор
                addressControl1.ListBoxNull = true;
                CustomersListBox.ClearSelected();
                CustomersListBox.SelectedIndex = -1;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addressControl1_Load(object sender, EventArgs e)
        {

        }

        private void addressControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void CustoemersAddButton_Click_1(object sender, EventArgs e)
        {
    

            Customer NewCustomer = new Customer();
            NewCustomer.FullName = CustomersFullNameTextBox.Text;
            NewCustomer.IsPriority = IsPriorityCheckBox.Checked;
            NewCustomer.Address = addressControl1.GiveValues();
            /*NewCustomer.Address = addressControl1.Address;*/
            /* NewCustomer.Address = AddressRichTextBox.Text;*/


            Customers.Add(NewCustomer);
            CustomersListBoxItems.Add($"{NewCustomer.Id.ToString()})");
            CustomersListBox.Items.Add(CustomersListBoxItems[CustomersListBoxItems.Count - 1]);
            /*CanvaRectanglesListBox.SelectedIndex = CanvaRectanglesListBox.Items.Count - 1;*/

            CustomersFullNameTextBox.Text = "";
            IsPriorityCheckBox.Checked = false;
            addressControl1.ClearForm();
            /*addressControl1.ListBoxfromCustomersTabState(CustomersListBox.SelectedIndex);*/

            /*AddressRichTextBox.Text = "";*/

        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DiscountsAddButton_Click(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex != -1)
            {
                //появляется форма с выбором категории для которой будет применина скидка 
                DiscountCategoryForm discountCategoryForm = new DiscountCategoryForm();
                if(discountCategoryForm.ShowDialog() == DialogResult.OK)
                {
                    //добавляем в скидку(интерфейс) процентную скидку(PercentDiscount) 
                    _currentCustomer.Discounts.Add(discountCategoryForm.Discount);
                    //добавление информации на DiscountListBox
                    DiscountsListBox.Items.Add(discountCategoryForm.Discount.Info);
                }
            }
        }

        private void DiscountsRemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                //проверка типа данной скидки на не равенство накопительной 
                if (_currentCustomer.Discounts[DiscountsListBox.SelectedIndex].GetType() != typeof(PointsDiscount))
                {
                    //удаляем выбранную скидку из списка данного пользователя
                    _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
                    //удаляем ли DiscountsListBox   
                    DiscountsListBox.Items.RemoveAt(DiscountsListBox.SelectedIndex);
                }
            }
        }
    }
}
