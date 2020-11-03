using System;
using _Quadrilaterals_;

namespace GeometricFigures
{
    class Quadrangle : Quadrilaterals
    {
        public Quadrangle(double value1, double value2, double value3, double value4)
        {
            SideOne = value1;
            SideTwo = value2;
            SideThree = value3;
            SideFour = value4;
        }

        public double Perimeter()
        {
            if (ZeroValue())
                return SideOne + SideTwo + SideThree + SideFour;
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