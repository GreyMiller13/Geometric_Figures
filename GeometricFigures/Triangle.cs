using System;
using _Triangles_;

namespace GeometricFigures
{
    class Triangle : Triangles
    {
        public Triangle(double value1, double value2, double value3, double height)
        {
            SideOne = value1;
            SideTwo = value2;
            SideThree = value3;
            Height = height;
        }

        public double Perimeter()
        {
            if (ZeroValue())
                return SideOne + SideTwo + SideThree;
            else
                return -1;
        }
        public double Area()
        {
            if (ZeroValue())
                return 0.5 * (SideOne * Height);
            else
                return -1;
        }
    }
}