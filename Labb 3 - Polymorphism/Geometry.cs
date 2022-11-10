using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    public class Geometry
    {
        public double area;

        public virtual double Area()
        {
            return area;
        }
    }
}
