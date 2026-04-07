using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                Validator.AssertOnPositiveValue(value, nameof(DurationMinutes));
                _durationMinutes = value;
            }
        }
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }
        public double Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
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
