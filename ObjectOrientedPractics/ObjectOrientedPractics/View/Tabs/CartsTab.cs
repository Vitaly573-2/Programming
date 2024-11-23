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
            CostLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        public void ClearCart()
        {
            _currentCustomer.Cart.Items.Clear();
            CartsListBox.Items.Clear();
            CostLabel.Text = "None";
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
            if (CustomerComboBox1.SelectedIndex != -1)
            {
                CartsButton.Enabled = true;
                CartsListBox.Items.Clear();
                //очищение DiscountCheckedListBox
                DiscountCheckedListBox.Items.Clear();

                //вывод имен данных объектов
                ItemsListBox.DisplayMember = "Name";
                CustomerComboBox1.DisplayMember = "FullName";
                CartsListBox.DisplayMember = "Name";
                
                //выбираем объект из comdoBox
                _currentCustomer = Customers[CustomerComboBox1.SelectedIndex];
                //_currentCustomer = (Customer)CustomerComboBox1.SelectedItem;
                //добавляем список данного объекта в список корзины
                CartsListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());

                //перебираем все скидки для данного пользователя 
                for(int i = 0; i < _currentCustomer.Discounts.Count; i++)
                {
                    //добавляем у выбранного пользователя информацию о скидках 
                    DiscountCheckedListBox.Items.Add(_currentCustomer.Discounts[i].Info);
                    //заполняем DiscountCheckedListBox где каждая нумерация у нас является выбранной(Cheked)  
                    DiscountCheckedListBox.SetItemChecked(i, true);
                }

            }
            else
            {
                CartsButton.Enabled = false;    
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
                    newOrder = new PriorityOrder(createData, OrderStatus.New, address, items, DateTime.Now, DeliveryTime.From9To11);
                }
                else
                {
                    newOrder = new Order(OrderStatus.New, createData, items, _currentCustomer.Address);
                }

                _currentCustomer.Orders.Add(newOrder);

                DiscountAmountLabel.Text = CreateOrder().ToString();
                ClearCart();
                items.Clear();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearCart();
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
            }
        }

        private void CartsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //обновляем сумму скидки и итоговую суммы заказа
        public void UpdateDiscountAndTotalAmount()
        {
            //сумма скидки
            int discountAmount = 0;
            DiscountAmountLabel.Text = "0";
            //итоговая сумма
            TotalLabel.Text = "0";

            if (_currentCustomer == null) return;

            //перебор всех отмеченных элементов в DiscountCheckedListBox
            foreach (int indexOfDiscounts in DiscountCheckedListBox.CheckedIndices)
            {
                //суммируем скидки выбранного покупателя
                //расчет предоставляемой скидки
                discountAmount +=(int) _currentCustomer.Discounts[indexOfDiscounts].Calculate(_currentCustomer.Cart.Items);  
            }

            //Добавляем сумму скидок
            DiscountAmountLabel.Text = discountAmount.ToString();
            //Добавляем итоговую сумму(вычет суммы корзины и общей скидки)
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
            //сумма скидки
            int discountAmount = 0;
            DiscountAmountLabel.Text = "0";
            TotalLabel.Text= "0";

            if (_currentCustomer == null) return 0;

            //перебор всех отмеченных элементов в DiscountCheckedListBox
            foreach (int IndexOfDiscount in DiscountCheckedListBox.CheckedIndices)
            {
                //суммирует кол-во списанных баллов
                //выполняется для выбранных скидок 
                discountAmount += (int)_currentCustomer.Discounts[IndexOfDiscount].Apply(_currentCustomer.Cart.Items);
            }

            //перебор всех отмеченных элементов в DiscountCheckedListBox
            for (int IndexOfDiscount = 0; IndexOfDiscount < DiscountCheckedListBox.Items.Count; IndexOfDiscount++)
            {
                //для начисления баллов или процентво с нового заказа
                _currentCustomer.Discounts[IndexOfDiscount].Update(_currentCustomer.Cart.Items);
            }

            UpdateDiscountsCheckedListBox();
            return discountAmount;
        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
