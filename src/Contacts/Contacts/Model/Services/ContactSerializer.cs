using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Сериализации и десериализации контактов
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Путь к файлу для хранения контакта
        /// Автоматически создаёт папку и файл
        /// </summary>
        public string FilePath { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                               "Contacts", "contacts.json");

        /// <summary>
        /// Cохраняет контакт в файл в формате json.
        /// </summary>
        /// <param name="contact">Сохранения объекта контакта</param>
        /// <exception cref="ArgumentException">Выбрасывается, если переданный контакт является null</exception>
        public void SaveContact(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentException("Ошибка при сохранении контакта");
            }

            string directory = Path.GetDirectoryName(FilePath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        /// <summary>
        /// Загружает контакт из файла
        /// </summary>
        /// <returns>Объект с загруженными данными.</returns>
        /// <exception cref="FileNotFoundException">Выбрасывается, если файл с контактами не найден</exception>
        /// <exception cref="InvalidDataException">Выбрасывается, если файл пуст</exception>
        public Contact LoadContact()
        {
            if (!File.Exists(FilePath))
            {
                throw new FileNotFoundException("Файл с контактами не найден.");
            }

            string json = File.ReadAllText(FilePath);

            if (string.IsNullOrEmpty(json))
            {
                throw new InvalidDataException("Файл пуст.");
            }

            return JsonConvert.DeserializeObject<Contact>(json);
        }
    }
}
