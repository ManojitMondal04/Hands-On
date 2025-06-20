using System;
using System.Collections.Generic;

namespace FinancialForecasting
{
    public class FinancialForecaster
    {
        private Dictionary<int, double> memo = new Dictionary<int, double>();

        public double PredictFutureValue(int years, double initialValue, double annualGrowthRate)
        {
            if (years == 0)
                return initialValue;

            if (memo.ContainsKey(years))
                return memo[years];

            double previousValue = PredictFutureValue(years - 1, initialValue, annualGrowthRate);
            double currentValue = previousValue * (1 + annualGrowthRate);
            memo[years] = currentValue;

            return currentValue;
        }
    }
}
