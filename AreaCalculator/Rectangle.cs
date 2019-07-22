using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Rectangle : IShape
    {
        public int length, width;
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public double Area()
        {
            return length * width;
        }
    }
}
