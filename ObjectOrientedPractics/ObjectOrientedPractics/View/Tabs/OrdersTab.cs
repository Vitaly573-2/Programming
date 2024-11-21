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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        //список покупателей
        List<Customer> customers;
        //выбранный покупатель
        Customer currentCustomer;
        //выбранный заказ покупателя
        Order currentOrder;
        //список всех заказов покупателя 
        List<Order> ordersCurrentCustomer =  new List<Order>(); 
        //Работа с DataGridView
        DataTable dataTable = new DataTable();

        /*public List<Order> Orders { get; set; }*/

        public List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }

        public void UpdateOrdersTab()
        {
            // Очищаем предыдущие столбцы
            dataTable.Clear();
            //OrderDataGridView.Columns.Clear();
            
            //отключение сортировки для DataGridView
            foreach (DataGridViewColumn column in OrderDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //List<Order> orders = new List<Order>();
            ordersCurrentCustomer.Clear();
                    
            for (int i = 0; i < Customers.Count; i++)
            {
                currentCustomer = Customers[i];
                for (int j = 0; j < currentCustomer.Orders.Count; j++)
                {
                    ordersCurrentCustomer.Add(currentCustomer.Orders[j]);
                    dataTable.Rows.Add(currentCustomer.Orders[j].ID, 
                                       currentCustomer.Orders[j].CreateDate, 
                                       currentCustomer.Orders[j].Status, 
                                       currentCustomer.FullName, 
                                       currentCustomer.Address.AddressToString(), 
                                       currentCustomer.Orders[j].Cost.ToString());
                }
            }
            OrderDataGridView.DataSource = dataTable;

        }

        //подсчет цены
        public void UpdateAmount()
        {
            if (currentOrder != null)
            {
                OrderItemsLabel.Text = currentOrder.Cost.ToString();
            }
            else
            {
                OrderItemsLabel.Text = "0";
            }
        }
            
        public OrdersTab()
        {
            InitializeComponent();
            //Заполнение DataGridView
            StatusComboBox.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Created", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Full Name", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Amount", typeof(string));
        }

        private void OrderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(OrderDataGridView.CurrentCell != null && OrderDataGridView.CurrentCell.RowIndex != -1)
            {
                OrderListBox.Items.Clear();
                currentOrder = ordersCurrentCustomer[OrderDataGridView.CurrentCell.RowIndex];
                IdTextBox.Text = currentOrder.ID.ToString();
                CreatedTextBox.Text = currentOrder.CreateDate.ToString();
                StatusComboBox.Text = currentOrder.Status.ToString();
                addressControl1.ShowValues(currentOrder.CreateAddress);
                OrderListBox.Items.AddRange(currentOrder.Items.ToArray());
                OrderListBox.DisplayMember = "Name";
                UpdateAmount();

            }
        }

        private void OrdersTab_Load(object sender, EventArgs e)
        {

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderDataGridView.CurrentCell.RowIndex != -1 && OrderDataGridView.CurrentCell.RowIndex != null)
            {
                currentOrder.Status = (OrderStatus)StatusComboBox.SelectedItem;
                dataTable.Rows[OrderDataGridView.CurrentCell.RowIndex][2] = currentOrder.Status.ToString();
            }
        }

        private void addressControl1_Load(object sender, EventArgs e)
        {

        }

        private void OrderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
