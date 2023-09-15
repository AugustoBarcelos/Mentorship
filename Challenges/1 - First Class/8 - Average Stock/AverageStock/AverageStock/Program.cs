using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the minimun quantity of the stock");
        int min = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the maximum quantity of the stock");
        int max = int.Parse(Console.ReadLine());

        double avg = (min+max)/2;

        Console.WriteLine($"The average Stock is: {avg}");
    }
}