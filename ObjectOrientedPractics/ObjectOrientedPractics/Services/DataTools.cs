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
        //public delegate bool SortingCriteria(Item item1, Item item2);

        public delegate bool SortingCriteria(Item item1, Item item2);

        public static List<Item> Filter(List<Item> items, Func<Item, bool> sortingCriteria)
        {
            List<Item> newItems = new List<Item>();
            foreach (Item item in items)
            {
                if (sortingCriteria(item))
                {
                    newItems.Add(item);
                }
            }
            return newItems;
        }
        public static List<Item> SortBy(List<Item> items, SortingCriteria sortingCriteria)
        {
            List<Item> sortedList = new List<Item>(items.Count);
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items.Count - 1; j++)
                {
                    if (sortingCriteria(items[j], items[j + 1]))
                    {
                        (items[j], items[j + 1]) = (items[j + 1], items[j]);
                    }
                }
            }
            return items;
        }
    }
}
