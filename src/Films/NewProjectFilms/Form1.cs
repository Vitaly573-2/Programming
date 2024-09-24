using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace NewProjectFilms
{
    public partial class Form1 : Form
    {
        private List<Films> Films = new List<Films>(5);
        private Films selectedFilm;
        private Rectangle _currentRectangles = new Rectangle();
        private string filePath = "film.xml";

        /*private string filePath = "Films.xml";*/

        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(filePath))
            {
                using (File.Create(filePath)) { }
            }
            LoadDataFromFile();
            PopulateGenreComboBox();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void PopulateGenreComboBox()
        {
            Array genreValues = Enum.GetValues(typeof(Genre));
            foreach (Genre genre in genreValues)
            {
                GenreComboBox1.Items.Add(genre);
            }
            GenreComboBox1.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataToFile();
        }

        private void SaveDataToFile()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Films>));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, Films);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
            }

        }

        private void LoadDataFromFile()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Films>));
                    using (Stream reader = new FileStream(filePath, FileMode.Open))
                    {
                        Films = (List<Films>)serializer.Deserialize(reader);
                    }
                    UpdateFilmList(); // После загрузки данных обновляем отображение в ListBox
                }
                catch (InvalidOperationException ex)
                {
                    // Обработка ошибки десериализации XML
                    MessageBox.Show($"Ошибка десериализации XML: {ex.Message}");
                }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (FilmsListBox1.SelectedIndex != -1)
            {

                Films selectedFilm = Films[FilmsListBox1.SelectedIndex];

                if (selectedFilm != null)
                {
                    selectedFilm._Name = NameTextBox1.Text;
                    selectedFilm._Year = int.Parse(YearTextBox2.Text);
                    selectedFilm.Genre = (Genre)GenreComboBox1.SelectedIndex;
                    selectedFilm._Rating = double.Parse(RatingTextBox4.Text);
                    selectedFilm._Minutes = int.Parse(MinutesTextBox3.Text);
                    UpdateFilmList();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenreComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MinutesTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MinutesTextBox3.Text, out int NewMinutes))
            {
                if (NewMinutes < 1 || NewMinutes > 300 )
                {
                    MinutesTextBox3.BackColor = Color.LightPink;
                }
                else if (NewMinutes >= 1 || NewMinutes <= 300 )
                {
                    MinutesTextBox3.BackColor = Color.White;

                }
            }
        }

        private void RatingTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(RatingTextBox4.Text, out double NewRating))
            {
                if (NewRating <= 0 || NewRating >= 10)
                {
                    RatingTextBox4.BackColor = Color.LightPink;
                }
                else if (NewRating >= 0 || NewRating <= 10 )
                {
                    RatingTextBox4.BackColor = Color.White;

                }
            }
        }

        private void YearTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(YearTextBox2.Text, out int NewYear))
            {
                if (NewYear < 0)
                {
                    YearTextBox2.BackColor = Color.LightPink;
                }
                else if (NewYear > 0)
                {
                    YearTextBox2.BackColor = Color.White;

                }
            }
        }

        private void NameTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox1.Text.Length > 100 )
            {
                NameTextBox1.BackColor = Color.LightPink;
            }
            else
            {
                NameTextBox1.BackColor = Color.White;
            }
        }

        private void FilmsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilmsListBox1.SelectedIndex != -1)
            {
                int SelectIndex = FilmsListBox1.SelectedIndex;
                selectedFilm = Films[SelectIndex];
                NameTextBox1.Text = selectedFilm._Name;
                YearTextBox2.Text = selectedFilm._Year.ToString();
                RatingTextBox4.Text = selectedFilm._Rating.ToString();
                MinutesTextBox3.Text = selectedFilm._Minutes.ToString();
                GenreComboBox1.SelectedItem = selectedFilm.Genre;
            }
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox1.Text) || string.IsNullOrEmpty(YearTextBox2.Text) || string.IsNullOrEmpty(RatingTextBox4.Text) || string.IsNullOrEmpty(MinutesTextBox3.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Films Film = new Films(NameTextBox1.Text, int.Parse(YearTextBox2.Text), 
                (Genre)GenreComboBox1.SelectedItem, double.Parse(RatingTextBox4.Text), int.Parse(MinutesTextBox3.Text));
            Films.Add(Film);
            UpdateFilmList();
            ClearInfoListBox();
        }

        private void UpdateFilmList()
        {
            List<Films> sortedFilms = new List<Films>(Films);
            Sort(sortedFilms);
            FilmsListBox1.Items.Clear();
            foreach (Films film in sortedFilms)
            {
                FilmsListBox1.Items.Add($"{film._Name}/{film._Year} /{film._Rating}/ {film._Minutes} / {film.Genre}");
            }
        }

        private void Sort(List<Films> films)
        {
            int n = films.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(films[j]._Name, films[j + 1]._Name) > 0)
                    {
                        Films temp = films[j];
                        films[j] = films[j + 1];
                        films[j + 1] = temp;
                    }
                }
            }
        }

        private void ClearInfoListBox()
        {
            NameTextBox1.Clear();
            YearTextBox2.Clear();
            GenreComboBox1.SelectedIndex = 0;
            RatingTextBox4.Clear();
            MinutesTextBox3.Clear();
        }

        private void RemoveButton2_Click(object sender, EventArgs e)
        {
            if (FilmsListBox1.SelectedIndex != -1)
            {
                int SelectIndex = FilmsListBox1.SelectedIndex;
                selectedFilm = Films[SelectIndex];
                Films.RemoveAt(FilmsListBox1.SelectedIndex);
                FilmsListBox1.Items.RemoveAt(FilmsListBox1.SelectedIndex);
                ClearInfoListBox();
                UpdateFilmList();
            }
        }
    }
}
