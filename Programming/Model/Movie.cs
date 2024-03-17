using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Movie
    {
        private string name;
        private int minutes;
        private int year;
        private string genre;
        private double rating;

        public Movie(string name, int minutes, int year, string genre, double rating)
        {
            Name = name;
            Minutes = minutes;
            Year = year;
            Genre = genre;
            Rating = rating;
        }

        public Movie()
        {
            Name = string.Empty;
            Minutes = 0;
            Year = 0;
            Genre = string.Empty;
            Rating = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Отрицательоне значение ");
                }
                minutes = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Отрицательоне значение ");
                }
                year = value;
            }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public double Rating
        {
            get { return rating; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Отрицательоне значение ");
                }
                rating = value;
            }
        }
    }
}
