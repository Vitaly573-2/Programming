﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PointsDiscount
    {
        private int _points;

        public int Points
        {
            get { return _points; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Баллы должны быть больше нуля ");
                }
                else
                {
                    _points = value;
                }
            }
        }

        public string Info
        {
            get 
            {
                return $"Накопительная - {Points} баллов";
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
            return totalCost;
        }

        //размер скидки для данного списка продуктов 
        public double Calculate(List<Item> items)
        {
            double totalCost = GetTotalCost(items);
            //если кол-во баллов больше 30% от общей стоимости товаров 
            if (Points > totalCost * 0.3)
            {
                //метод для ближайшего меньшего числа 
                return Math.Floor(totalCost * 0.3);
            }
            else
            {
                return Points;
            }
        }

        //применяет скидку к товарам
        //возвращает размер скидки
        //списывает накопленные баллы 
        public double Apply(List<Item> items)
        {
            double discountAmount = Calculate(items);
            Points -= (int)discountAmount;
            return discountAmount;
        }

        //добавляет баллы на основе полученног списка
        //Math.Ceiling возвращает наименьшее целое число с плавающей точкой
        public void Update(List<Item> items)
        {
            double totalCost = GetTotalCost(items);
            Points += (int)Math.Ceiling(totalCost * 0.1);
        }
    }
}
