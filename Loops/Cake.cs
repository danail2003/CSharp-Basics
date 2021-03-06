using System;

namespace Cake
{
    class Program
    {
        static void Main()
        {
            int widthOfCake = int.Parse(Console.ReadLine());
            int lengthOfCake = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
            int allPieces = 0;

            while (command != "STOP")
            {
                allPieces += int.Parse(command);

                if (allPieces > widthOfCake * lengthOfCake)
                {
                    allPieces = allPieces - (widthOfCake * lengthOfCake);
                    Console.WriteLine($"No more cake left! You need {allPieces} pieces more.");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "STOP")
            {
                allPieces = lengthOfCake * widthOfCake - allPieces;
                Console.WriteLine($"{allPieces} pieces are left.");                
            }
        }
    }
}
