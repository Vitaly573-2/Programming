using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Главная модель, управляющая списком контактов и их сохранением/удалением.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Выбранный контакт для редактирования.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Значение, указывающее, находятся ли поля доступными только для чтения.
        /// </summary>
        private bool _isReadOnlyMode = true;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="MainVM"/> и загружает список контактов.
        /// </summary>
        public MainVM()
        {
            ContactSerializer.CreateDirectory();
            Contacts = new ObservableCollection<Contact>(ContactSerializer.LoadContacts());
            AddCommand = new RelayCommand(AddContact, CanAddContact);
            EditCommand = new RelayCommand(EditContact, CanEditContact);
            RemoveCommand = new RelayCommand(RemoveContact, CanRemoveContact);
            ApplyCommand = new RelayCommand(ApplyContact, CanApplyContact);
        }

        /// <summary>
        /// Событие, уведомляющее об изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Команда добавления нового контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Команда редактирования выбранного контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Команда удаления выбранного контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Команда применения изменений и сохранения контакта.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Возвращает true, если активен режим добавления или редактирования.
        /// </summary>
        public bool IsAddOrEditMode => !IsReadOnlyMode;

        /// <summary>
        /// Указывает, активен ли режим только для чтения.
        /// </summary>
        public bool IsReadOnlyMode
        {
            get => _isReadOnlyMode;
            set
            {
                _isReadOnlyMode = value;
                OnPropertyChanged(nameof(IsReadOnlyMode));
                OnPropertyChanged(nameof(IsAddOrEditMode));
            }
        }

        /// <summary>
        /// Выбранный в данный момент контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                CancelEdit();
                _selectedContact = value;
                OnPropertyChanged(nameof(IsAddOrEditMode));
                OnPropertyChanged(nameof(SelectedContact));
                OnPropertyChanged(nameof(IsContactSelected));
            }
        }

        /// <summary>
        /// Возвращает true, если выбран контакт.
        /// </summary>
        public bool IsContactSelected => _selectedContact != null;

        /// <summary>
        /// Переводит ViewModel в режим редактирования.
        /// </summary>
        public void EditContact(object parameter)
        {
            IsReadOnlyMode = false;
        }

        /// <summary>
        /// Удаляет выбранный контакт и выбирает следующий (или предыдущий) при наличии.
        /// </summary>
        public void RemoveContact(object parameter)
        {
            if (SelectedContact == null)
            {
                return;
            }

            int index = Contacts.IndexOf(SelectedContact);
            Contacts.Remove(SelectedContact);

            if (Contacts.Any())
            {
                SelectedContact = index < Contacts.Count ? Contacts[index] : Contacts.Last();
            }
            else
            {
                SelectedContact = null;
            }

            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Создаёт новый контакт и переключает в режим редактирования.
        /// </summary>
        public void AddContact(object parameter) 
        {
            SelectedContact = null;
            SelectedContact = new Contact();
            IsReadOnlyMode = false;
        }

        /// <summary>
        /// Применяет изменения к выбранному контакту и сохраняет список.
        /// </summary>
        public void ApplyContact(object parameter)
        {
            if (SelectedContact == null)
            {
                return;
            }
                
            if (!Contacts.Contains(SelectedContact))
            {
                Contacts.Add(SelectedContact);
            }

            IsReadOnlyMode = true;
            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/> для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменённого свойства.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Отменяет редактирование и возвращает в режим только чтения.
        /// </summary>
        private void CancelEdit()
        {
            IsReadOnlyMode = true;
            OnPropertyChanged(nameof(IsReadOnlyMode));
            OnPropertyChanged(nameof(IsAddOrEditMode));
        }

        /// <summary>
        /// Проверяет, можно ли добавить контакт.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        /// <returns>Возвращает <c>true</c>, если контакт можно добавить; иначе <c>false</c>.</returns>
        private bool CanAddContact(object parameter) => !IsAddOrEditMode;

        /// <summary>
        /// Проверяет, можно ли редактировать выбранный контакт.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        /// <returns>Возвращает <c>true</c>, если контакт можно редактировать; иначе <c>false</c>.</returns>
        private bool CanEditContact(object parameter) => IsContactSelected && !IsAddOrEditMode;

        /// <summary>
        /// Проверяет, можно ли удалить выбранный контакт.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        /// <returns>Возвращает <c>true</c>, если контакт можно удалить; иначе <c>false</c>.</returns>
        private bool CanRemoveContact(object parameter) => IsContactSelected && !IsAddOrEditMode;

        /// <summary>
        /// Проверяет, можно ли применить изменения для выбранного контакта.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        /// <returns>Возвращает <c>true</c>, если изменения можно применить; иначе <c>false</c>.</returns>
        private bool CanApplyContact(object parameter) => IsAddOrEditMode;
    }
}
