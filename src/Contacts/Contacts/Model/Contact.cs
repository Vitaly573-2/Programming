using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Класс, представляющий контакт 
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя контакта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Электронная почта контакта
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Создаёт пустой контакт
        /// </summary>
        public Contact()
        {
            Name = string.Empty;
            PhoneNumber = string.Empty;
            Email = string.Empty;
        }

        /// <summary>
        /// Создание контакта с заданными параметрами
        /// </summary>
        /// <param name="name">Имя контакта</param>
        /// <param name="phoneNumber">Номер телефона контакта</param>
        /// <param name="email">Электронная почта контакта</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
