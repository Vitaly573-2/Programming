using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order //класс заказа
    {
        private readonly int _id;
        private readonly string  _createtDate;
        private List<Item> _items;
        private Address _createAddress;
        private double _cost = 0;
        private OrderStatus _status;


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
                foreach (var item in Items)
                {
                    _cost += item.Cost;
                }
                if (_cost > 0)
                {
                    return _cost;
                }
                else
                {
                    return _cost= 0;
                }
            }
        }

        public Order()
        {
            CreateDate = "27.10.2004";
            CreateAddress = new Address();
            _status = OrderStatus.New;
            _id += 1;
        }
    }
}
