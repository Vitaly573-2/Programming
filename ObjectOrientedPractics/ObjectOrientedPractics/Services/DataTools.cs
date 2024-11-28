using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    static class DataTools
    {
        //делегат
        //public delegate bool SortingCriteria(Item item);

        //Func<Item, bool> 
        public static List<Item> Filter(List<Item> items, Func<Item,bool> sortingCriteria)
        {
            List<Item> newItem = new List<Item>();
            foreach (var item in items)
            {
                if (sortingCriteria(item))
                {
                    newItem.Add(item);
                }
            }
            return newItem;
        }
    }
}
