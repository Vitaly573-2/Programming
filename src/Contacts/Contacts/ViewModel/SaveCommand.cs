using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда сохранения контакта
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Объект для сериализации контактов
        /// </summary>
        private ContactSerializer _contactSerializer;

        /// <summary>
        /// Объект контакта
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Делегат для обновления данных контакта 
        /// </summary>
        private Action _updateContact;

        /// <summary>
        /// Конструктор команды сохранения контакта
        /// </summary>
        /// <param name="contactSerializer">Объект для сериализации контактов</param>
        /// <param name="contact">Объект контакта</param>
        /// <param name="updateContact">Метод для обновления данных</param>
        /// <exception cref="ArgumentException">Вызывается, если передан null</exception>
        public SaveCommand(ContactSerializer contactSerializer, Contact contact, Action updateContact)
        {
            _contactSerializer = contactSerializer ?? throw new ArgumentException(nameof(contactSerializer));
            _contact = contact ?? throw new ArgumentException(nameof(contact));
            _updateContact = updateContact ?? throw new ArgumentException(nameof(updateContact));
        }

        /// <summary>
        /// Определяет, можно ли выполнить команду
        /// </summary>
        /// <param name="parameter">Параметр команды</param>
        /// <returns>True</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Событие, вызывается при изменении состояния команды
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Выполняет сохранение контакта
        /// </summary>
        /// <param name="parametr">Параметр команды </param>
        public void Execute(object parametr)
        {
            _updateContact();
            _contactSerializer.SaveContact(_contact);
        }
    }
}
