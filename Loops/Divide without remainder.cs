using System;

namespace Divide_without_remainder
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;

            for(int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    sum1 += 1;
                }

                if (number % 3 == 0)
                {
                    sum2 += 1;
                }

                if (number % 4 == 0)
                {
                    sum3 += 1;
                }
            }

            sum1 = sum1 / numbers * 100;
            sum2 = sum2 / numbers * 100;
            sum3 = sum3 / numbers * 100;

            Console.WriteLine($"{sum1:f2}%");
            Console.WriteLine($"{sum2:f2}%");
            Console.WriteLine($"{sum3:f2}%");
        }
    }
}
