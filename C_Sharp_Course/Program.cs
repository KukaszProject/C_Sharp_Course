namespace C_Sharp_Course
{
    internal class Program
    {

        public interface IShape
        {
            double GetArea();
        }

        public class Circle : IShape
        {
            private double _radius;
            public void Area(double radius)
            {
                _radius = radius;
            }
            public double GetArea()
            {
                Console.WriteLine($"Area: {_radius * _radius * Math.PI}");
                return _radius * _radius * Math.PI;
            }
        }

        public class Rectangle : IShape
        {
            private int _width;
            private int _height;
            public void Area(int width, int height)
            {
                _height = height;
                _width = width;
            }
            public double GetArea()
            {
                Console.WriteLine($"Area: {_width * _height}");
                return _width * _height;
            }
        }

        public class Exercise
        {
            public void PrintAreas()
            {
                // TODO: Add your code here
                Circle c = new Circle();
                c.Area(5);
                c.GetArea();
                Rectangle r = new Rectangle();
                r.Area(4, 6);
                r.GetArea();
            }
        }


        static void Main(string[] args)
        {
            //Interfaces.InterfaceMain();
            //Logs.LogsMain();
            //Dependencies.DependenciesMain();
            Circle c = new Circle();
            c.Area(5);
            c.GetArea();
            Rectangle r = new Rectangle();
            r.Area(4, 6);
            r.GetArea();
        }
    }
}
