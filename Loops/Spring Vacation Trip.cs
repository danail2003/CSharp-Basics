using System;

namespace Spring_Vacation_Trip
{
    class Program
    {
        static void Main()
        {
            int daysOfTrip = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int groupOfPeople = int.Parse(Console.ReadLine());
            double priceForKm = double.Parse(Console.ReadLine());
            double foodForDay = double.Parse(Console.ReadLine());
            double priceForRoom = double.Parse(Console.ReadLine());

            double foodExpenses = daysOfTrip * groupOfPeople * foodForDay;
            
            double priceForHotel;
            if (groupOfPeople > 10)
            {
                priceForHotel = daysOfTrip * groupOfPeople * priceForRoom * 0.75;
            }
            else
            {
                priceForHotel = daysOfTrip * groupOfPeople * priceForRoom;
            }

            double currentExpenses = foodExpenses + priceForHotel;

            double diff;
            for (int i = 1; i <= daysOfTrip; i++)
            {
                double travelledKm = double.Parse(Console.ReadLine());

                double fuelExpenses = travelledKm * priceForKm;
                currentExpenses += fuelExpenses;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    currentExpenses += (currentExpenses * 0.4);
                }

                if (i % 7 == 0)
                {
                    double withdraw = currentExpenses / groupOfPeople;
                    currentExpenses -= withdraw;
                }

                if (budget < currentExpenses)
                {
                    diff = currentExpenses - budget;
                    Console.WriteLine($"Not enough money to continue the trip. You need {diff:f2}$ more.");
                    return;
                }
            }

            diff = budget - currentExpenses;
            
            Console.WriteLine($"You have reached the destination. You have {diff:f2}$ budget left.");
        }
    }
}
