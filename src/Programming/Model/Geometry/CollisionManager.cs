using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    static class CollisionManager
    {
        /// <summary>
        /// Проверка на пересеченение прямоугольников.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        public static bool IsCollision(Rectangle rectangle1 , Rectangle rectangle2)
        {
            // Рассчитываем половинные размеры прямоугольников
            double halfWidth1 = rectangle1.Width / 2;
            double halfHeight1 = rectangle1.Length / 2;
            double halfWidth2 = rectangle2.Width / 2;
            double halfHeight2 = rectangle2.Length / 2;

            // Рассчитываем расстояние между центрами прямоугольников
            double deltaX = Math.Abs(rectangle1.X + halfWidth1 - rectangle2.X - halfWidth2);
            double deltaY = Math.Abs(rectangle1.Y + halfHeight1 - rectangle2.Y - halfHeight2);

            // Проверяем условие пересечения
            if (deltaX < halfWidth1 + halfWidth2 && deltaY < halfHeight1 + halfHeight2)
            {
                return true; // Прямоугольники пересекаются
            }

            return false; // Прямоугольники не пересекаются
        }

        /// <summary>
        /// Проверка на пересеченение окружностей.
        /// </summary>
        /// <param name="ring1">Первая окружность.</param>
        /// <param name="ring2">Вторая окружность.</param>
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
