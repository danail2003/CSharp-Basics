using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            BigInteger maxValue = 0;
            int endSnowball = 0;
            int endSnowballTime = 0;
            int endSnowballQuality = 0;

            while (counter < number)
            {
                int snowball = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                
                BigInteger formula = BigInteger.Pow(snowball / snowballTime, snowballQuality);               

                if (formula > maxValue)
                {
                    maxValue = formula;
                    endSnowball = snowball;
                    endSnowballTime = snowballTime;
                    endSnowballQuality = snowballQuality;
                }

                counter++;
            }
            
            Console.WriteLine($"{endSnowball} : {endSnowballTime} = {maxValue} ({endSnowballQuality})");
        }
    }
}
