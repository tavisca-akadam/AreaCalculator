using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Circle : IShape
    {
        public int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return 3.14 * radius * radius;
        }
    }
}
