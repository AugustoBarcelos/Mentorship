using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of values to calculate (between 3 and 10):");
            int count;
            if (int.TryParse(Console.ReadLine(), out count) && count >= 3 && count <= 10)
            {
                double[] numbers = new double[count];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"Enter value {i + 1}:");
                    double number;
                    if (double.TryParse(Console.ReadLine(), out number))
                    {
                        numbers[i] = number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }
                }

                Calculations calculations = new Calculations();
                double sum = calculations.CalculateSum(numbers);
                double average = calculations.CalculateAverage(numbers);

                Console.WriteLine($"The sum of the {count} numbers is: {sum}");
                Console.WriteLine($"The average of the {count} numbers is: {average:F2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 3 and 10.");
            }
        }
    }
}