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
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя не может быть пустым.");
                _firstName = value;
            }
        }
        public string LastName
        {
            get {  return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Фамилия не может быть пустой.");
                _lastName = value;
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
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
