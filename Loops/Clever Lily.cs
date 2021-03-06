using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingmachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            
            int money = 0;
            int addMoney = 0;
            int toyMoney = 0;
            int brother = 0;           

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    addMoney += money;
                    brother += 1;
                }
                else
                {
                    toyMoney += toyPrice;
                }
            }

            int allMoney = (addMoney + toyMoney) - brother;

            if (allMoney >= priceOfWashingmachine)
            {
                double diff = allMoney - priceOfWashingmachine;
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                double diff = priceOfWashingmachine - allMoney;
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
