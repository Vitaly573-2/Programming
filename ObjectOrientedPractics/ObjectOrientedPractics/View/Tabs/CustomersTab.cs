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
            /*addressControl1 = new AddressControl();*/
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
            /*addressControl1.ListBoxfromCustomersTabState(CustomersListBox.SelectedIndex);*/
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                addressControl1.ListBoxNull = true;
                CustoemersAddButton.Enabled = true;
                CustomersIdTextBox.Text = "";

                CustomersFullNameTextBox.Text = "";
                addressControl1.ClearForm();

                /*AddressRichTextBox.Text = "";*/

            }
            else
            {
                addressControl1.ListBoxNull = false;

                CustoemersAddButton.Enabled = false;


                int selectedIndex = CustomersListBox.SelectedIndex;
                if (selectedIndex == -1) return;

                _currentCustomer = Customers[selectedIndex];

                CustomersIdTextBox.Text = _currentCustomer.Id.ToString();
                CustomersFullNameTextBox.Text = _currentCustomer.FullName;

                addressControl1.ShowValues(_currentCustomer.Address);
                /*AddressRichTextBox.Text = _currentCustomer.Address;*/
            }
        }

/*        private int ListBoxState()
        {
            return CustomersListBox.SelectedIndex;
        }
*/

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
/*        private void UpdateListBox()
        {
            // Очищаем Items в ListBox перед добавлением новых записей
            CustomersListBox.Items.Clear();

            // Добавляем всех клиентов из списка _customers в ListBox
            foreach (Customer customer in _customers)
            {
                // Форматируем строку для каждого клиента и добавляем в ListBox
                string customerInfo = $"ID: {customer.Id}, Full Name: {customer.FullName}, Address: {customer.Address.ToString()}";
                CustomersListBox.Items.Add(customerInfo);
            }

            *//*            CustomersListBox.Items.Clear();
                        foreach (var customer in _customers)
                        {
                            CustomersListBox.Items.Add(customer);
                        }*//*
        }*/

/*        private void UpdateListBoxItem()
        {
            if (_currentCustomer != null && CustomersListBox.SelectedIndex != -1)
            {
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = _currentCustomer;
            }
        }
*/
/*        private void ClearInputField()
        {
            CustomersIdTextBox.Clear();
            CustomersFullNameTextBox.Clear();
            addressControl1.Clear();
            CustomersIdTextBox.BackColor = Color.White;
            CustomersFullNameTextBox.BackColor = Color.White;
        }*/

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
            NewCustomer.Address = addressControl1.GiveValues();
            /*NewCustomer.Address = addressControl1.Address;*/
            /* NewCustomer.Address = AddressRichTextBox.Text;*/


            Customers.Add(NewCustomer);
            CustomersListBoxItems.Add($"{NewCustomer.Id.ToString()})");
            CustomersListBox.Items.Add(CustomersListBoxItems[CustomersListBoxItems.Count - 1]);
            /*CanvaRectanglesListBox.SelectedIndex = CanvaRectanglesListBox.Items.Count - 1;*/

            CustomersFullNameTextBox.Text = "";

            addressControl1.ClearForm();
            /*addressControl1.ListBoxfromCustomersTabState(CustomersListBox.SelectedIndex);*/

            /*AddressRichTextBox.Text = "";*/

        }
    }
}
