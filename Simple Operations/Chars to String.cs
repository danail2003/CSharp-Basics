using System;

namespace Chars_to_String
{
    class Program
    {
        static void Main()
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstSymbol}{secondSymbol}{thirdSymbol}");
        }
    }
}
