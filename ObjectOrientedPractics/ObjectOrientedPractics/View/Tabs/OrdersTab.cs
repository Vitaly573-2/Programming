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
        List<Customer> customers;
        Customer currentCustomer;

        public List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }

        public void UpdateOrdersTab()
        {
            // Очищаем предыдущие столбцы
            OrderDataGridView.Columns.Clear();

            //Заполнение DataGridView
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Created", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Full Name", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Amount", typeof(string));
            
            //отключение сортировки для DataGridView
            foreach (DataGridViewColumn column in OrderDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            List<Order> orders = new List<Order>();

            for (int i = 0; i < Customers.Count; i++)
            {
                currentCustomer = Customers[i];
                for (int j = 0; j < currentCustomer.Orders.Count; j++)
                {
                    dataTable.Rows.Add(currentCustomer.Id, 
                                       currentCustomer.Orders[j].CreateDate, 
                                       currentCustomer.Orders[j].Status, 
                                       currentCustomer.FullName, 
                                       currentCustomer.Address.AddressToString(), 
                                       currentCustomer.Orders[j].Cost.ToString());
                }
            }
            OrderDataGridView.DataSource = dataTable;

        }

        public OrdersTab()
        {
            InitializeComponent();
        }

        private void OrderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
