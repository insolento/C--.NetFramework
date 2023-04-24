using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    internal class Square: Rectangle
    {
        internal Square(double side)
        {
            Height = side;
            Width = side;
        }
        internal Square(double height, double width)
        {
           if (height != width)
            {
                Height = height;
                Width = Height;
            } else
            {
                Width = width;
                Height = height;
            } 
        }
    }
}
