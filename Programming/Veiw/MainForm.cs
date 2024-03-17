using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;
        private string[] ListBoxRectangle = new string[5];
        private string[] Color = new string[5] { "Pink", "Green", "Black", "Blue", "Red" };
        Random random = new Random();

        private Movie[] _movie = new Movie[5];
        private Movie _currentMovie;
        private string[] ListBoxMovie = new string[5];
        private string[] NameMovie = new string[5] {"Форсаж","Легенда","Мстители","Пацанская история","Бизнесмены"};
        private string[] GenreMovie = new string[5] {"экшен","боевик","фантастика","криминал","исторический"};

        private void RectangelsInitialize()
        {
            for (int i = 0; i < ListBoxRectangle.Length; i++)
            {
                int width = random.Next(10);
                int length = random.Next(10);
                _rectangles[i] = new Rectangle(length, width, Color[i]);
                ListBoxRectangle[i] = ($"Rectangle {i + 1}");
            }
            EnumslistBox4.Items.AddRange(ListBoxRectangle);
        }

        private void MovieInitialize()
        {
            for(int i = 0; i< ListBoxMovie.Length; i++)
            {
                int minutes = random.Next(120);
                int year = random.Next(2000, 2020);
                double rating = random.Next(10);
                _movie[i] = new Movie(NameMovie[i], minutes, year, GenreMovie[i], rating);
                ListBoxMovie[i] = ($"Movie {i + 1}");
            }
            MovielistBox1.Items.AddRange(ListBoxMovie);
        } 

        public MainForm()
        {
            InitializeComponent();
            ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Color)).Cast<object>().ToArray());
            RectangelsInitialize();
            MovieInitialize();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Enums_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValueslistBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numericValue = (int)ValueslistBox2.SelectedItem;
            EnumstextBox1.Text = numericValue.ToString();
        }

        private void EnumslistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueslistBox2.Items.Clear();
            switch (EnumslistBox1.SelectedIndex)
            {
                case 0:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Color)).Cast<object>().ToArray());
                    break;
                case 1:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Education)).Cast<object>().ToArray());
                    break;
                case 2:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Genre)).Cast<object>().ToArray());
                    break;
                case 3:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
                    break;
                case 4:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Smartphone)).Cast<object>().ToArray());
                    break;
                case 5:
                    ValueslistBox2.Items.AddRange(Enum.GetValues(typeof(Weekday)).Cast<object>().ToArray());
                    break;
            }
        }

        private void EnumstextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = EnumstextBox2.Text.Trim();
            if (Enum.TryParse<Weekday>(userInput, out Weekday parsedWeekday))
            {
                int numericValue = (int)parsedWeekday;
                if(numericValue <= 7)
                {
                    EnumstextBox3.Text = $"Этот день недели {parsedWeekday} = {numericValue}";
                }
                else
                {
                    EnumstextBox3.Text = "Нет такого дня недели";
                }
                
            }
            else
            {
                EnumstextBox3.Text = "Нет такого дня недели";
            }
        }

        private void ValueslistBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (ValueslistBox3.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Бррр!Холодно!");
                    break;
                case 1:
                    MessageBox.Show("Ура!Солнце!");
                    break;
                case 2:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    groupBox1.BackColor = ColorTranslator.FromHtml("#559c45");
                    groupBox2.BackColor = ColorTranslator.FromHtml("#559c45");
                    groupBox3.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case 3:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    groupBox1.BackColor = ColorTranslator.FromHtml("#e29c45");
                    groupBox2.BackColor = ColorTranslator.FromHtml("#e29c45");
                    groupBox3.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EnumslistBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectIndex = EnumslistBox4.SelectedIndex;
            _currentRectangle = _rectangles[SelectIndex];
            LengthtextBox1.Text = _currentRectangle.Length.ToString();
            WidthtextBox2.Text = _currentRectangle.Width.ToString();
            ColortextBox3.Text = _currentRectangle.Color;
            
        }

        private void LengthtextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(LengthtextBox1.Text, out double newLength))
                    {
                        _currentRectangle.Length = newLength;
                        LengthtextBox1.BackColor = ColorTranslator.FromHtml("White");
                    }
                    else
                    {
                        LengthtextBox1.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
                catch (Exception)
                {
                    LengthtextBox1.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                }
            }
        }

        private void WidthtextBox2_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(WidthtextBox2.Text, out double newWidth))
                    {
                        _currentRectangle.Width = newWidth;
                        WidthtextBox2.BackColor = ColorTranslator.FromHtml("White");
                    }
                    else
                    {
                        WidthtextBox2.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
                catch (Exception)
                {
                    WidthtextBox2.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                }
            }

        }

        private void ColortextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    string newColor = ColortextBox3.Text;
                    if (Color.Contains(newColor))
                    {
                        _currentRectangle.Color = newColor;
                        ColortextBox3.BackColor = ColorTranslator.FromHtml("White");
                    }
                    else
                    {
                        ColortextBox3.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
            }
            catch (Exception)
            {
                ColortextBox3.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        private int FindRectangleWithMaxWidth(Rectangle[] _rectangles)
        {
            int MaxIndex = 0;
            double MaxWidth = _rectangles[0].Width;
            for(int i = 0; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > MaxWidth)
                {
                    MaxIndex = i;
                    MaxWidth = _rectangles[i].Width;
                }
            }
            return MaxIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int MaxIndex = FindRectangleWithMaxWidth(_rectangles);
            _currentRectangle = _rectangles[MaxIndex];
            LengthtextBox1.Text = _currentRectangle.Length.ToString();
            WidthtextBox2.Text = _currentRectangle.Width.ToString();
            ColortextBox3.Text = _currentRectangle.Color;
        }

        private void RatingtextBox5_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie != null)
            {
                try
                {
                    if (double.TryParse(RatingtextBox5.Text, out double newRating))
                    {
                        _currentMovie.Rating = newRating;
                        RatingtextBox5.BackColor = ColorTranslator.FromHtml("White");
                    }
                    else
                    {
                        RatingtextBox5.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
                catch (Exception)
                {
                    RatingtextBox5.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                }
            }
        }

        private void GenretextBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentMovie != null)
                {
                    string newGenre = GenretextBox4.Text;
                    if (GenreMovie.Contains(newGenre))
                    {
                        _currentMovie.Genre = newGenre;
                        GenretextBox4.BackColor = ColorTranslator.FromHtml("White");
                    }
                    else
                    {
                        GenretextBox4.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
            }
            catch (Exception)
            {
                GenretextBox4.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }
        private int FindMovieRatingMaxRating(Movie[] _movie)
        {
            int MaxIndex = 0;
            double MaxRating = _movie[0].Rating;
            for (int i = 0; i < _movie.Length; i++)
            {
                if (_movie[i].Rating > MaxRating)
                {
                    MaxIndex = i;
                    MaxRating = _movie[i].Rating;
                }
            }
            return MaxIndex;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int MaxIndex = FindMovieRatingMaxRating(_movie);
            _currentMovie = _movie[MaxIndex];
            NametextBox3.Text = _currentMovie.Name;
            MinutestextBox2.Text = _currentMovie.Minutes.ToString();
            YeartextBox1.Text = _currentMovie.Year.ToString();
            GenretextBox4.Text = _currentMovie.Genre;
            RatingtextBox5.Text = _currentMovie.Rating.ToString();
        }


        private void YeartextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie != null)
            {
                try
                {
                    if (int.TryParse(YeartextBox1.Text, out int newYear))
                    {
                        _currentMovie.Year = newYear;
                        YeartextBox1.BackColor = ColorTranslator.FromHtml("White");
                    }
                    else
                    {
                        YeartextBox1.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
                catch (Exception)
                {
                    YeartextBox1.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                }
            }
        }

        private void MinutestextBox2_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie != null)
            {
                try
                {
                    if (int.TryParse(MinutestextBox2.Text, out int newMinutes))
                    {
                        _currentMovie.Minutes = newMinutes;
                        MinutestextBox2.BackColor = ColorTranslator.FromHtml("White");
                    }
                    else
                    {
                        MinutestextBox2.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
                catch (Exception)
                {
                    MinutestextBox2.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                }
            }
        }

        private void NametextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentMovie != null)
                {
                    string newName = NametextBox3.Text;
                    if (NameMovie.Contains(newName))
                    {
                        _currentMovie.Name = newName;
                        NametextBox3.BackColor = ColorTranslator.FromHtml("White");
                    }
                    else
                    {
                        NametextBox3.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
            }
            catch (Exception)
            {
                NametextBox3.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        private void MovielistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectIndex = MovielistBox1.SelectedIndex;
            _currentMovie = _movie[SelectIndex];
            NametextBox3.Text = _currentMovie.Name;
            MinutestextBox2.Text = _currentMovie.Minutes.ToString();
            YeartextBox1.Text = _currentMovie.Year.ToString();
            GenretextBox4.Text = _currentMovie.Genre;
            RatingtextBox5.Text = _currentMovie.Rating.ToString(); 
        }
    }
}
