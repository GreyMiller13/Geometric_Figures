using System;
using _Ellipses_;

namespace GeometricFigures
{
    class Ellipse : Ellipses
    {
        private readonly double pi;
        public Ellipse(double halfShaftA, double halfShaftB)
        {
            HalfShaftA = halfShaftA;
            HalfShaftB = halfShaftB;
            pi = valuePI;
        }
        public double Perimeter()
        {
            double result;
            if (HalfShaftA > 0 && HalfShaftB > 0)
            {
                if (HalfShaftA > HalfShaftB)
                    result = 4 * (((pi * HalfShaftA * HalfShaftB) + Math.Pow((HalfShaftA - HalfShaftB), 2)) / (HalfShaftA - HalfShaftB));
                else
                    result = 4 * (((pi * HalfShaftA * HalfShaftB) + Math.Pow((HalfShaftB - HalfShaftA), 2)) / (HalfShaftB - HalfShaftA));
                return result;
            }
            else
                return -1;

        }
        public double Area()
        {
            if (HalfShaftA > 0 && HalfShaftB > 0)
                return pi * HalfShaftA * HalfShaftB;
            else
                return -1;
        }
    }
}