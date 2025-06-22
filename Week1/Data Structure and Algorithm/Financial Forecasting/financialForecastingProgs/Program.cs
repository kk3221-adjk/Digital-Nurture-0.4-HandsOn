using System;
using System.Collections.Generic;
using System.Globalization;

namespace financialForecastingProgs
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-IN");

            Console.WriteLine("=== Financial Forecasting Tool ===");
            Console.Write("Enter initial investment amount: ");
            decimal initialAmount = decimal.Parse(Console.ReadLine());

            Console.Write("Enter annual growth rate (e.g., 5 for 5%): ");
            double growthRate = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Enter number of years to forecast: ");
            int years = int.Parse(Console.ReadLine());

            Console.WriteLine("\n=== Forecast Results ===");
            Console.WriteLine($"Year 0: INR {initialAmount:N2}");

            ForecastRecursive(initialAmount, growthRate, years, 1);
        }

        static void ForecastRecursive(decimal currentAmount, double growthRate, int totalYears, int currentYear)
        {
            if (currentYear > totalYears)
                return;

            decimal newAmount = currentAmount * (1 + (decimal)growthRate);
            Console.WriteLine($"Year {currentYear}: INR {newAmount:N2}");

            ForecastRecursive(newAmount, growthRate, totalYears, currentYear + 1);
        }

        static decimal ForecastMemoized(decimal amount, double rate, int years, Dictionary<int, decimal> cache = null)
        {
            cache = cache ?? new Dictionary<int, decimal>();

            if (years == 0)
                return amount;

            if (cache.TryGetValue(years, out decimal cachedValue))
                return cachedValue;

            decimal result = ForecastMemoized(amount, rate, years - 1, cache) * (1 + (decimal)rate);
            cache[years] = result;
            return result;
        }
    }
}
