using ObjectOrientedPractics.Model;
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

        List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer = new Customer();
        /*private int select = -1;*/


        public CustomersTab()       
        {
            InitializeComponent();
           /* addressControl = new AddressControl();*/
/*            addressControl.Clear();*/
        }

/*        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                UpdateListBox();
            }
        }*/



        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
         /*       addressControl1.IsUpdatingFieldFlag = true;*/
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];

                CustomersIdTextBox.Text = _currentCustomer.Id.ToString();
                CustomersFullNameTextBox.Text = _currentCustomer.FullName;
                addressControl1.Address = _currentCustomer.Address;//AddressTextBox.Text = _currentCustomer.Address;

            }

            /*            if (CustomersListBox.SelectedIndex != -1 || CustomersListBox.SelectedItem != null)
                        {
                            addressControl1.IsUpdatingFieldFlag = true;
                            _currentCustomer = _customers[CustomersListBox.SelectedIndex];

                            CustomersIdTextBox.Text = _currentCustomer.Id.ToString();
                            CustomersFullNameTextBox.Text = _currentCustomer.FullName;
                            addressControl1.Address = _currentCustomer.Address;//AddressTextBox.Text = _currentCustomer.Address;
                            //AddressControl1.UpdateAddressFields();
                        }*/
        }


        private void CustomersPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

/*        private void ClearTextBoxes()//очищение TextBoxes
        {
            CustomersIdTextBox.Clear();
            CustomersFullNameTextBox.Clear();
            AddressControl.Clear();
        }*/

        //Обновлениие записей в ListBox
        private void UpdateListBox()
        {
            /*            // Очищаем Items в ListBox перед добавлением новых записей
                        CustomersListBox.Items.Clear();

                        // Добавляем всех клиентов из списка _customers в ListBox
                        foreach (Customer customer in _customers)
                        {
                            // Форматируем строку для каждого клиента и добавляем в ListBox
                            string customerInfo = $"ID: {customer.Id}, Full Name: {customer.FullName}, Address: {customer.Address.ToString()}";
                            CustomersListBox.Items.Add(customerInfo);
                        }*/

            CustomersListBox.Items.Clear();
            foreach (var customer in _customers)
            {
                CustomersListBox.Items.Add(customer);
            }
        }

        private void UpdateListBoxItem()
        {
            if (_currentCustomer != null && CustomersListBox.SelectedIndex != -1)
            {
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = _currentCustomer;
            }
        }

        private void ClearInputField()
        {
            CustomersIdTextBox.Clear();
            CustomersFullNameTextBox.Clear();
            addressControl1.Clear();
            CustomersIdTextBox.BackColor = Color.White;
            CustomersFullNameTextBox.BackColor = Color.White;
        }

/*        private void UpdateSelectItemListBox()
        {
            if (select != -1)
            {
                Customer selectedCustomer = _customers[select];
                //обновление по выбранному элементу в ItemsListBox
                CustomersListBox.Items[select] = $"Id:{selectedCustomer.Id}" +
                    $"FullName:{selectedCustomer.FullName} Address:{selectedCustomer.Address.ToString()}";
            }
        }*/

        private void CustomersTab_Load(object sender, EventArgs e)
        {

        }

        private void CustomersPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CusoemersAddButton_Click(object sender, EventArgs e)
        {
            /*            if (string.IsNullOrEmpty(CustomersFullNameTextBox.Text))
                        {
                            MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (IsNumeric(CustomersFullNameTextBox.Text))
                        {
                            MessageBox.Show("FullName имеет только строковой тип");
                            return;
                        }

                        // Создаем нового покупателя с использованием имени и адреса
                        Customer customer = new Customer(CustomersFullNameTextBox.Text, addressControl.Address);
                        addressControl.Clear();
                        // Добавляем покупателя в список
                        _customers.Add(customer);

                        // Обновляем список покупателей в ListBox
                        UpdateCustomersListBox();

                        // Очищаем поля ввода
                        ClearTextBoxes();*/

            if (string.IsNullOrEmpty(CustomersFullNameTextBox.Text) || addressControl1.AddressIsNullOrEmpty()  /*string.IsNullOrEmpty(AddressTextBox.Text*/ )
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            Customer NewCustomer = new Customer(CustomersFullNameTextBox.Text, addressControl1.Address);
            _customers.Add(NewCustomer);
            CustomersListBox.Items.Add(NewCustomer);
            /*ClearInputField();*/
        }

/*        private void CustomersAddresTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (select != -1)
            {
                // Получаем адрес из AddressControl
                Address updatedAddress = addressControl.Address;

                // Обновляем адрес выбранного покупателя
                _customers[select].Address = updatedAddress;

                // Обновляем отображение в ListBox
                UpdateSelectItemListBox();

            }
        }*/

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void CustomersFullNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            /*            if (select != -1)
                        {
                            _customers[select].FullName = CustomersFullNameTextBox.Text;
                            UpdateSelectItemListBox();
                        }*/

            if (_currentCustomer != null && CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    if (!string.IsNullOrEmpty(CustomersFullNameTextBox.Text) || !addressControl1.AddressIsNullOrEmpty())
                    {
                        _currentCustomer.FullName = CustomersFullNameTextBox.Text;
                        UpdateListBoxItem();

                        //Решение проблемы съезжания курсора влево
                        CustomersFullNameTextBox.Focus();
                        CustomersFullNameTextBox.Select(CustomersFullNameTextBox.Text.Length, 0);
                    }
                }
                catch (ArgumentException)
                {
                    CustomersFullNameTextBox.BackColor = Color.Pink;
                }
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
            /*            if (CustomersListBox.SelectedIndex != -1)
                        {
                            _customers.RemoveAt(select);
                            UpdateCustomersListBox();
                            select = -1;
                            ClearTextBoxes();
                        }*/
            if (CustomersListBox.SelectedIndex != -1)
            {
              /*  addressControl1.IsUpdatingFieldFlag = false;*/
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                _customers.Remove(_currentCustomer);
                CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
                //CustomersListBox.SelectedIndex = -1;
                ClearInputField();
            }
        }

        private void CustomersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CustomersListBox.IndexFromPoint(e.Location) == -1)
            {
 /*               addressControl1.IsUpdatingFieldFlag = false;*/
                CustomersListBox.ClearSelected();
                ClearInputField();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addressControl1_Load(object sender, EventArgs e)
        {

        }

        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true; // Если хотя бы один символ — цифра, возвращаем true
                }
            }
            return false; // Если нет цифр, возвращаем false
        }

        private void addressControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
