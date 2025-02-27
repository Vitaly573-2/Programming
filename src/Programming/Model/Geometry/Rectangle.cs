using Programming.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



    internal class Rectangle
    {
        Random random = new Random();
        private double length;
        private double width;
        private string color;
       /* private Point2D center;*/
        private static int _allRectanglesCount;
        private readonly int _id;
        private int _x;
        private int _y;
        

        public Rectangle()
        {
            Rectangle randomRectangle = RectangleFactory.Randomize();
            Length = randomRectangle.length;
            Width = randomRectangle.width;
            Color = string.Empty;
            Center = new Point2D(0, 0);  
            _id = ++_allRectanglesCount;
            X = randomRectangle.X; 
            Y = randomRectangle.Y;
        }
        
        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _id= ++_allRectanglesCount;
        }
        
        public Rectangle(int x, int y, int width, int length)
        {
            X = x;
            Y = y;
            Width = width;
            Length = length;
            _id = ++_allRectanglesCount;
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

        public int X
        {
            get { return _x; }
            set 
            {
                Validator.AssertOnPositiveValue(value, "_X");
                _x = value;
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                Validator.AssertOnPositiveValue(value, "_X");
                _y = value;
            }
        }
        public Point2D Center { get; set; }
    }

