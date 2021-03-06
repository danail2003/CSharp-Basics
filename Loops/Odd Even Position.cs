using System;

namespace Odd__Even_Position
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double evenSum = 0.0;
            double oddMax = double.MinValue;
            double evenMax = double.MinValue;
            double oddMin = double.MaxValue;
            double evenMin = double.MaxValue;

            for (int i = 1; i <= numbers; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }

                    evenSum += number;
                }
                else
                {
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }

                    if (number < oddMin)
                    {
                        oddMin = number;
                    }

                    oddSum += number;
                }
            }

            if (numbers <= 1)
            {
                if (numbers == 0)
                {
                    Console.WriteLine($"OddSum={oddSum:f2},");
                    Console.WriteLine($"OddMin=No,");
                    Console.WriteLine($"OddMax=No,");
                    Console.WriteLine($"EvenSum={evenSum:f2},");
                    Console.WriteLine($"EvenMin=No,");
                    Console.WriteLine($"EvenMax=No");
                }
                else
                {
                    Console.WriteLine($"OddSum={oddSum:f2},");
                    Console.WriteLine($"OddMin={oddMin:f2},");
                    Console.WriteLine($"OddMax={oddMax:f2},");
                    Console.WriteLine($"EvenSum={evenSum:f2},");
                    Console.WriteLine($"EvenMin=No,");
                    Console.WriteLine($"EvenMax=No");
                }
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
