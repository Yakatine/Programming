using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private Point2D _center;
        private readonly int _id;

        private static int _allRectanglesCount;
        public static int AllRectanglesCount => _allRectanglesCount;
        public int Id => _id;
        public double Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }
        public Point2D Center => _center;
        public string Color{ get; set; }
        public Rectangle() { }
        public Rectangle(double length, double width, string color, double centerX, double centerY)
        {
            Length = length;
            Width = width;
            Color = color;
            _center = new Point2D(centerX, centerY);
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
    }
}
