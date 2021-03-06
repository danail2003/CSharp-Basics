using System;

namespace Bus
{
    class Program
    {
        static void Main()
        {
            int passengers = int.Parse(Console.ReadLine());
            int station = int.Parse(Console.ReadLine());
            
            int leaving = 0;
            int upcoming = 0;           
            int controllers = 0;

            for (int i = 1; i <= station; i++)
            {
                int leavingPassengers = int.Parse(Console.ReadLine());
                int upcomingPassengers = int.Parse(Console.ReadLine());

                leaving += leavingPassengers;
                upcoming += upcomingPassengers;

                if (station % 2 != 0)
                {
                    controllers = 2;
                }
            }

            int diff = passengers + upcoming - leaving + controllers;
            
            Console.WriteLine($"The final number of passengers is : {diff}");
        }
    }
}
