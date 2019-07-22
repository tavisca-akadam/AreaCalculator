using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Triangle : IShape
    {
        public int length, width;

        public Triangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public double Area()
        {
            return 0.5 * length * width;
        }
    }
}
