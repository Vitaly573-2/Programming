using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для загрузки контакта из файла
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Сериализатор контактов
        /// </summary>
        private ContactSerializer _contactSerializer;

        /// <summary>
        /// Делегат, используется для обновления состояния контакта
        /// </summary>
        private Action<Contact> _setContact;

        /// <summary>
        /// Конструктор команды загрузки контакта
        /// </summary>
        /// <param name="contactSerializer">Сериализатор контактов</param>
        /// <param name="setContact">Делегат для установки загруженного контакта</param>
        /// <exception cref="ArgumentException">Вызывается, если передан null</exception>
        public LoadCommand(ContactSerializer contactSerializer, Action<Contact> setContact)
        {
            _contactSerializer = contactSerializer ?? throw new ArgumentException(nameof(contactSerializer));
            _setContact = setContact ?? throw new ArgumentException(nameof(setContact));
        }

        /// <summary>
        /// Определяет, можно ли выполнить команду
        /// </summary>
        /// <param name="parametr">Параметр команды</param>
        /// <returns>True</returns>
        public bool CanExecute(object parametr)
        {
            return true;
        }

        /// <summary>
        /// Событие, вызывается при изменении состояния команды
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Выполняет загрузку контакта из файла
        /// </summary>
        /// <param name="parametr">Параметр команды</param>
        public void Execute(object parametr)
        {
            Contact loadContact = _contactSerializer.LoadContact();
            if (loadContact != null)
            { 
                _setContact(loadContact);
            }
        }
    }
}
