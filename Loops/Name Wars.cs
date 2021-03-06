using System;

namespace Name_Wars
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            
            int sum = int.MinValue;
            int max = 0;
            string winner = "";

            while (name != "STOP")
            {
                for(int i = 0; i < name.Length; i++)
                {
                    int input = name[i];
                    max += input;
                }

                if (max > sum)
                {
                    winner = name;
                    sum = max;
                }

                max = 0;

                name = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {winner} - {sum}!");
        }
    }
}
