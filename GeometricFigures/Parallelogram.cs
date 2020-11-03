using System;
using _Quadrilaterals_;

namespace GeometricFigures
{
    class Parallelogram : Quadrilaterals
    {
        public Parallelogram(double value1, double value2, double height)
        {
            SideOne = value1;
            SideTwo = value2;
            SideThree = value1;
            SideFour = value2;
            Height = height;
        }
        public double Perimeter()
        {
            if (ZeroValue() && Height > 0)
                return 2 * (SideOne + SideTwo);
            else
                return -1;
        }
        public double Area()
        {
            if (ZeroValue() && Height > 0)
                return SideOne * Height;
            else
                return -1;
        }
    }
}