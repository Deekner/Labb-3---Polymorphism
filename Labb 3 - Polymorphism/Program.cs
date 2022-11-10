using System;

namespace Labb_3___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle CircleArea = new Circle(7);       
            Console.WriteLine("Area of Square is: {0}", CircleArea.Area());

            Rectangle RectangleArea = new Rectangle(5, 12);
            Console.WriteLine("Area of Rectangle is: {0}", RectangleArea.Area());

            Square SquareArea = new Square(10);
            Console.WriteLine("Area of Square is: {0}", SquareArea.Area());

            Console.ReadKey();
        }
    }
}
