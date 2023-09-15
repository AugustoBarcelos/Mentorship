using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Enter the Dolar_Reais Quotation:");
        double USD = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.WriteLine("Enter the amount in USD:");
        double amount = double.Parse(Console.ReadLine().Replace(',', '.'));

        double value = USD * amount;

        Console.WriteLine($"{amount} USD in BRL are: R${value}");
    }
}