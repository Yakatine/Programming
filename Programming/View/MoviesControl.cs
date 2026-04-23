using Programming.Model.Classes;
using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class MoviesControl : UserControl
    {
        public MoviesControl()
        {
            InitializeComponent();
            InitializeData();
        }
        private Model.Classes.Film[] _films;
        private Model.Classes.Film _currentFilm;

        private void InitializeData()
        {
            Random rand = new Random();
            _films = new Model.Classes.Film[5];
            _films[0] = new Model.Classes.Film("Avatar", 162, 2009, "Adventure", Math.Round(rand.NextDouble() * 10, 1));
            _films[1] = new Model.Classes.Film("Titanic", 194, 1997, "Romance", Math.Round(rand.NextDouble() * 10, 1));
            _films[2] = new Model.Classes.Film("1+1", 112, 2011, "Comedy", Math.Round(rand.NextDouble() * 10, 1));
            _films[3] = new Model.Classes.Film("Spider-man", 121, 2002, "Adventure", Math.Round(rand.NextDouble() * 10, 1));
            _films[4] = new Model.Classes.Film("Interstellar", 169, 2014, "Drama", Math.Round(rand.NextDouble() * 10, 1));
            for (int i = 0; i < _films.Length; i++)
            {
                FilmsListBox.Items.Add($"Film {i + 1}");
            }
        }
        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilmsListBox.SelectedIndex >= 0)
            {
                _currentFilm = _films[FilmsListBox.SelectedIndex];
                UpdateFilmFields();
            }
        }
        private bool _updatingFilm = false;
        private void UpdateFilmFields()
        {
            _updatingFilm = true;
            TitleFilmTextBox.Text = _currentFilm.Title;
            GenreFilmTextBox.Text = _currentFilm.Genre;
            DurationTextBox.Text = _currentFilm.DurationMinutes.ToString();
            ReleaseYearTextBox.Text = _currentFilm.ReleaseYear.ToString();
            RatingTextBox.Text = _currentFilm.Rating.ToString();

            DurationTextBox.BackColor = System.Drawing.Color.White;
            ReleaseYearTextBox.BackColor = System.Drawing.Color.White;
            RatingTextBox.BackColor = System.Drawing.Color.White;
            _updatingFilm = false;
        }
        private void TitleFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_updatingFilm || _currentFilm == null) return;
            _currentFilm.Title = TitleFilmTextBox.Text;
        }

        private void GenreFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_updatingFilm || _currentFilm == null) return;
            _currentFilm.Genre = GenreFilmTextBox.Text;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_updatingFilm || _currentFilm == null) return;
            try
            {
                int val = int.Parse(DurationTextBox.Text);
                _currentFilm.DurationMinutes = val;
                DurationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_updatingFilm || _currentFilm == null) return;
            try
            {
                int val = int.Parse(ReleaseYearTextBox.Text);
                _currentFilm.ReleaseYear = val;
                ReleaseYearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_updatingFilm || _currentFilm == null) return;
            try
            {
                double val = double.Parse(RatingTextBox.Text);
                _currentFilm.Rating = val;
                RatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            int index = FindFilmWithMaxRating(_films);
            FilmsListBox.SelectedIndex = index;
        }
        private int FindFilmWithMaxRating(Model.Classes.Film[] films)
        {
            if (films == null || films.Length == 0) return -1;
            int maxIndex = 0;
            double maxRating = films[0].Rating;
            for (int i = 1; i < films.Length; i++)
            {
                if (films[i].Rating > maxRating)
                {
                    maxRating = films[i].Rating;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}
