using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main()
        {
            int symbols = int.Parse(Console.ReadLine());
            
            int total = 0;

            for (int i = 0; i < symbols; i++)
            {
                char digit = char.Parse(Console.ReadLine());
                total += digit;
            }

            Console.WriteLine($"The sum equals: {total}");
        }
    }
}
