using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    public class Square : Geometry
    {
        public double _a2 { get; set; }


        //Constructor
        public Square(double A2) //Initiate
        {
            _a2 = A2;
        }

        //Method for calculating the area for a Square
        public override double Area()
        {
            return _a2 * _a2;
        }
    }
}
