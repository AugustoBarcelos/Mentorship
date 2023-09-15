using System.Linq;

namespace Calculator
{
    public class Calculations
    {
        public double CalculateSum(double[] numbers)
        {
            return numbers.Sum();
        }

        public double CalculateAverage(double[] numbers)
        {
            return numbers.Average();
        }
    }
}