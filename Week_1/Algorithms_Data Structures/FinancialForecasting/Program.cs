using System;
using FinancialForecasting;

class Program
{
    static void Main(string[] args)
    {
        FinancialForecaster forecaster = new FinancialForecaster();

        // Forecast parameters
        double initialValue = 10000;       // Starting value (e.g., investment)
        double growthRate = 0.08;          // 8% annual growth
        int years = 10;                    // Forecast over 10 years

        double futureValue = forecaster.PredictFutureValue(years, initialValue, growthRate);

        Console.WriteLine($"Future Value after {years} years: {futureValue:C2}");

        Console.WriteLine("\n--- Analysis ---");
        Console.WriteLine("Recursive Time Complexity (without memoization): O(2^n)");
        Console.WriteLine("Optimized with memoization: O(n)");
        Console.WriteLine("Memoization improves performance by storing previous results.");
    }
}
