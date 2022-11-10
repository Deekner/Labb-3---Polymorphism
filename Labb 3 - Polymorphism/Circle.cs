using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    public class Circle : Geometry
    {
        public double _radius { get; set; }
        public double _pi = 3.141;


        //Constructor
        public Circle(double radius) //Initiate
        {
            _radius = radius;
        }

        //Method for calculating the area for a Circle
        public override double Area()
        {
            return _radius * _radius * _pi;
        }
    }

}
