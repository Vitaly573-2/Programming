using ObjectOrientedPractics.Model;
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
        List<Customer> _customers = new List<Customer>();
        private int select = -1;

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                select = CustomersListBox.SelectedIndex;
                Customer selectedCustomer = _customers[select];

                CustomersIdTextBox.Text = selectedCustomer.Id.ToString();
                CustomersFullNameTextBox.Text = selectedCustomer.FullName.ToString();
                CustomersAddresTextBox.Text = selectedCustomer.Address.ToString();
            }
        }

        private void CustomersPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearTextBoxes()//очищение TextBoxes
        {
            CustomersIdTextBox.Clear();
            CustomersFullNameTextBox.Clear();
        }

        //Обновлениие записей в ListBox
        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();//очищает ItemsListBox

            foreach (Customer it in _customers)
            {
                CustomersListBox.Items.Add($"Id:{it.Id} FullName:{it.FullName} Address:{it.Address}");
            }
        }

        private void UpdateSelectItemListBox()
        {
            if (select != -1)
            {
                Customer selectedCustomer = _customers[select];
                //обновление по выбранному элементу в ItemsListBox
                CustomersListBox.Items[select] = $"Id:{selectedCustomer.Id}" +
                    $"FullName:{selectedCustomer.FullName} Address:{selectedCustomer.Address}";
            }
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {

        }

        private void CustomersPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CusoemersAddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomersFullNameTextBox.Text) || string.IsNullOrEmpty(CustomersAddresTextBox.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Customer customer = new Customer(CustomersFullNameTextBox.Text, CustomersAddresTextBox.Text);
            _customers.Add(customer);
            UpdateCustomersListBox();
            ClearTextBoxes();
        }

        private void CustomersAddresTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (select != -1)
            {
                _customers[select].Address = CustomersAddresTextBox.Text;
                UpdateSelectItemListBox();
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void CustomersFullNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (select != -1)
            {
                _customers[select].FullName = CustomersFullNameTextBox.Text;
                UpdateSelectItemListBox();
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
            if (CustomersListBox.SelectedIndex != -1)
            {
                _customers.RemoveAt(select);
                UpdateCustomersListBox();
                select = -1;
                ClearTextBoxes();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
