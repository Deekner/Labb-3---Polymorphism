using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    public class Rectangle : Geometry
    {
        public double _Widht { get; set; }
        public double _length { get; set; }


        //Constructor
        public Rectangle(double widht, double length) //initate
        {
            _Widht = widht;
            _length = length;
        }

        //Method for calculating the area for a rectangle
        public override double Area()
        {
            return _Widht * _length;
        }
    }
}
