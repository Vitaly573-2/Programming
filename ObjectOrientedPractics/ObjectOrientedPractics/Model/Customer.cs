using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель
    /// </summary>
    class Customer
    {
        //идентификационный номер
        private readonly int _id;
        //ФИО
        private string _fullname;
        //адресс 
        private string _address;

        //возвращает идентификационный номер
        public int Id
        {
            get
            {
                return Id;
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
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        //генерация идентификационного номера
        public Customer()
        {
            _id = IdGenerator.GetNextId();
        }

        //присваивание значения свойствам
        public Customer(string fullname, string address)
        {
            FullName = fullname;
            Address = address;
        }
    }
}
