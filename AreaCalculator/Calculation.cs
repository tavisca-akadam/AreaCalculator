using System;

namespace AreaCalculator
{
    public interface IShape
    {
        double Area();
    }
    public class Calculation
    {
        public static void display()
        {
            IShape square = new Square(10);
            Console.WriteLine("Area of square = " + square.Area());

            IShape rect = new Rectangle(10, 20);
            Console.WriteLine("Area of rectangle = " + rect.Area());

            IShape tri = new Triangle(10, 20);
            Console.WriteLine("Area of Triangle = " + tri.Area());

            IShape circle = new Circle(10);
            Console.WriteLine("Area of Circle = " + circle.Area());
        }
    }
}
