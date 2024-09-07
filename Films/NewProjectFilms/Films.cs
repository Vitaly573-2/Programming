using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewProjectFilms
{
    public class Films
    {
        private string _name;
        private int _year;
        private double _rating;
        private int _minutes;

        public Films(string name, int year,Genre genre, double rating, int minutes)
        {
            _name = name;
            _year = year;
            Genre = genre;
            _rating = rating;
            _minutes = minutes;
        }

        public Films() {}

        public string _Name
        {
            get { return _name; }
            set 
            { 
                if (value.Length >= 100) 
                {
                    throw new ArgumentException($"Имя не может быть больше 100 символов");
                }
                _name = value; 
            }
        }

        public int _Year
        {
            get { return _year; }
            set
            {
                if ( value < 0)
                {
                    throw new ArgumentException($"Отрицательное число");
                }
                _year = value;
            }
        }

        public Genre Genre { get; set; }

        public double _Rating
        {
            get { return _rating; }
            set
            {
                if (value <= 0 || value >= 10)
                {
                    throw new ArgumentException($"Вещественное число от 0 до 10");
                }
                _rating = value;
            }
        }

        public int _Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 1 || value > 300)
                {
                    throw new ArgumentException($"Целое число от 1 до 300");
                }
                _minutes = value;
            }
        }

    }
}
