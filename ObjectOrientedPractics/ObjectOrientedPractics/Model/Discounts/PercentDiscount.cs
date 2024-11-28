using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    //процентная скидка на конкретную категорию
    public class PercentDiscount : IDiscount
    {
        //текущая скидка
        private int _currentDiscountPercent;
        //сумма стоимости всех товаров конкретной категории
        private double _accumulatedAmount;
        //категория товаров на которую предоставляется скидка 
        private Category _discountCategory;
        
        public int CurrentDiscountPercent
        {
            get { return _currentDiscountPercent; }
            set 
            { 
                if(value <= 10)
                {
                    _currentDiscountPercent = value;
                }
            }
        }

        public Category DiscountCategory
        {
            get
            {
                return _discountCategory;
            }
            set
            {
                _discountCategory = value;
            }
        }

        public double AccumulatedAmount
        {
            get { return _accumulatedAmount; }
            private set
            {
                _accumulatedAmount = value;
            }
        }

        //текущая скидка данной категории
        public string Info
        {
            get
            {
                return $"Процентная {DiscountCategory.ToString()} - {CurrentDiscountPercent}";
            }
        }

        //подсчет суммы корзины
        public double GetAmount(List<Item> items)
        {
            double sum = 0;
            //если кол-во баллов больше 30% от общей стоимости товаров 
            foreach (var item in items)
            {
                sum += item.Cost;
            }
            return Math.Round(sum, 2);
        }

        //рассчет скидки с учетом процента
        public double Calculate(List<Item> items)
        {
            double amount = GetAmount(items);
            //(2000 * (5 /100)) = 100
            double res = amount * (CurrentDiscountPercent / 100.0);
            return res; 
        }

        //получение общей стоимости товаров в корзине
        public double Apply(List<Item> items)
        {
            double discountAmount = GetAmount(items);
            return discountAmount;
            
        }

        //добавление по проценту за покупку в 1000р 
        public void Update(List<Item> items)
        {
            int updateRes = (int)(GetAmount(items) / 1000);
            for(int percent = 0; percent < updateRes; percent++)
            {
                CurrentDiscountPercent += 1;
            }
        }
        
        //текущая скидка равна 1
        public PercentDiscount()
        {
            CurrentDiscountPercent = 1;
        }
    }
}   
