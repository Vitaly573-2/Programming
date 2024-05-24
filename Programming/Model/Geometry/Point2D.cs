using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Point2D
    {
        private double x;
        private double y;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата y.</param>
        public Point2D(double x, double y)
        {
            SetCoordinates(x, y); 
        }
        /// <summary>
        /// Свойтсво для получения значения.
        /// </summary>
        public double X 
        { 
            get;
            private set;
        }

        /// <summary>
        /// Свойтсво для получения значения.
        /// </summary>
        public double Y 
        { 
            get; 
            private set;
        }

        /// <summary>
        /// Метод для проверки на отрицательное значение.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// /// <param name="y">Координата Y.</param>
        private void SetCoordinates(double x, double y)
        {
            if(x < 0 || y < 0)
            {
                throw new ArgumentException("x", "y");
            }

            X = x; 
            Y = y;
        }
    }
}
