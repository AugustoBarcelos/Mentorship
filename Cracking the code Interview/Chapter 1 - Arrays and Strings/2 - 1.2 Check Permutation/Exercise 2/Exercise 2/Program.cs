// 1.2 - Check permutation: Given two strings, write a method to decide if one is a permutation of the other

using System;
using Exercise_2.Classes;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        bool isPermutation1 = isPermutationClass.IsPermutation(str1, str2);

        if (isPermutation1)
        {
            Console.WriteLine("One string is a permutation of the other.");
        }
        else
        {
            Console.WriteLine("One string is not a permutation of the other.");
        }
    }
}