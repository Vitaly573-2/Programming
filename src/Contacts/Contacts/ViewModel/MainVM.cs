using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
/*        private ContactSerializer _contactSerializer; 

        public ICommand SaveCommand { get; private set; }
        public ICommand LoadCommand { get; private set; }*/

        public MainVM()
        {
            _contact = new Contact();
            //_contactSerializer = new ContactSerializer();


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



        //Реализация интерфейса INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        //Метод для вызова событий
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  
        }
    }
}
