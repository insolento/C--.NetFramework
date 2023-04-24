using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Square square = new Square(4,5);
            Triangle triangle = new Triangle();
            rectangle.Height = 5;
            rectangle.Width = 7;
            triangle.Height = 6;
            triangle.Width = 7;
            FigureInfo(rectangle);
            FigureInfo(square);
            FigureInfo(triangle);
        }
        static void FigureInfo(GeometricFigure figure)
        {
            Console.WriteLine($"Height of the figure is {figure.Height}");
            Console.WriteLine($"Width of the figure is {figure.Width}");
            Console.WriteLine($"Area of the figure is {figure.Area}");
            Console.WriteLine();
        }
    }
}

