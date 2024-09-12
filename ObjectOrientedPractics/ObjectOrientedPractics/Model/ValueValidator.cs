using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Валидация
    /// </summary>
    class ValueValidator
    {
        public static void AssertStringOnLength(string value, int MaxLength, string propertyName)
        {
            if (value.Length >= MaxLength)
            { 
                throw new ArgumentException($" {propertyName} должен быть меньше {MaxLength} символов");
            }
        }
    }
}
