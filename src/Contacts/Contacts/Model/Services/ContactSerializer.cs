using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        //Путь до файла, создает папку и файл
        public string FilePath { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.
                                               SpecialFolder.MyDocuments), 
                                               "Contacts", "contscts.json");
        
        //Метод для сохранения контакта в файл
        public void SaveContact(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentException("Ошибка при сохранении контакта");
            }

            //получение пути к папке 
            string directory = Path.GetDirectoryName(FilePath);
            //Проверка на существование папки 
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            //Сериализация объекта в Json
            string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
            //Запись Json в файл
            File.WriteAllText(FilePath, json);
        }

        //Метод для загрузки контакта из файла 
        public Contact LoadContact()
        {
            //Если существование файла не найдено
            if (!File.Exists(FilePath))
            {
                throw new FileNotFoundException("Файл с контактами не найден.");
            }

            //Если существование файла имеется
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);

                // Проверка на пустое содержимое файла
                if (string.IsNullOrEmpty(json))
                {
                    throw new InvalidDataException("Файл пуст.");
                }

                //Десериализация Json в Contact
                Contact contact = JsonConvert.DeserializeObject<Contact>(json);
                return contact;
            }
            else
            {
                throw new ArgumentException("Файл не найден");      
            }
        }
    }
}
