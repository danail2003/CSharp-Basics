using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            
            int sum = 0;
            int vowels = text.Length;
            
            for (int i = 0; i < vowels; i++)
            {
                if (text[i] == 'a')
                {
                    sum += 1;
                }
                else if (text[i] == 'e')
                {
                    sum += 2;
                }
                else if (text[i] == 'i')
                {
                    sum += 3;
                }
                else if (text[i] == 'o')
                {
                    sum += 4;
                }
                else if (text[i] == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
