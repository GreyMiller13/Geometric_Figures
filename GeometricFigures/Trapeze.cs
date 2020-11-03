using System;
using _Quadrilaterals_;

namespace GeometricFigures
{
    class Trapeze : Quadrilaterals
    {
        public Trapeze(double value1, double value2, double value3, double value4, double height)
        {
            SideOne = value1;
            SideTwo = value2;
            SideThree = value3;
            SideFour = value4;
            Height = height;
        }
        public double Perimeter()
        {
            if (ZeroValue() && Height > 0)
                return SideOne + SideTwo + SideThree + SideFour;
            else
                return -1;
        }
        public double Area()
        {
            if (ZeroValue() && Height > 0)
                return (SideOne + SideTwo) / 2 * Height;
            else
                return -1;
        }
    }
}