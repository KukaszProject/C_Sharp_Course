using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y}).");
        }

        public double DistanceTo(Point o)
        {
            double dx = o.X - X;
            double dy = o.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }


    public class Structs
    {
        public static void StructsMain()
        {
            Point p1 = new Point(4,2);
            p1.Display();

            Point p2 = new Point(12,8);
            p2.Display();

            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Distance between two points: {distance}");
        }
    }
}
