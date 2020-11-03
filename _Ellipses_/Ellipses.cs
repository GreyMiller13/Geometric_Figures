using System;

namespace _Ellipses_

{
    public class Ellipses
    {
        private const double PI = 3.14;
        private double radius;
        private double halfShaftA;
        private double halfShaftB;

        public double valuePI
        {
            get { return PI; }
        }
        public double Radius
        {
            get { return radius; }
            set { ThrowExeption(value, ref radius); }
        }
        public double HalfShaftA
        {
            get { return halfShaftA; }
            set { ThrowExeption(value, ref halfShaftA); }
        }
        public double HalfShaftB
        {
            get { return halfShaftB; }
            set { ThrowExeption(value, ref halfShaftB); }
        }
        public void ThrowExeption(double value, ref double num)
        {
            try
            {
                if (value > 0) num = value;
                else throw new Exception("invalid value");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}. Try again please.");
            }
        }
    }
}