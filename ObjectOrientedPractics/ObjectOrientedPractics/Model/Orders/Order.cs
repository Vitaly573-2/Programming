using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    public class Order //класс заказа
    {
        private readonly int _id;
        private readonly string  _createtDate;
        private List<Item> _items;
        private Address _createAddress;
        private double _cost;
        private OrderStatus _status;
        private double _discountAmount;


        public int ID
        {
            get { return _id; }
        }

        public string CreateDate {  get; }

        public Address CreateAddress
        {
            get { return _createAddress; }
            set { _createAddress = value; }
        }

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public double Cost
        {
            get 
            {
                double sum = 0.0;
                foreach (var item in Items)
                {
                    sum += item.Cost;
                }
                if (sum > 0)
                {
                    return _cost = sum;
                }
                else
                {
                    return _cost= 0.0;
                }
            }
        }

        //размер применяемой скидки
        public double DiscountAmount
        {
            get { return _discountAmount; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Скидка не может равняться отрицательному значению");
                }
                _discountAmount = value;
            }
        }

        public double Total
        {
            get
            {
                return Cost - DiscountAmount;
            }
        }

        public Order()
        {
            CreateDate = "27.10.2004";
            CreateAddress = new Address();
            Status = OrderStatus.New;
            _id += 1;
        }

        public Order(OrderStatus status, string createDate, List<Item> _items, Address address, double disountAmount)
        {
            _id += 1;
            CreateDate = createDate;
            Status = status;
            Items = new List<Item>(_items);
            CreateAddress = address;
            DiscountAmount = disountAmount;
        }
    }
}
