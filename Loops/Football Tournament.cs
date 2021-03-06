using System;

namespace Football_Tournament
{
    class Program
    {
        static void Main()
        {
            string team = Console.ReadLine();
            int countTournaments = int.Parse(Console.ReadLine());
            
            int total = 0;
            double w = 0;
            int d = 0;
            int l = 0;

            for (int i = 0; i < countTournaments; i++)
            {
                char result = char.Parse(Console.ReadLine());

                if (result == 'W')
                {
                    total += 3;
                    w++;
                }
                else if (result == 'D')
                {
                    total += 1;
                    d++;
                }
                else if (result == 'L')
                {
                    total += 0;
                    l++;
                }
            }

            double percent = w / countTournaments * 100;

            if (countTournaments == 0)
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
            }
            else if (countTournaments > 0)
            {
                Console.WriteLine($"{team} has won {total} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {w}");
                Console.WriteLine($"## D: {d}");
                Console.WriteLine($"## L: {l}");
                Console.WriteLine($"Win rate: {percent:f2}%");
            }
        }
    }
}
