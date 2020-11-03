using System;
using _Quadrilaterals_;

namespace GeometricFigures
{
    class Rectangle : Quadrilaterals
    {
        public Rectangle(double value1, double value2)
        {
            SideOne = value1;
            SideTwo = value2;
            SideThree = value1;
            SideFour = value2;
        }
        public double Perimeter()
        {
            if (ZeroValue())
                return 2 * (SideOne + SideTwo);
            else
                return -1;
        }
        public double Area()
        {
            if (ZeroValue())
                return SideOne * SideTwo;
            else
                return -1;
        }
    }
}