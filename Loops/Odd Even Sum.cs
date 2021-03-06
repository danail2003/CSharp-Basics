using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            
            int evenPosition = 0;
            int oddPosition = 0;

            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 ==0)
                {
                    evenPosition += number;
                }
                else
                {
                    oddPosition += number;
                }
            }

            if (evenPosition == oddPosition)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenPosition}");
            }
            else
            {
                int diff = Math.Abs(evenPosition - oddPosition);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
