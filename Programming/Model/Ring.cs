using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Ring
    {
        private Point2D center;
        private double outradius;
        private double intoradius;

        private double Area
        {
            get
            {
                return Math.PI * (Math.Pow(Outradius, 2) - Math.Pow(Intoradius, 2));
            }
        }

        public Point2D Center
        {
            get { return center; }
            set { center = value; }
        }

        public double Outradius
        {
            get { return outradius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательное значение");
                }
                if(value <= intoradius)
                {
                    throw new ArgumentException("Внешний радиус не может быть меньше внутреннего");
                }
                outradius = value;
            }
        }

        public double Intoradius
        {
            get { return intoradius; }  
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Отрицательное значение");
                }
                if (value >= outradius)
                {
                    throw new ArgumentException("Внутренний радиус не может быть больше внешнего");
                }
                intoradius = value;
            }
        }
    }
}
