using System;
using System.Dynamic;

namespace Operator_Exer
{
    class Program
    {
        public static double AreaOfCircle(double rad)
        {
            double pi = 3.14;
            return pi * (rad * rad); ;

        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quot = a / b;
            int remain = a % b;

            Console.WriteLine($"{a}/{b} is {quot} remainder of {remain}");

            Console.WriteLine("What is the radius?");
            var rad = Convert.ToDouble(Console.ReadLine() );
            var area = AreaOfCircle(rad);
            Console.WriteLine($"The area of a circle with radius of {rad} is {area}");


        }
    }
}
