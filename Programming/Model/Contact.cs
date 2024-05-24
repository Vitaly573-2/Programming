using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        private string name;
        private string surname;
        private int number;

        /// <summary>
        /// Проверяет, содержит ли строка только буквы.
        /// </summary>
        /// <param name="value">Строка для проверки.</param>
        /// <param name="propertyName">Имя проверяемого свойства.</param>
        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException($"некорректное значение в {propertyName}, напишете на английском языке");
            }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение, проверяет.
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                name = value;
            }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение, проверяет.
        /// </summary>
        public string Surname
        {
            get { return surname; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                surname = value;
            }
        }

        /// <summary>
        /// Свойство, которое задает и получает значение,проверяет.
        /// </summary>
        public int Number
        {
            get { return number; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Number));
                number = value;
            }
        }
    }
}
