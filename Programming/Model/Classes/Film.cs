using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Film
    {
        private int _durationMinutes;
        private int _releaseYear;
        private double _rating;
        public int DurationMinutes
        {
            get { return _durationMinutes; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Продолжительность не может быть отрицательной.");
                _durationMinutes = value;
            }
        }
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException($"Год выпуска должен быть в диапазоне [1900, {DateTime.Now.Year}].");
                _releaseYear = value;
            }
        }
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Рейтинг должен быть в диапазоне [0, 10].");
                _rating = value;
            }
        }
        public string Title { get; set; }
        public string Genre { get; set; }
        public Film() { }
        public Film(string title, int durationMinutes, int releaseYear, string genre, double rating)
        {
            Title = title;
            DurationMinutes = durationMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }
    }
}
