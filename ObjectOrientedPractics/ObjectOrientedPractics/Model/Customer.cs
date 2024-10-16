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
    public class Customer
    {
        //идентификационный номер
        readonly int _id;
        //ФИО
        private string _fullname = string.Empty;
        //адресс 
        private Address _address = new Address();

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

        //присваивание значения свойствам
        public Customer(string fullname, Address address)
        {
            FullName = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
        }

        //генерация идентификационного номера
        public Customer()   
        {
            Address = new Address();
            FullName = string.Empty;
            _id = IdGenerator.GetNextId();
        }

        public override string ToString()
        {
            return $"{Id} - {FullName}";
        }
    }
}
