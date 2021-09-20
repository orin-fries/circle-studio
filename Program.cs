using System;

namespace Circlestudio
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            double area;

            Console.WriteLine("Enter a radius: ");
            radius = int.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;

            Console.WriteLine("The circle's area is: " + Math.Round(area, 2));
        }
    }
}
