using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            if (inputMetric == "cm")
            {
                number /= 100;
            }
            else if (inputMetric == "mm")
            {
                number /= 1000;
            }
            if (outputMetric == "mm")
            {
                number *= 1000;
            }
            else if (outputMetric == "cm")
            {
                number *= 100;
            }
            
            Console.WriteLine($"{number:f3}");
        }
    }
}
