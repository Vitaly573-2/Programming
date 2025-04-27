using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Класс контакта пользователя, хранящий имя, номер телефона и почту.
    /// </summary>
    public class Contact : INotifyPropertyChanged
    {
        /// <summary>
        /// Поле, хранящее имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле, хранящее почту контакта.
        /// </summary>
        private string _email;
        /// <summary>
        /// Поле, хранящее номер телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Конструктор класса Contact, без параметров.
        /// Инициализирует значениями по умолчанию.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Конструктор Contact с параметрами.
        /// </summary>
        /// <param name="name">Имя Контакта</param>
        /// <param name="phoneNumber">Телефонный номер контакта</param>
        /// <param name="email">Почта контакта</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Получает или задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (_name == value)
                {
                    return;
                }

                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Получает или задаёт номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (_phoneNumber == value)
                {
                    return;
                }

                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Получает или задаёт адрес электронной почты контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (_email == value)
                {
                    return;
                }

                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Событие, которое возникает при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/> для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменённого свойства.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
