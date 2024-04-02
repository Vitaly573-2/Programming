﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1 , Rectangle rectangle2)
        {
            double halfWidth1 = rectangle1.Width / 2;
            double halfHeight1 = rectangle1.Length / 2;
            double halfWidth2 = rectangle2.Width / 2;
            double halfHeight2 = rectangle2.Length / 2;

            double deltaX = rectangle1.Center.X - rectangle2.Center.X;
            double deltaY = rectangle1.Center.Y - rectangle2.Center.Y;

            if (deltaX < halfWidth1 + halfWidth2 && deltaY < halfHeight1 + halfHeight2)
            {
                return true; // Прямоугольники пересекаются
            }
            else
            {
                return false; // Прямоугольники не пересекаются
            }
        }

        public static bool isCollision(Ring ring1, Ring ring2)
        {
            double distance = Math.Sqrt(Math.Pow(ring2.Center.X - ring1.Center.X, 2) +  Math.Pow(ring2.Center.Y - ring1.Center.Y, 2));
            if (distance < ring1.Outradius + ring2.Outradius)
            {
                // Проверяем, если одно кольцо вписано в другое
                if (distance + ring1.Intoradius <= ring2.Outradius || distance + ring2.Intoradius <= ring1.Outradius)
                {
                    return true; // Кольца пересекаются
                }
            }

            return false; // Кольца не пересекаются
        }
    }
}
