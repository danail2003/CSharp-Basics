using System;

namespace Easter_Cozonacs
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double kgFloor = double.Parse(Console.ReadLine());
            
            double priceForEggs = kgFloor * 0.75;
            double priceForMilk = kgFloor * 1.25;
            double milkFor250 = priceForMilk * 0.25;
            double totalPrice = priceForEggs + milkFor250 + kgFloor;
            int coloredEggs = 0;
            int cozonacs = 0;

            while (budget > totalPrice)
            {
                budget -= totalPrice;
                cozonacs++;
                coloredEggs += 3;

                if (cozonacs % 3 == 0)
                {
                    coloredEggs -= cozonacs-2;
                }
            }

            Console.WriteLine($"You made {cozonacs} cozonacs! Now you have {coloredEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
