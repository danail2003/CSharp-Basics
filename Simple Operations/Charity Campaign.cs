using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            
            int priceOfCakes = cakes * 45;
            double priceOfWaffles = waffles * 5.80;
            double priceOfPancakes = pancakes * 3.20;
            double totalForDay = (priceOfCakes + priceOfWaffles + priceOfPancakes) * confectioners;
            double totalValue = totalForDay * days;
            double value = totalValue - (totalValue / 8);
            
            Console.WriteLine($"{value:f2}");
        }
    }
}
