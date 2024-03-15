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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
