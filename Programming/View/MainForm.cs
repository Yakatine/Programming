using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            LoadEnums();
            InitializeData();
        }

        private void LoadEnums()
        {
            var enumTypes = new Type[]
            {
                typeof(Weekday),
                typeof(Genre),
                typeof(Model.Enums.Color),
                typeof(EducationForm),
                typeof(Manufactures),
                typeof(Season)
            };
            EnumsListBox.DataSource = enumTypes;

            EnumsListBox.DisplayMember = "Name";

            if (EnumsListBox.Items.Count > 0)
                EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnumType = EnumsListBox.SelectedItem as Type;

            if (selectedEnumType != null)
            {
                Array enumValues = Enum.GetValues(selectedEnumType);
                ValuesListBox.DataSource = enumValues;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem == null) return;

            int intValue = (int)ValuesListBox.SelectedItem;
            ValueTextBox.Text = intValue.ToString();
        }

        private void ParsButton_Click(object sender, EventArgs e)
        {
            string userInput = parsingTextBox.Text;
            if (Enum.TryParse(userInput, true, out Weekday result))
            {
                parseResultTextBox.Text = $"Это день недели ({result} = {(int)result})";
            }
            else
            {
                parseResultTextBox.Text = "Нет такого дня недели";
            }
        }

        private void SeasonGoButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null) return;
            string selectedText = SeasonComboBox.SelectedItem.ToString();
            Season selectSeason = (Season)Enum.Parse(typeof(Season), selectedText);
            switch (selectSeason)
            {
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    this.BackColor = System.Drawing.Color.Green;
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    this.BackColor = System.Drawing.Color.Orange;
                    break;
            }
        }
        /// <summary>
        /// Lab 3
        /// </summary>

        private Model.Classes.Rectangle[] _rectangles;
        private Model.Classes.Rectangle _currentRectangle;
        private Film[] _films;
        private Film _currentFilm;
        private void InitializeData()
        {
            Random rand = new Random();
            string[] colors = { "Red", "Blue", "Green", "Yellow", "Orange", "Pink" };
            _rectangles = new Model.Classes.Rectangle[5];
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Model.Classes.Rectangle(rand.Next(1, 101), rand.Next(1, 101), colors[rand.Next(colors.Length)],
                    rand.Next(0,100), rand.Next(0,100));
            }
            for (int i = 0; i < _rectangles.Length; i++)
            {
                RectangleListBox.Items.Add($"Rectangle {i + 1}");
            }

            _films = new Film[5];
            _films[0] = new Film("Avatar", 162, 2009, "Adventure", Math.Round(rand.NextDouble() * 10, 1));
            _films[1] = new Film("Titanic", 194, 1997, "Romance", Math.Round(rand.NextDouble() * 10, 1));
            _films[2] = new Film("1+1", 112, 2011, "Comedy", Math.Round(rand.NextDouble() * 10, 1));
            _films[3] = new Film("Spider-man",121, 2002, "Adventure", Math.Round(rand.NextDouble() * 10, 1));
            _films[4] = new Film("Interstellar",169, 2014, "Drama", Math.Round(rand.NextDouble() * 10, 1));
            for (int i = 0; i < _films.Length; i++)
            {
                FilmsListBox.Items.Add($"Film {i + 1}");
            }
        }
        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = RectangleListBox.SelectedIndex;
            if (index == -1) return;
            _currentRectangle = _rectangles[index];
            UpdateRectangleFields();
            CenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            CenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }
        private bool _isUpdating = false;

        private void UpdateRectangleFields()
        {
            if (_currentRectangle == null) return;
            _isUpdating = true;
            LenghtTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;

            LenghtTextBox.BackColor = System.Drawing.Color.White;
            WidthTextBox.BackColor = System.Drawing.Color.White;
            ColorTextBox.BackColor = System.Drawing.Color.White;
            _isUpdating = false;
        }
        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating || _currentRectangle == null) return;
            try
            {
                double value = double.Parse(LenghtTextBox.Text);
                _currentRectangle.Length = value;
                LenghtTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                LenghtTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating || _currentRectangle == null) return;
            try
            {
                double value = double.Parse(WidthTextBox.Text);
                _currentRectangle.Width = value;
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating || _currentRectangle == null) return;
            {
                _currentRectangle.Color = ColorTextBox.Text;
                ColorTextBox.BackColor = System.Drawing.Color.White;
            }
        }
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = index;
        }
        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
        {
            if (rectangles == null || rectangles.Length == 0) return -1;
            int maxIndex = 0;
            double maxWidth = rectangles[0].Width;
            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxIndex = i;
                }
            }
            return maxIndex;
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
        private int FindFilmWithMaxRating(Film[] films)
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
