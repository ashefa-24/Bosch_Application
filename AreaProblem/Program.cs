using System;

namespace AreaProblem
{
    class Program
    {
        static void Rectangle()
        {
            int length, breadth, result;
            length = 2;
            breadth = 4;
            result = length * breadth;
            Console.WriteLine("Area of the rectangle = " + result);
        }
        static void Circle()
        {
            double res;
            res = 3.14 * 5 * 5;
            Console.WriteLine("Area of the circle = " + res);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Area of Rectangle");
            Rectangle();
            Console.WriteLine("Area of Circle");
            Circle();
        }
    }
}
