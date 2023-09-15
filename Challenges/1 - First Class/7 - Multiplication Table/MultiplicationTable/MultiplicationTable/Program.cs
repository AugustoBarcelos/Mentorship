using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número para obter a tabuada de 0 a 10:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"A tabuada solicitada foi: {number}\n");

        for (int i = 0; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}