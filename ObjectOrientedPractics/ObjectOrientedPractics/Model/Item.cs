using ObjectOrientedPractics.Model.Discounts;
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

    [Serializable]
    public class Item : ICloneable, IComparable<Item>
    {
        //идентификационный номер
        private readonly int _id = IdGenerator._currentId;
        //название
        private string _name;
        //информация о товаре
        private string _info;
        //цена
        private double _cost;

        /// <summary>
        /// Событие изменения названия товара.
        /// EventHandler<>
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;
        /// <summary>
        /// Событие изменения описания товара.
        /// на основе делегата EventHandler<>
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;
        /// <summary>
        /// Событие изменения стоимости товара.
        /// EventHandler<>
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;   

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
                NameChanged?.Invoke(this, EventArgs.Empty);
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
                NameChanged?.Invoke(this, EventArgs.Empty);
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
                    NameChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Автосвойство категории товара
        /// </summary>
        public Category Category { get; set; }    

        //конструктор копирования 
        public object Clone()
        {
            return new Item(this.Name, this.Info, this.Cost, this.Category);
        }

        //реализация сравнения объектов 
        public override bool Equals(object other)
        {
            if (other == null) 
                return false;
            if (other.GetType() != typeof(Item)) 
                return false;
            //определяет совпадают ли указанные экзепляры
            if (object.ReferenceEquals(this,other))
                return true;
            Item item = (Item)other;
            return (this.Name == item.Name && this.Info == item.Info && this.Cost == item.Cost && this.Category == item.Category);
        }

        //сравнивает объекты между собой, аналгичен IEquatable
        public int CompareTo(Item item2)
        {
            if (object.ReferenceEquals(this, item2))
                return 0;
            if (item2 is null)
                return 1; //текущий объект больше нуля 
            if (Cost > item2.Cost)
                return 1;
            if (Cost < item2.Cost)
                return -1;
            else if (Cost == item2.Cost)
                return 0;
            return 1;
        }

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
