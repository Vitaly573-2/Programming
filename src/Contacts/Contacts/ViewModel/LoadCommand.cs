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
    public class LoadCommand : ICommand
    {
        private ContactSerializer _contactSerializer;
        //Делегат, используется для обновления состояния Contact
        private Action<Contact> _setContact;

        public LoadCommand(ContactSerializer contactSerializer, Action<Contact> setContact)
        {
            _contactSerializer = contactSerializer ?? throw new ArgumentException(nameof(contactSerializer));
            _setContact = setContact ?? throw new ArgumentException(nameof(setContact));
        }

        //Определяет можно ли выполнять программу (true по умолчанию)
        public bool CanExecute(object parametr)
        {
            return true;
        }

        //Событие изменения состояния команды
        public event EventHandler CanExecuteChanged;

        //Выполнение загрузки контакта
        public void Execute(object parametr)
        {
            Contact loadContact = _contactSerializer.LoadContact();
            if(loadContact != null)
            {
                //Обновляем контакт 
                _setContact(loadContact);
            }
        }
    }
}
