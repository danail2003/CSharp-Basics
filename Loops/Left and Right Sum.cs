using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            
            int firstNumbers = 0;
            int secondNumbers = 0;

            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstNumbers += number;
            }

            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondNumbers += number;
            }

            if (firstNumbers == secondNumbers)
            {
                Console.WriteLine($"Yes, sum = {firstNumbers}");
            }
            else
            {
                int diff = Math.Abs(firstNumbers - secondNumbers);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
