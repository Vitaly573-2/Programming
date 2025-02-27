using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Validator
    {
        /// <summary>
        /// Проверка на отрицательное значение.
        /// </summary>
        /// <param name="value">Строка для проверки.</param>
        /// <param name="propertyName">Имя проверяемого свойства.</param>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Отрицательоне значение в {propertyName}");
            }
        }

        /// <summary>
        /// Проверка на отрицательное значение.
        /// </summary>
        /// <param name="value">Строка для проверки.</param>
        /// <param name="propertyName">Имя проверяемого свойства.</param>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Отрицательоне значение в {propertyName}");
            }
        }

        /// <summary>
        /// Проверка сходимости числа в определенном диапозоне.
        /// </summary>
        /// <param name="value">Строка для проверки.</param>
        /// <param name="min">Минимальное число.</param>
        /// <param name="min">Максимальное число.</param>
        /// <param name="propertyName">Имя проверяемого свойства.</param>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Некорректное значение в {propertyName}");
            }
        }

        /// <summary>
        /// Проверка сходимости числа в определенном диапозоне.
        /// </summary>
        /// <param name="value">Строка для проверки.</param>
        /// <param name="min">Минимальное число.</param>
        /// <param name="min">Максимальное число.</param>
        /// <param name="propertyName">Имя проверяемого свойства.</param>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Некорректное значение в {propertyName}");
            }
        }
    }
}
