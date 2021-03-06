using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            
            int previousSum = 0;
            int max = 0;

            for(int i = 0; i <  numbers; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                int currentSum = firstNumber + secondNumber;
                int diff = Math.Abs(currentSum - previousSum);

                if (diff > max && i > 0)
                {
                    max = diff;
                }

                previousSum = currentSum;
            }

            if (max == 0)
            {
                Console.WriteLine($"Yes, value={previousSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={max}");
            }
        }
    }
}
