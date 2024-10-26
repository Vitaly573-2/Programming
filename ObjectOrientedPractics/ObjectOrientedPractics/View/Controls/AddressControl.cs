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
        private Address _address; //переменная типа Address
        public bool ListBoxNull = false;//флаг
        public Address Address //свойство, через него можно обращаться к классу
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        /*public AddressControl()
        {
        }*/

/*        public AddressControl(Address address)
        {
            Address = address;

        }*/

        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        public void ClearForm()
        {
            PostIndexTextBox.Text = "111111";
            CountryTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
            StreetTextBox.Text = string.Empty;
            BuildingTextBox.Text = string.Empty;
            ApartmentTextBox.Text = string.Empty;
        }

        public AddressControl NewAddress; //объкт формы

        public void ShowValues(Address SomeAddress)
        {

            NewAddress.Address = SomeAddress;

            PostIndexTextBox.Text = NewAddress.Address.Index.ToString();
            CountryTextBox.Text = NewAddress.Address.Country.ToString();
            CityTextBox.Text = NewAddress.Address.City.ToString();
            StreetTextBox.Text = NewAddress.Address.Street.ToString();
            BuildingTextBox.Text = NewAddress.Address.Building.ToString();
            ApartmentTextBox.Text = NewAddress.Address.Apartment.ToString();


        }
        public Address GiveValues()
        {
            return new Address(Convert.ToInt32(PostIndexTextBox.Text), 
                                               CountryTextBox.Text, 
                                               CityTextBox.Text, 
                                               StreetTextBox.Text, 
                                               BuildingTextBox.Text, 
                                               ApartmentTextBox.Text);
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
                    NewAddress.Address.Index = index; // Присваиваем индекс свойству Address
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
                    NewAddress.Address.Country = CountryTextBox.Text; // Присваиваем значение свойству Address
                }
                else
                {
                    CountryTextBox.BackColor = Color.Pink;
                }
            }
            else
            {
                CountryTextBox.BackColor = Color.Pink;
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
                    NewAddress.Address.Street = StreetTextBox.Text;
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
                    NewAddress.Address.Building = BuildingTextBox.Text;
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
                    NewAddress.Address.Apartment = ApartmentTextBox.Text;
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
            NewAddress = new AddressControl();
            /*NewAddress.Address = new Address(123456, "Россия", "Томск", "Репина", "12", "36");*/
            //PostIndexTextBox.Text = NewAddress.Address.Index.ToString();
            /*CountryTextBox.Text = NewAddress.Address.Country.ToString();
            CityTextBox.Text = NewAddress.Address.City.ToString();
            StreetTextBox.Text = NewAddress.Address.Street.ToString();
            BuildingTextBox.Text = NewAddress.Address.Building.ToString();
            ApartmentTextBox.Text = NewAddress.Address.Apartment.ToString();*/
        }

        /*        private void AddButton_Click(object sender, EventArgs e)
        {

            label8.Text = $"{NewAddress.Address.Index.ToString()} - {NewAddress.Address.Country.ToString()} - {NewAddress.Address.City.ToString()} - {NewAddress.Address.Street.ToString()} - {NewAddress.Address.Building.ToString()} - {NewAddress.Address.Apartment.ToString()}";

        }*/
/*        int value;
        public void ListBoxfromCustomersTabState(int SelectedIndex)
        {
            int value = SelectedIndex;
        }*/
    }
}
