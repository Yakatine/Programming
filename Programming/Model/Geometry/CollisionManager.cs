using Programming.Model.Classes;
using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double x1 = rectangle1.Center.X;
            double y1 = rectangle1.Center.Y;
            double x2 = rectangle2.Center.X;
            double y2 = rectangle2.Center.Y;

            double dx = Math.Abs(x1 - x2);
            double dy = Math.Abs(y1 - y2);

            double halfWidth1 = rectangle1.Width / 2;
            double halfHeight1 = rectangle1.Length / 2;
            double halfWidth2 = rectangle2.Width / 2;
            double halfHeight2 = rectangle2.Length / 2;

            return dx < (halfWidth1 + halfWidth2) && dy < (halfHeight1 + halfHeight2);
        }
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double x1 = ring1.Center.X;
            double y1 = ring1.Center.Y;
            double x2 = ring2.Center.X;
            double y2 = ring2.Center.Y;

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double sumRadii = ring1.OuterRadius + ring2.OuterRadius;

            return distance < sumRadii;
        }
    }
}
