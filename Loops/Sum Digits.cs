using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            int total = 0;

            while (number > 0)
            {
                total += number % 10;
                number /= 10;
            }

            Console.WriteLine(total);
        }
    }
}
