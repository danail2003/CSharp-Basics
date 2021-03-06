using System;

namespace Longer_Line
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double xFirst = double.Parse(Console.ReadLine());
            double yFirst = double.Parse(Console.ReadLine());
            double xSecond = double.Parse(Console.ReadLine());
            double ySecond = double.Parse(Console.ReadLine());

            double firstResult = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double secondResult = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));
            double thirdResult = Math.Sqrt(Math.Pow(yFirst, 2) + Math.Pow(xFirst, 2));
            double fourthResult = Math.Sqrt(Math.Pow(ySecond, 2) + Math.Pow(xSecond, 2));

            double firstPlane = firstResult + secondResult;
            double secondPlane = thirdResult + fourthResult;

            if (firstPlane > secondPlane)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({xSecond}, {ySecond})({xFirst}, {yFirst})");
            }
        }
    }
}
