/*1.4 - Palindrome Permutation: Given an string, write a funcion to check if it is a permutation of a palindrome. 
 * A palindrome is a word that is the same forwards and backwards. A permutation is a rearrangement of letters. The palindrome does not need to be limited 
 * to just dictionary words, example: 
 * Input: Tact Coa
 * Output: True(permutations: "taco cat","atco cta", etc)*/

using System;
using System.Collections.Generic;

class Program
{
    static bool IsPermutationPalindrome(string s)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (Char.IsLetter(c))
            {
                char lowerC = Char.ToLower(c);
                if (charCount.ContainsKey(lowerC))
                {
                    charCount[lowerC]++;
                }
                else
                {
                    charCount[lowerC] = 1;
                }
            }
        }
        int oddCount = 0;
        foreach (int count in charCount.Values)
        {
            if (count % 2 == 1)
            {
                oddCount++;
                if (oddCount > 1)
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        string s = "Tact Coa";
        bool isPermutationPalindrome = IsPermutationPalindrome(s);
        Console.WriteLine(isPermutationPalindrome);
    }
}