using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {

        private double _amount;
        private List<Item> _items;

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public double Amount
        {
            get
            {
                double value = 0;

                if (value == null && _items.Count == 0)
                {
                    return 0.0;
                }

                foreach (var item in _items)
                {
                    value += item.Cost;
                }
                return value;       
            }
        }
    }
}
