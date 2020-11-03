/*****************************************************
 * Developer: Kryuchkov Alexander                    *
 * Repository link:                                  *
 * https://github.com/GreyMiller13/Geometric_Figures *
 * Email: grey.miller13@gmail.com                    *
 *****************************************************/

using System;

namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadrangle");
            Quadrangle quadrangle = new Quadrangle(11, 12, 13, 14);
            Console.WriteLine("Area:" + quadrangle.Area());
            Console.WriteLine("Perimeter:" + quadrangle.Perimeter() + "\n");

            Console.WriteLine("Square");
            Square square = new Square(10);
            Console.WriteLine("Area:" + square.Area());
            Console.WriteLine("Perimeter:" + square.Perimeter() + "\n");

            Console.WriteLine("Rectangle");
            Rectangle rectangle = new Rectangle(11, 10);
            Console.WriteLine("Area:" + rectangle.Area());
            Console.WriteLine("Perimeter:" + rectangle.Perimeter() + "\n");

            Console.WriteLine("Rhomb");
            Rhomb rhomb = new Rhomb(10, 11);
            Console.WriteLine("Area:" + rhomb.Area());
            Console.WriteLine("Perimeter:" + rhomb.Perimeter() + "\n");

            Console.WriteLine("Parallelogram");
            Parallelogram parallelogram = new Parallelogram(11, 10.5, 8.7);
            Console.WriteLine("Area:" + parallelogram.Area());
            Console.WriteLine("Perimeter:" + parallelogram.Perimeter() + "\n");

            Console.WriteLine("Trapeze");
            Trapeze trapeze = new Trapeze(11, 13, 12, 8, 14);
            Console.WriteLine("Area:" + trapeze.Area());
            Console.WriteLine("Perimeter:" + trapeze.Perimeter() + "\n");

            Console.WriteLine("Triangle");
            Triangle triangle = new Triangle(6, 4.5, 7, 8);
            Console.WriteLine("Area:" + triangle.Area());
            Console.WriteLine("Perimeter:" + triangle.Perimeter() + "\n");

            Console.WriteLine("Circle");
            Circle circle = new Circle(10.5);
            Console.WriteLine("Area:" + circle.Area());
            Console.WriteLine("Perimeter:" + circle.Perimeter() + "\n");

            Console.WriteLine("Ellipse");
            Ellipse ellipse = new Ellipse(5.6, 4);
            Console.WriteLine("Area:" + ellipse.Area());
            Console.WriteLine("Perimeter:" + ellipse.Perimeter() + "\n");

            Console.WriteLine("Sphere");
            Sphere sphere = new Sphere(5.5);
            Console.WriteLine("Area:" + sphere.AreaSphere());
            Console.WriteLine("Volume:" + sphere.VolumeSphere() + "\n");
        }
    }
}
