using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Square : IShape
    {
        public int length;

        public Square(int length)
        {
            this.length = length;
        }
        public double Area()
        {
            return length * length;
        }
    }
}
