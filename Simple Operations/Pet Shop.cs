using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main()
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfAnimals=int.Parse(Console.ReadLine());
            
            double priceOfDogs = numberOfDogs * 2.50;
            double priceOfAnimals = numberOfAnimals * 4;
            
            Console.WriteLine($"{priceOfDogs+priceOfAnimals:f2} lv.");
        }
    }
}
