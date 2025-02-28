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
    public class SaveCommand : ICommand
    {
        private ContactSerializer _contactSerializer;
        private Contact _contact;

        public SaveCommand(ContactSerializer contactSerializer, Contact contact)
        {
            _contactSerializer = contactSerializer ?? throw new ArgumentException(nameof(contactSerializer));
            _contact = contact ?? throw new ArgumentException(nameof(contact));
        }

        //Определяет можно ли выполнять программу (true по умолчанию)
        public bool CanExecute(object parameter)
        {
            return true;
        }

        //Событие изменения команды 
        public event EventHandler CanExecuteChanged;

        //Метод для сохранения контакта 
        public void Execute(object parametr)
        {
            _contactSerializer.SaveContact(_contact);
        }
    }
}
