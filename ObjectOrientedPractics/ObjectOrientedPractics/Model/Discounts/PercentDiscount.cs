using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : IDiscount
    {
        //текущая скидка
        private int _currentDiscountPercent;
        //сумма стоимости всех товаров конкретной категории
        private double _accumulatedAmount;
        //категория товаров на которую предоставляется скидка 
        private Category _discountCategory;
        
        public int CurrentDiscountPercent { get; set;}

        public double AccumulatedAmount
        {
            get { return _accumulatedAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Скидка не может быть ниже ннуля");
                }
                else
                {
                    _accumulatedAmount = value;
                }
            }
        }

        public string Info
        {
            get
            {
                return $"Процентная {_discountCategory.ToString()} - {_currentDiscountPercent}";
            }
        }

        //считает и возвращает общую стоимость товаров конкретной категории
        public double GetTotalCost(List<Item> items)
        {
            double totalCost = 0;
            //если кол-во баллов больше 30% от общей стоимости товаров 
            foreach (var item in items)
            {
                totalCost += item.Cost;
            }
            return Math.Round(totalCost, 2);
        }

        public double Calculate(List<Item> items)
        {
            double totalCost = GetTotalCost(items);
            if(CurrentDiscountPercent < 10)
            {
                return CurrentDiscountPercent;
            }
            else
            {
                return 10;
            }
        }

        public double Apply(List<Item> items)
        {
            double totalCost = GetTotalCost(items);
            int discountPersent = (int)Calculate(items);
            double discountAmout = AccumulatedAmount * discountPersent;
            CurrentDiscountPercent -= discountPersent;
            return discountAmout;
            
        }

        public void Update(List<Item> items)
        {
            CurrentDiscountPercent += (int)Math.Floor(AccumulatedAmount / 1000);
        }
    }
}   
