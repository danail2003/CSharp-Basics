using System;

namespace FromInchToCentimetres
{
    class Program
    {
        static void Main()
        {
            double inches = double.Parse(Console.ReadLine());
            
            double centimeters = inches * 2.54;
            
            Console.WriteLine("{0:f2}",centimeters);            
        }
    }
}
