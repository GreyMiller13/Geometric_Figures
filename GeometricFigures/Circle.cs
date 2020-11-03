using System;
using _Ellipses_;

namespace GeometricFigures
{
    class Circle : Ellipses
    {
        private readonly double pi;
        public Circle(double radius)
        {
            Radius = radius;
            pi = valuePI;
        }
        public double Perimeter()
        {
            if (Radius > 0)
                return 2 * pi * Radius;
            else
                return -1;
        }
        public double Area()
        {
            if (Radius > 0)
                return pi * Math.Pow(Radius, 2);
            else
                return -1;
        }
    }
}