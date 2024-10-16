using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl 
    {
        private Address _currentAddress;

        public Address Address
        {
            get
            {
                return _currentAddress;
            }
            set
            {
                _currentAddress = value;
                UpdateAddressFields();
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        public void UpdateAddressFields()
        {
            // Обновляем поля текстовых компонентов с использованием _currentAddress
            PostIndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country.ToString();
            CityTextBox.Text = Address.City.ToString();
            StreetTextBox.Text = Address.Street.ToString();
            BuildingTextBox.Text = Address.Building.ToString();
            ApartmentTextBox.Text = Address.Apartment.ToString();
        }

        public bool AddressIsNullOrEmpty()
        {
            if (string.IsNullOrEmpty(PostIndexTextBox.Text) ||
                string.IsNullOrEmpty(CountryTextBox.Text) ||
                string.IsNullOrEmpty(CityTextBox.Text) ||
                string.IsNullOrEmpty(StreetTextBox.Text) ||
                string.IsNullOrEmpty(BuildingTextBox.Text) ||
                string.IsNullOrEmpty(ApartmentTextBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Clear()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();

            PostIndexTextBox.BackColor = Color.White;
            CountryTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;
            StreetTextBox.BackColor = Color.White;
            BuildingTextBox.BackColor = Color.White;
            ApartmentTextBox.BackColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, является ли введенное значение числом
            if (int.TryParse(PostIndexTextBox.Text, out int index))
            {
                if (index >= 100000 && index <= 999999)
                {
                    PostIndexTextBox.BackColor = Color.White;
                    Address.Index = index; // Присваиваем индекс свойству Address
                }
                else
                {
                    PostIndexTextBox.BackColor = Color.Pink; 
                }
            }
            else
            {
                PostIndexTextBox.BackColor = Color.Pink; 
            }
        }

    
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {

            // Проверяем, что строка не пуста и содержит только буквы
            if (!string.IsNullOrWhiteSpace(CountryTextBox.Text) && CountryTextBox.Text.All(char.IsLetter))
            {
                if (CountryTextBox.Text.Length < 50)
                {
                    CountryTextBox.BackColor = Color.White; 
                    Address.Country = CountryTextBox.Text; // Присваиваем значение свойству Address
                }
                else
                {
                    CountryTextBox.BackColor = Color.Pink;
                }
            }
            else
            {
                CountryTextBox.BackColor = Color.Pink;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, что строка не пуста и содержит только буквы
            if (!string.IsNullOrWhiteSpace(StreetTextBox.Text) && StreetTextBox.Text.All(char.IsLetter))
            {
                if (StreetTextBox.Text.Length < 100)
                {
                    StreetTextBox.BackColor = Color.White;
                    Address.Street = StreetTextBox.Text;
                }
                else
                {
                    StreetTextBox.BackColor = Color.Pink;
                }
            }
            else
            {
                StreetTextBox.BackColor = Color.Pink; // Устанавливаем розовый фон для некорректного значения
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BuildingTextBox.Text) && BuildingTextBox.Text.All(char.IsLetter))
            {
                if (BuildingTextBox.Text.Length < 10)
                {
                    BuildingTextBox.BackColor = Color.White;
                    Address.Building = BuildingTextBox.Text;
                }
                else
                {
                    BuildingTextBox.BackColor = Color.Pink;
                }
            }
            else
            {
                BuildingTextBox.BackColor = Color.Pink; // Устанавливаем розовый фон для некорректного значения
            }


        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CityTextBox.Text) && CityTextBox.Text.All(char.IsLetter))
            {
                if (CityTextBox.Text.Length < 50)
                {
                    CityTextBox.BackColor = Color.White;
                    Address.City = CityTextBox.Text;
                }
                else
                {
                    CityTextBox.BackColor = Color.Pink;
                }
            }
            else
            {
                CityTextBox.BackColor = Color.Pink; // Устанавливаем розовый фон для некорректного значения
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ApartmentTextBox.Text) && ApartmentTextBox.Text.All(char.IsLetter))
            {
                if (ApartmentTextBox.Text.Length < 10)
                {
                    ApartmentTextBox.BackColor = Color.White;
                    Address.Apartment = ApartmentTextBox.Text;
                }
                else
                {
                    ApartmentTextBox.BackColor = Color.Pink;
                }
            }
            else
            {
                ApartmentTextBox.BackColor = Color.Pink; // Устанавливаем розовый фон для некорректного значения
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddressControl_Load(object sender, EventArgs e)
        {

        }
}
}
