using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Ring
    {
        private Point2D _center;
        private double _outerRadius;
        private double _innerRadius;

        public Point2D Center
        {
            get => _center;
            set{}
        }
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                if (value < _innerRadius)
                    throw new ArgumentException(
                        $"Внешний радиус ({value}) не может быть меньше внутреннего ({_innerRadius})");
                _outerRadius = value;
            }
        }
        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                if (value > _outerRadius)
                    throw new ArgumentException(
                        $"Внутренний радиус ({value}) не может быть больше внешнего ({_outerRadius})");
                _innerRadius = value;
            }
        }
        public double Area
        {
            get
            {
                double outerArea = Math.PI * _outerRadius * _outerRadius;
                double innerArea = Math.PI * _innerRadius * _innerRadius;
                return outerArea - innerArea;
            }
        }
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            _center = center ?? throw new ArgumentNullException(nameof(center));
            _outerRadius = outerRadius;
            _innerRadius = innerRadius;

            double tempOuter = _outerRadius;
            double tempInner = _innerRadius;
            _outerRadius = 0;
            _innerRadius = 0;
            OuterRadius = tempOuter;
            InnerRadius = tempInner;
        }
    }
}
