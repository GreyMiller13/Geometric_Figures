using System;
using _Quadrilaterals_;

namespace GeometricFigures
{
    class Square : Quadrilaterals
    {
        public Square(double value1)
        {
            SideOne = value1;
            SideTwo = value1;
            SideThree = value1;
            SideFour = value1;
        }
        public double Perimeter()
        {
            if (ZeroValue())
                return 4 * SideOne;
            else
                return -1;
        }
        public double Area()
        {
            if (ZeroValue())
                return Math.Pow(SideOne, 2);
            else
                return -1;
        }
    }
}
