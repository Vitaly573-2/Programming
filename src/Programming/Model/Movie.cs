using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        /// <summary>
        /// Конструктор с параметром.
        /// </summary>
        /// <param name="name">Имя должно состоять из букв.</param>
        /// <param name="minutes">Минуты должны состоять из цифр.</param>
        /// <param name="year">Год должен состоять из цифр.</param>
        /// <param name="genre">Жанр должен состоять из букв.</param>
        /// <param name="rating">Рэйтинг должен состоять из вещественных чисел.</param>
        public Movie(string name, int minutes, int year, string genre, double rating)
        {
            Name = name;
            Minutes = minutes;
            Year = year;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Конструктор без параметра.
        /// </summary>
        public Movie()
        {
            Name = string.Empty;
            Minutes = 0;
            Year = 0;
            Genre = string.Empty;
            Rating = 0;
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public int Minutes
        {
            get { return minutes; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Minutes));
                minutes = value;
            }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public int Year
        {
            get { return year; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Year));
                year = value;
            }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение.
        /// </summary>
        public double Rating
        {
            get { return rating; }
            set
            {
                Validator.AssertValueInRange(value, 1, 10, nameof(Rating));
                rating = value;
            }
        }
    }
}
