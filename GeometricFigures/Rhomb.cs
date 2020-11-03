using System;
using _Quadrilaterals_;

namespace GeometricFigures
{
    class Rhomb : Quadrilaterals
    {
        public Rhomb(double value1, double height)
        {
            SideOne = value1;
            SideTwo = value1;
            SideThree = value1;
            SideFour = value1;
            Height = height;
        }
        public double Perimeter()
        {
            if (ZeroValue() && Height > 0)
            {
                if (SideOne > Height)
                    return 4 * SideOne;
                else
                    return 4 * Height;
            }
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