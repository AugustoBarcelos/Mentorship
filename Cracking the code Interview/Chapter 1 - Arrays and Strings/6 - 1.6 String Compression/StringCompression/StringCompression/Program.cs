/* String Compression: Implement a method to performe basic string compression using the counts of repeated characters.For example, the string aabcccccaaa would become a2b1c5a3.
 * If the "compressed" string would not become smaller than the original string, your method should return the original string. You can assume the string has only uppercase and lowercase letters (a-z)/*
 */

using System;
using System.Text;

class StringCompression
{
    static void Main(string[] args)
    {
        string input = "aabcccccaaa";
        string output = Compress(input);
        Console.WriteLine(output);
    }

    private static string Compress(string s)
    {
        StringBuilder sb = new StringBuilder();
        int count = 1;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                count++;
            }
            else
            {
                sb.Append(s[i - 1]).Append(count);
                count = 1;
            }
        }
        sb.Append(s[s.Length - 1]).Append(count);

        string compressed = sb.ToString();
        if (compressed.Length >= s.Length)
        {
            return s;
        }
        else
        {
            return compressed;
        }
    }
}