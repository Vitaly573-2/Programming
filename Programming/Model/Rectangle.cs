using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Rectangle
    {
        private double length;
        private double width;
        private string color;


        public Rectangle()
        {
            Length = 0;
            Width = 0;
            Color = string.Empty;    
        }

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Отрицательоне значение ");
                }
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <  0)
                {
                    throw new ArgumentOutOfRangeException("Отрицательное значение ");
                }
                width = value;
            }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }

