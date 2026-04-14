using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        private static Random _random = new Random();

        public static Rectangle Randomize()
        {
            double x = _random.Next(1, 500);
            double y = _random.Next(1, 500);
            double width = _random.Next(1, 201);
            double lenght = _random.Next(1, 201);
            string color = "Green";
            return new Rectangle(width, lenght,color, x, y);
        }
    }
}
