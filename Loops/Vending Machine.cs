using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main()
        {
            string coins = Console.ReadLine();
            
            double sumCoins = 0;
            
            while (coins != "Start")
            {
                double convertCoins = double.Parse(coins);
                
                if(convertCoins != 0.1 && convertCoins != 0.2 && convertCoins != 0.5 && convertCoins != 1 && convertCoins != 2)
                {
                    Console.WriteLine($"Cannot accept {convertCoins}");
                }

                if(!(convertCoins != 0.1 && convertCoins != 0.2 && convertCoins != 0.5 && convertCoins != 1 && convertCoins != 2))
                {
                    sumCoins += convertCoins;
                }
                
                coins = Console.ReadLine();
            }

            string product = Console.ReadLine();
            
            double price = 0;            

            while (product != "End")
            {
                if (product == "Nuts")
                {
                    price += 2;
                    if (sumCoins >= price)
                    {
                        sumCoins -= price;
                        Console.WriteLine("Purchased nuts");                       
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    price = 0;
                }
                else if (product == "Water")
                {
                    price += 0.7;
                    if (sumCoins >= price)
                    {
                        sumCoins -= price;
                        Console.WriteLine("Purchased water");                       
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    price = 0;
                }
                else if (product == "Crisps")
                {
                    price += 1.50;
                    if (sumCoins >= price)
                    {
                        sumCoins -= price;
                        Console.WriteLine("Purchased crisps");                       
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    price = 0;
                }
                else if (product == "Soda")
                {
                    price += 0.8;
                    if (sumCoins >= price)
                    {
                        sumCoins -= price;
                        Console.WriteLine("Purchased soda");                       
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    price = 0;
                }
                else if (product == "Coke")
                {
                    price += 1;
                    if (sumCoins >= price)
                    {
                        sumCoins -= price;                       
                        Console.WriteLine("Purchased coke");                      
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    price = 0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }            

                product = Console.ReadLine(); 
            }

            Console.WriteLine($"Change: {sumCoins:f2}");
        }
    }
}
