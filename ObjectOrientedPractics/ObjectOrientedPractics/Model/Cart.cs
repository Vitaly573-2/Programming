using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        private List<Item> _items;

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public double _amount;

        public double Amount
        {
            get
            {
                double sum = 0;

                foreach (var item in Items)
                {
                    sum += item.Cost;
                }
                if (sum >=0)
                {
                    return _amount = sum;
                }
                else
                {
                    return _amount = 0.0;
                }       
            }
        }

        public Cart()
        { 
            Items = new List<Item>();  
        }

    }
}
