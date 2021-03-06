﻿using System;

namespace _Triangles_
{
    public class Triangles
    {
        private double sideOne;
        private double sideTwo;
        private double sideThree;
        private double height;

        public double SideOne
        {
            get { return sideOne; }
            set { ThrowExeption(value, ref sideOne); }
        }

        public double SideTwo
        {
            get { return sideTwo; }
            set { ThrowExeption(value, ref sideTwo); }
        }
        public double SideThree
        {
            get { return sideThree; }
            set { ThrowExeption(value, ref sideThree); }
        }
        public double Height
        {
            get { return height; }
            set { ThrowExeption(value, ref height); }
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
        public bool ZeroValue()
        {
            if (SideOne > 0 && SideTwo > 0 && SideThree > 0 && Height > 0)
                return true;
            else
                return false;
        }
    }
}