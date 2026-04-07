using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _name;
        private string _surname;
        private string _phoneNumber;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя не может быть пустым.");
                AssertStringContainsOnlyLetters(value, "Name");
                _name = value;
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Фамилия не может быть пустой.");
                AssertStringContainsOnlyLetters(value, "Surname");
                _surname = value;
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Номер телефона не может быть пустым.");
                _phoneNumber = value;
            }
        }
        public Contact() { }
        public Contact(string firstName, string lastName, string phoneNumber)
        {
            Name = firstName;
            Surname = lastName;
            PhoneNumber = phoneNumber;
        }
        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            foreach (char c in value)
            {
                bool isEnglishLetter = (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
                if (!isEnglishLetter)
                {
                    throw new ArgumentException(
                        $"Значение {propertyName} должно содержать только буквы английского алфавита.");
                }
            }
        }
    }
}
