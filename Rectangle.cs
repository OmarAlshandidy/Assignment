using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigment03.Interfaces;

namespace Assigment03
{
     class Rectangle : IRectangle
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; set; }
        public double Width { get; set; }

        public double Area => Length * Width;

        public void DisplayShape()
        {
            Console.WriteLine($"Shape: Rectangle, Length: {Length}, " +
                $"Width: {Width}, Area: {Area}");
        }
    }
}
