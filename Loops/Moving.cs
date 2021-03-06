using System;

namespace Moving
{
    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string final = Console.ReadLine();

            int allSpace = 0;                       
            int roomSpace = width * length * height;

            while (final != "Done")
            {
                int box = int.Parse(final);
                allSpace = allSpace + box;
                
                if (allSpace > roomSpace)
                {
                    int needSpace = Math.Abs(allSpace - roomSpace);
                    Console.WriteLine($"No more free space! You need {needSpace} Cubic meters more.");
                    break;
                }

                final = Console.ReadLine();

                if (final == "Done")
                {
                    int freeSpace = roomSpace - allSpace;
                    Console.WriteLine($"{freeSpace} Cubic meters left.");
                }                
            }
        }
    }
}
