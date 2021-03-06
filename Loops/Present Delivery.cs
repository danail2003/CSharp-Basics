using System;
using System.Collections.Generic;
using System.Linq;

namespace Present_Delivery
{
    class Program
    {
        static void Main()
        {
            List<int> housesWithMembers = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            string command = Console.ReadLine();
            
            int length = 0;
            int counter = 0;
            int countOfList = housesWithMembers.Count;
            int totalLength = 0;

            while (command != "Merry Xmas!")
            {
                string[] token = command.Split();
                length = int.Parse(token[1]);               

                for (int i = 0; i < housesWithMembers.Count; i++)
                {                    
                    if (totalLength + length >= housesWithMembers.Count)
                    {
                        length = (length + totalLength) % housesWithMembers.Count;
                    }
                    else
                    {
                        totalLength += length;
                    }

                    if (housesWithMembers[length] == 0)
                    {
                        Console.WriteLine($"House {i} will have a Merry Christmas.");
                    }
                    else
                    {                        
                        housesWithMembers[i] -= 2;                       
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Santa's last position was {totalLength}.");

            if (housesWithMembers.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                for (int i = 0; i < housesWithMembers.Count; i++)
                {
                    if (housesWithMembers[i] > 0)
                    {
                        counter++;
                    }
                }

                Console.WriteLine($"Santa has failed {counter} houses.");
            }
        }
    }
}
