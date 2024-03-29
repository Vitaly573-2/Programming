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

        public Point2D(double x, double y)
        {
            SetCoordinates(x, y); 
        }
        public double X 
        { 
            get;
            private set;
        }
        public double Y 
        { 
            get; 
            private set;
        }

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
