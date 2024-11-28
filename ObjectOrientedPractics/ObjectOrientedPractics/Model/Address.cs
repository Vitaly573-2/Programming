using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Address : ICloneable
    {
        private int _index; 
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    throw new ArgumentException("Индекс должен быть шестизначным числом.");
                }
                _index = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                if (value.Length <= 50)
                {
                    _country = value;
                }
                else
                {
                    throw new ArgumentException("Индекс должен быть шестизначным числом.");
                }
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                if (value.Length <= 50)
                {
                    _city = value;
                }
                else
                {
                    throw new ArgumentException("Индекс должен быть шестизначным числом.");
                }
            }
        }

        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                if(value.Length <= 100)
                {
                    _street = value;
                }
                else
                {
                    throw new ArgumentException("Индекс должен быть шестизначным числом.");
                }
            }
        }

        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                if (value.Length <= 10)
                {
                    _building = value;
                }
                else
                {
                    throw new ArgumentException("Индекс должен быть шестизначным числом.");
                }
            }
        }

        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                if(value.Length <= 10)
                {
                    _apartment = value;
                }
                else
                {
                    throw new ArgumentException("Индекс должен быть шестизначным числом.");
                }
            }
        }

        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment);
        }

        //реализация сравнения объектов 
        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (other.GetType() != typeof(Address))
                return false;
            //определяет совпадают ли указанные экзепляры
            if (object.ReferenceEquals(this, other))
                return true;
            Address address = (Address)other;
            return (this.Index == address.Index && this.Country == address.Country && this.City == address.City && 
                    this.Street == address.Street && this.Building == address.Building && this.Apartment == address.Apartment);
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }

        public string AddressToString()
        {
            return Index.ToString() + " " + Country + " " + City + " " + Street + " " + Building + " " + Apartment;
        }
    }
}
