using System;
using _Ellipses_;

namespace GeometricFigures
{
    class Sphere : Ellipses
    {
        private readonly double pi;
        public Sphere(double radius)
        {
            pi = valuePI;
            Radius = radius;
        }
        public double AreaSphere()
        {
            if (Radius > 0)
                return 4 * pi * Math.Pow(Radius, 2);
            else
                return -1;
        }
        public double VolumeSphere()
        {
            if (Radius > 0)
                return 1.33 * pi * Math.Pow(Radius, 3);
            else
                return -1;
        }
    }
}