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
    public class MainVM : INotifyPropertyChanged
    {

        private Contact _contact;
        private ContactSerializer _contactSerializer;

        public ICommand SaveCommand { get; private set; }
        public ICommand LoadCommand { get; private set; }


        public MainVM()
        {
            _contact = new Contact();
            _contactSerializer = new ContactSerializer();

            //Иницифлизация команд с зависимостями
            SaveCommand = new SaveCommand(_contactSerializer, _contact, UpdateContactFromUI);
            LoadCommand = new LoadCommand(_contactSerializer, SetContact);
        }

        //Обновлеие контакта в ViewModel
        public void SetContact(Contact contact)
        {
            if(_contact == null)
            {
                return;
            }

            _contact.Name = contact.Name;
            _contact.PhoneNumber = contact.PhoneNumber;
            _contact.Email = contact.Email;

            //Уведомляем об изменениях для каждого свойства
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(PhoneNumber));
            OnPropertyChanged(nameof(Email));
        }

        public void UpdateContactFromUI()
        {
            _contact.Name = this.Name;
            _contact.PhoneNumber = this.PhoneNumber;
            _contact.Email = this.Email;
        }


        public string Name
        {
            get { return _contact.Name; }
            set
            {
                if(_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged(nameof(Name)); // Уведомление об изменении 
                }
            }
        }

        public string PhoneNumber
        {
            get { return _contact.PhoneNumber; }
            set
            {
                if(_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        public string Email
        {
            get { return _contact.Email; }
            set
            {
                if(_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }



        //Объявление события PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        //Метод для вызова событий
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  
        }
    }
}
