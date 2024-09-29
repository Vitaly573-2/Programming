using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Товары
    /// </summary>
    public class Item
    {
        //идентификационный номер
        private readonly int _id = IdGenerator._currentId;
        //название
        private string _name;
        //информация о товаре
        private string _info;
        //цена
        private double _cost;

        private Category _category;

        //возвращает идентификационный номер
        public int Id
        {
            get 
            {
                return _id;
            }
        }

        //проверяет и возвращает имя
        public string Name
        {
            get
            {
                return _name;
            }
            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        //проверяет и возвращает информацию о товаре
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,  1000, nameof(Info));
                _info = value;
            }
        }

        //проверяет и возвращает цену
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if(value > 0 & value < 100000)
                {
                    _cost = value;
                }
            }
        }

        public Category Category { get; set; }    

        //генерация идентификационного номера
        public Item()
        {
            _id = IdGenerator.GetNextId();
        }

        //присваивание значения свойствам
        public Item(string name, string info, double cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

    }
}
