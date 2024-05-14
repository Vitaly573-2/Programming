﻿using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Veiw.Panels
{
    public partial class MovieControl1 : UserControl
    {
        Random random = new Random();

        private Movie[] _movie = new Movie[5];
        private Movie _currentMovie;
        private string[] ListBoxMovie = new string[5];
        private string[] NameMovie = new string[5] { "Форсаж", "Легенда", "Мстители", "Пацанская история", "Бизнесмены" };
        private string[] GenreMovie = new string[5] { "экшен", "боевик", "фантастика", "криминал", "исторический" };



        private void MovieInitialize()
        {
            for (int i = 0; i < ListBoxMovie.Length; i++)
            {
                int minutes = random.Next(120);
                int year = random.Next(2000, 2020);
                double rating = random.Next(10);
                _movie[i] = new Movie(NameMovie[i], minutes, year, GenreMovie[i], rating);
                ListBoxMovie[i] = ($"Movie {i + 1}");
            }
            MovielistBox1.Items.AddRange(ListBoxMovie);
        }


        public MovieControl1()
        {
            InitializeComponent();
            MovieInitialize();
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


        private void label13_Click(object sender, EventArgs e)
        {

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

        private void label12_Click(object sender, EventArgs e)
        {

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

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
