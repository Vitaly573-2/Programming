using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель
    /// </summary>
    [Serializable]
    public class Customer
    {
        //идентификационный номер
        readonly int _id;
        //ФИО
        private string _fullname;
        //адресс 
        private Address _address;

        //корзина товаров
        Cart _cart;

        private List<Order> _orders;

        private List<IDiscount> _discounts;



        //возвращает идентификационный номер
        public int Id
        {
            get
            {
                return _id;
            }
        }

        //проверяет и возвращает ФИО
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullname = value;
            }
        }

        //проверяет и возвращает адресс
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                //ValueValidator.AssertStringOnLength(value.ToString(), 500, nameof(Address));
                _address = value;
            }
        }

        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        //корзина агрегирует список товаров
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        public bool IsPriority { get; set; }

        public List<IDiscount> Discounts { get; set; }

        //присваивание значения свойствам
        public Customer(string fullname)
        {
            FullName = fullname;
            Address = new Address();
            _id = IdGenerator.GetNextId();
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }


        //покапатель композирует объект корзины
        //генерация идентификационного номера
        public Customer() 
        {
            Address = new Address();
            FullName = string.Empty;
            _id = IdGenerator.GetNextId();
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }

/*        public override string ToString()
        {
            return $"{Id} - {FullName}";
        }*/
    }
}
