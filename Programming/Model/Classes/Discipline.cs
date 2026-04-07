using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private string _name;
        private int _semester;
        private int _grade;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название не может быть пустым.");
                _name = value;
            }
        }
        public int Semester
        {
            get { return _semester; }
            set
            {
                Validator.AssertValueInRange(value, 1, 8, nameof(Semester));
                _semester = value;
            }
        }
        public int Grade
        {
            get { return _grade; }
            set
            {
                Validator.AssertValueInRange(value, 2, 5, nameof(Grade));
                _grade = value;
            }
        }
        public Discipline(){}
        public Discipline(string name, int semester, int grade)
        {
            Name = name;
            Semester = semester;
            Grade = grade;
        }
    }
}
