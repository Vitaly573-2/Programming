using Programming.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



    internal class Rectangle
    {
        private double length;
        private double width;
        private string color;
        private Point2D center;
        private static int _allRectanglesCount;
        private readonly int _id;
        

        public Rectangle()
        {
            Length = 0;
            Width = 0;
            Color = string.Empty;
            Center = new Point2D(0, 0);
            _allRectanglesCount++;  
            _id = _allRectanglesCount;
        
        }

        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _id= ++_allRectanglesCount;
        }

        public static int AllRectanglesCount
        {
            get{ return _allRectanglesCount; }
        }
            

        public int Id
        {
            get { return _id; }
        }      

        public double Length
        {
            get { return length; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
            Validator.AssertOnPositiveValue(value, nameof(Width));
            width = value;
            }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Point2D Center
        {
        get { return center; }
        set { center = value; }
        }
    }

