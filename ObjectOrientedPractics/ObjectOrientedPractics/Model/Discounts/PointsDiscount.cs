using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    //накопительная скидка
    public class PointsDiscount : IDiscount
    {
        //кол-во накопленных баллов
        private int _accumulatedPoints;

        public int AccumulatedPoints
        {
            get { return _accumulatedPoints; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Баллы должны быть больше нуля ");
                }
                else
                {
                    _accumulatedPoints = value;
                }
            }
        }

        //вывод информации о накопительных баллов
        public string Info
        {
            get 
            {
                return $"Накопительная - {AccumulatedPoints} баллов";
            } 
        }

        //подсчет суммы корзины
        public double GetAmount(List<Item> items)
        {
            double sum = 0;
            foreach(var item in items)
            {
                sum += item.Cost;
            }
            return Math.Round(sum,2);
        }

        //возвращает размер скидки для данного списка продуктов и накопленные баллы
        //вызывается перед оформлением заказа для оценки возможной скидки
        public double Calculate(List<Item> items)
        {
            double amount = GetAmount(items);
            //если кол-во баллов больше 30% от общей стоимости товаров 
            if (AccumulatedPoints > amount * 0.3)
            {
                //метод для ближайшего меньшего числа 
                return Math.Floor(amount * 0.3);
            }
            //возвращает текущее кол-во баллов
            return AccumulatedPoints;
        }

        //вызывается в том случае, если скидка действительна применяется к будущему заказу
        public double Apply(List<Item> items)
        {
            double discountAmount = Calculate(items);
            //списывает накопленные баллы
            AccumulatedPoints -= (int)discountAmount;
            //возвращает размер скидки
            return discountAmount;
        }

        //добавляет баллы на основе полученног списка
        //Math.Ceiling округляет в большую сторону
        //вызывается после каждой покупки, покупатель должен получить баллы
        public void Update(List<Item> items)
        {
            double amount = GetAmount(items);
            //добавляем к баллом по 10% от общей стоимости корзины 
            AccumulatedPoints += (int)Math.Ceiling(amount * 0.1);
        }
    }
}
