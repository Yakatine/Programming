using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private string _title;
        private string _artist;
        private int _durationSeconds;
        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название не может быть пустым.");
                _title = value;
            }
        }
        public string Artist
        {
            get { return _artist; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Исполнитель не может быть пустым.");
                _artist = value;
            }
        }
        public int DurationSeconds
        {
            get { return _durationSeconds; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationSeconds));
                _durationSeconds = value;
            }
        }
        public Song() { }
        public Song(string title, string artist, int durationSeconds)
        {
            Title = title;
            Artist = artist;
            DurationSeconds = durationSeconds;
        }
    }
}
