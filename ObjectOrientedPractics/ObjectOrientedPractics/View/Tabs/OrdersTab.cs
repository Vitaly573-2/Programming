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
using ObjectOrientedPractics.Model.Orders;      

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
        List<Order> ordersCurrentCustomer = new List<Order>();
        //выбранный приаритетный заказ  
        PriorityOrder currentPriorityOrder;
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

        public string GetDisplayName(DeliveryTime deliveryTime)
        {
            switch (deliveryTime)
            {
                case DeliveryTime.From9To11:
                    return "9:00 - 11:00";
                case DeliveryTime.From11To13:
                    return "11:00 - 13:00";
                case DeliveryTime.From13To15:
                    return "13:00 - 15:00";
                case DeliveryTime.From15To17:
                    return "15:00 - 17:00";
                case DeliveryTime.From17To19:
                    return "17:00 - 19:00";
                case DeliveryTime.From19To21:
                    return "19:00 - 21:00";
                default:
                    return string.Empty;
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
            //получаем значения из перечисления
            //преобразуем из object в DeliveryTime 
            //каждый элемент преобразуем в строку через метод
            //преобразуем все в список 
            DeliveryTimeComboBox.DataSource = Enum.GetValues(typeof(DeliveryTime)).Cast<DeliveryTime>().Select(range => new {Value = range, Display = GetDisplayName(range)}).ToList();
            //какое свойтсво будет отображаться в ComboBox
            DeliveryTimeComboBox.DisplayMember = "Display";
            //какое свойство будет возвращаться как значение 
            DeliveryTimeComboBox.ValueMember = "Value";

            PriorityOrdersPanel.Enabled = false;
            PriorityOrdersPanel.Visible = false; 
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

                if(currentOrder.GetType() == typeof(PriorityOrder))
                {
                    PriorityOrdersPanel.Enabled = true;
                    PriorityOrdersPanel.Visible = true;
                    currentPriorityOrder = (PriorityOrder)currentOrder;
                    DeliveryTimeComboBox.Text = GetDisplayName(currentPriorityOrder.DeliveryTime);
                }
                else
                {
                    PriorityOrdersPanel.Enabled = false;
                    PriorityOrdersPanel.Visible = false;
                }
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

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentPriorityOrder == null) return;

            currentPriorityOrder.DeliveryTime = (DeliveryTime)DeliveryTimeComboBox.SelectedValue;
            
        }

        private void DeliveryTimePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
