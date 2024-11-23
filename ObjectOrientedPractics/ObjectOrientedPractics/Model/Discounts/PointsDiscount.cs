using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {
        //кол-во баллов 
        private int _accumulatedPoints;

        public int AccumulatedPoints
        {
            get { return _accumulatedPoints; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Баллы должны быть больше нуля ");
                }
                else
                {
                    _accumulatedPoints = value;
                }
            }
        }

        public string Info
        {
            get 
            {
                return $"Накопительная - {AccumulatedPoints} баллов";
            } 
        }

        public double GetTotalCost(List<Item> items)
        {
            double totalCost = 0;
            //если кол-во баллов больше 30% от общей стоимости товаров 
            foreach(var item in items)
            {
                totalCost += item.Cost;
            }
            return Math.Round(totalCost,2);
        }

        //размер скидки для данного списка продуктов 
        public double Calculate(List<Item> items)
        {
            double totalCost = GetTotalCost(items);
            //если кол-во баллов больше 30% от общей стоимости товаров 
            if (AccumulatedPoints > totalCost * 0.3)
            {
                //метод для ближайшего меньшего числа 
                return Math.Floor(totalCost * 0.3);
            }
            return AccumulatedPoints;
        }

        //применяет скидку к товарам
        //возвращает размер скидки
        //списывает накопленные баллы 
        public double Apply(List<Item> items)
        {
            double discountAmount = Calculate(items);
            AccumulatedPoints -= (int)discountAmount;
            return discountAmount;
        }

        //добавляет баллы на основе полученног списка
        //Math.Ceiling возвращает наименьшее целое число с плавающей точкой
        public void Update(List<Item> items)
        {
            double totalCost = GetTotalCost(items);
            AccumulatedPoints += (int)Math.Ceiling(totalCost * 0.1);
        }
    }
}
