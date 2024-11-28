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
    public partial class CartsTab : UserControl
    {
        Customer _currentCustomer;
        List<Customer> _customers;
        List<Item> _items;

        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public List<Item> Items
        {
            get { return _items; }
            set 
            { 
                _items = value;
            }
        }

        //public Customer CurrentCustomer { get; set;}

        public void RefreshData()
        {
            if (Items != null)
            {
                ItemsListBox.Items.Clear();
                ItemsListBox.Items.AddRange(Items.ToArray());                
/*                foreach (var item in Items)
                {
                    ItemsListBox.Items.Add($"{item.Name} {item.Cost} {item.Category}");
                }*/
            }
            if (Customers != null)
            {
                CustomerComboBox1.Items.Clear();
                CustomerComboBox1.Items.AddRange(Customers.ToArray());
/*                foreach(var customer in Customers)
                {
                    CustomerComboBox1.Items.Add(customer.FullName);
                }*/
            }
        }

        public void UpdateAmount()
        {
            if (_currentCustomer == null)
            {
                CostLabel.Text = "0";
                return;
            };
            CostLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        public void ClearCart()
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.Cart.Items.Clear();
                CartsListBox.Items.Clear();
                CostLabel.Text = "None";
            }
        }

        public CartsTab()
        {
            InitializeComponent();
            CartsButton.Enabled = false;
        }

        private void CartsTab_Load(object sender, EventArgs e)
        {

        }

        private void Items_Click(object sender, EventArgs e)
        {

        }

        private void CartsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox1.SelectedIndex >= 0 && CustomerComboBox1.SelectedIndex < Customers.Count)
            {
                _currentCustomer = Customers[CustomerComboBox1.SelectedIndex];
                CartsButton.Enabled = true;
                CartsListBox.Items.Clear();

                DiscountCheckedListBox.Items.Clear();

                ItemsListBox.DisplayMember = "Name";
                CustomerComboBox1.DisplayMember = "FullName";
                CartsListBox.DisplayMember = "Name";

                CartsListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());

                for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
                {
                    DiscountCheckedListBox.Items.Add(_currentCustomer.Discounts[i].Info);
                    DiscountCheckedListBox.SetItemChecked(i, true);
                }

                UpdateAmount();
                UpdateDiscountAndTotalAmount();
            }
            else
            {
                CartsButton.Enabled = false;
                DiscountCheckedListBox.Items.Clear();
            }
        }

        private void CartsButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                //Добавление выбранного товара в список товаров в корзине
                _currentCustomer.Cart.Items.Add((Item)ItemsListBox.SelectedItem);

                //вывод имен данных объектов
                ItemsListBox.DisplayMember = "Name";
                CustomerComboBox1.DisplayMember = "FullName";
                CartsListBox.DisplayMember = "Name";

                //добавляем в список корзины выбранный товар
                CartsListBox.Items.Add(ItemsListBox.SelectedItem);
                UpdateAmount();
                //обновление скидки и цены со скидкой 
                UpdateDiscountAndTotalAmount();
                ItemsListBox.SelectedIndex = -1;
            }
            //удаление если не выбран товар
            else if (ItemsListBox.SelectedIndex == -1)
            {
                CartsListBox.Items.Clear();
                ItemsListBox.Items.Clear();
                CostLabel.Text = "None";
            }
        }

        private void CostLabel_Click(object sender, EventArgs e)
        {
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartsListBox.SelectedIndex != 0)
            {
                string dateYear = DateTime.Now.Year.ToString();
                string dateMonth = DateTime.Now.Month.ToString();
                string dateDay = DateTime.Now.Day.ToString();
                string dateHour = DateTime.Now.Hour.ToString();
                string dateMinute = DateTime.Now.Minute.ToString();
                string dateSecond = DateTime.Now.Second.ToString();
                string createData = $"{dateDay}:{dateMonth}:{dateYear}-{dateHour}:{dateMinute}:{dateSecond}";
                List<Item> items = _currentCustomer.Cart.Items;
                Address address = _currentCustomer.Address;
                Order newOrder;

                if (_currentCustomer.IsPriority == true)
                {
                    newOrder = new PriorityOrder(createData, OrderStatus.New, address, items, Convert.ToDouble(DiscountAmountLabel.Text), DateTime.Now, DeliveryTime.From9To11);
                }
                else
                {
                    newOrder = new Order(OrderStatus.New, createData, items, _currentCustomer.Address, Convert.ToDouble(DiscountAmountLabel.Text));
                }

                _currentCustomer.Orders.Add(newOrder);

                /*DiscountAmountLabel.Text = CreateOrder().ToString();*/
                CreateOrder();
                //очищение скидки и цены со скидкой 
                ClearDiscountAndTotalLabels();
                ClearCart();
                items.Clear();
                UpdateAmount();
            }
        }

        //очищение надписей скидок и суммы стоимости товаров
        public void ClearDiscountAndTotalLabels()
        {
            DiscountAmountLabel.Text = "0";
            TotalLabel.Text = "0";
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearCart();
            UpdateAmount();
            UpdateDiscountAndTotalAmount();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if(CartsListBox.SelectedIndex != -1)
            {
                //удаление выбранного товара покупателя
                _currentCustomer.Cart.Items.RemoveAt(CartsListBox.SelectedIndex);
                //удаление из CartsListBox
                CartsListBox.Items.RemoveAt(CartsListBox.SelectedIndex);
                UpdateAmount();
                UpdateDiscountAndTotalAmount();
            }
        }

        private void CartsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //обновляем сумму скидки и итоговую суммы заказа
        public void UpdateDiscountAndTotalAmount()
        {
            int discountAmount = 0;
            ClearDiscountAndTotalLabels();

            if (_currentCustomer == null || DiscountCheckedListBox.Items.Count == 0) return;

            foreach (int indexOfDiscounts in DiscountCheckedListBox.CheckedIndices)
            {
                if (indexOfDiscounts >= 0 && indexOfDiscounts < _currentCustomer.Discounts.Count)
                {
                    discountAmount += (int)_currentCustomer.Discounts[indexOfDiscounts].Calculate(_currentCustomer.Cart.Items);
                }
            }

            DiscountAmountLabel.Text = discountAmount.ToString();
            TotalLabel.Text = (_currentCustomer.Cart.Amount - discountAmount).ToString();

        }

        //устанавливаем все фложки для DiscountCheckedListBox
        private void CheckAllItems()
        {
            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                DiscountCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void DiscountCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //обновляем сумму скидки и итоговую суммы заказа
            UpdateDiscountAndTotalAmount();
        }

        private void UpdateDiscountsCheckedListBox()
        {
            //Очищаем список DiscountCheckedListBox
            DiscountCheckedListBox.Items.Clear();

            if (_currentCustomer == null) return;

            for(int i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                //добавляет информацию покупателя в DiscountCheckedListBox
                DiscountCheckedListBox.Items.Add(_currentCustomer.Discounts[i].Info);
            }

            //устанавливаем все фложки для DiscountCheckedListBox
            CheckAllItems();
            //обновляем сумму скидки и итоговую суммы заказа
            UpdateDiscountAndTotalAmount();
        }

        public int CreateOrder()
        {
            int discountAmount = 0;
            ClearDiscountAndTotalLabels();

            if (_currentCustomer == null || DiscountCheckedListBox.Items.Count == 0) return 0;

            foreach (int indexOfDiscount in DiscountCheckedListBox.CheckedIndices)
            {
                if (indexOfDiscount >= 0 && indexOfDiscount < _currentCustomer.Discounts.Count)
                {
                    discountAmount += (int)_currentCustomer.Discounts[indexOfDiscount].Apply(_currentCustomer.Cart.Items);
                }
            }

            for (int indexOfDiscount = 0; indexOfDiscount < _currentCustomer.Discounts.Count; indexOfDiscount++)
            {
                _currentCustomer.Discounts[indexOfDiscount].Update(_currentCustomer.Cart.Items);
            }

            UpdateDiscountsCheckedListBox();
            return discountAmount;
        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
