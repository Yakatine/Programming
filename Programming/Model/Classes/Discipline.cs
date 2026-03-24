using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (value < 1 || value > 8)
                    throw new ArgumentException("Семестр должен быть от 1 до 8.");
                _semester = value;
            }
        }
        public int Grade
        {
            get { return _grade; }
            set
            {
                if (value < 2 || value > 5)
                    throw new ArgumentException("Оценка должна быть от 2 до 5.");
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
