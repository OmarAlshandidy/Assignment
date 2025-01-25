using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigment03.Interfaces;

namespace Assigment03
{
    class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Radius * Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }



        public void DisplayShape()
        {
            Console.WriteLine($"Shape: Circle, Radius: {Radius}, Area: {Area}");
        }
    }
}

