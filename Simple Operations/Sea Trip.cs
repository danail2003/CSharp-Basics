using System;

namespace Sea_Trip
{
    class Program
    {
        static void Main()
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSouvenir = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());
            
            double km = 420;
            double benzin = km / 100 * 7;           
            double moneyForBenzin = benzin * 1.85;
            double threeDays = (3 * moneyForFood) + (3 * moneyForSouvenir);
            double firstDayHotel = moneyForHotel * 0.9;
            double secondDayHotel = moneyForHotel * 0.85;
            double thirdDayHotel = moneyForHotel * 0.8;
            double total = moneyForBenzin + threeDays + firstDayHotel + secondDayHotel + thirdDayHotel;

            Console.WriteLine($"Money needed: {total:f2}");
        }
    }
}
