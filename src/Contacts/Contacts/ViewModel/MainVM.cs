using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс ViewModel для управления контактами
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Объект контакта
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Объект для сериализации контактов
        /// </summary>
        private ContactSerializer _contactSerializer;

        /// <summary>
        /// Команда для сохранения контакта
        /// </summary>
        public ICommand SaveCommand { get; private set; }

        /// <summary>
        /// Команда для загрузки контакта
        /// </summary>
        public ICommand LoadCommand { get; private set; }

        /// <summary>
        /// Конструктор, инициализирующий ViewModel и команды
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            _contactSerializer = new ContactSerializer();

            // Инициализация команд с зависимостями
            SaveCommand = new SaveCommand(_contactSerializer, _contact, UpdateContactFromUI);
            LoadCommand = new LoadCommand(_contactSerializer, SetContact);
        }

        /// <summary>
        /// Обновляет контакт в ViewModel на основе загруженного объекта
        /// </summary>
        /// <param name="contact">Загруженный контакт</param>
        public void SetContact(Contact contact)
        {
            if (_contact == null)
            {
                return;
            }

            _contact.Name = contact.Name;
            _contact.PhoneNumber = contact.PhoneNumber;
            _contact.Email = contact.Email;

            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(PhoneNumber));
            OnPropertyChanged(nameof(Email));
        }

        /// <summary>
        /// Обновляет данные контакта из пользовательского интерфейса (UI)
        /// </summary>
        public void UpdateContactFromUI()
        {
            _contact.Name = this.Name;
            _contact.PhoneNumber = this.PhoneNumber;
            _contact.Email = this.Email;
        }

        /// <summary>
        /// Имя контакта
        /// </summary>
        public string Name
        {
            get { return _contact.Name; }
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged(nameof(Name)); // Уведомление об изменении
                }
            }
        }

        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        public string PhoneNumber
        {
            get { return _contact.PhoneNumber; }
            set
            {
                if (_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Email контакта
        /// </summary>
        public string Email
        {
            get { return _contact.Email; }
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        /// <summary>
        /// Событие, вызывается при изменении свойства
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Уведомляет об изменении свойства
        /// </summary>
        /// <param name="propertyName">Имя измененного свойства</param>
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
