using System;

namespace Biscuits_Factory
{
    class Program
    {
        static void Main()
        {
            int amountOfBiscuits = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int otherFactory = int.Parse(Console.ReadLine());

            double totalBiscuits = (20 * workers * amountOfBiscuits) + Math.Floor(workers * amountOfBiscuits * 0.75) * 10;

            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");

            if (totalBiscuits > otherFactory)
            {
                double percentage = totalBiscuits - otherFactory;
                double diff = percentage / otherFactory * 100;
                
                Console.WriteLine($"You produce {diff:f2} percent more biscuits.");
            }
            else
            {
                double percentage = otherFactory - totalBiscuits;
                double diff = percentage / otherFactory * 100;
                
                Console.WriteLine($"You produce {diff:f2} percent less biscuits.");
            }
        }
    }
}
