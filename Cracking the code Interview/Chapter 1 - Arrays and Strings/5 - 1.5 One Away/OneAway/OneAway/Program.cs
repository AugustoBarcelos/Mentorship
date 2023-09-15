/* One Away: There re three types of edits that can be performed on strings: insert a character, remove a character or replace a character. 
 * Given two strings, write a function to check if there are one edit (or zero edits) away.
 * Example:
 * Pale, ple -> true
 * pales,  pale -> true
 * pale, bale -> true
 * pale, bake -> false */

class Program
{
    static bool IsOneEditAway(string s1, string s2)
    {
        // Check if the difference in length is more than 1
        if (Math.Abs(s1.Length - s2.Length) > 1)
        {
            return false;
        }
        // Initialize variables for the shorter and longer strings
        string shorter = s1.Length < s2.Length ? s1 : s2;
        string longer = s1.Length < s2.Length ? s2 : s1;
        // Initialize variables for the indices of the shorter and longer strings
        int i = 0;
        int j = 0;
        bool foundDifference = false;
        // Iterate over the characters in the shorter and longer strings
        while (i < shorter.Length && j < longer.Length)
        {
            // If the characters don't match, mark a difference and move the index of the longer string
            if (shorter[i] != longer[j])
            {
                // If a difference has already been found, return false
                if (foundDifference)
                {
                    return false;
                }
                foundDifference = true;
                // If the strings are the same length, move the index of the shorter string
                if (shorter.Length == longer.Length)
                {
                    i++;
                }
            }
            // Move the index of the shorter string
            else
            {
                i++;
            }
            // Move the index of the longer string
            j++;
        }
        // If the strings are different lengths and the last character of the longer string was different, mark a difference
        if (foundDifference && shorter.Length != longer.Length && j == longer.Length - 1)
        {
            foundDifference = true;
        }
        // Return true if at most one difference has been found
        return !foundDifference;
    }

    static void Main(string[] args)
    {
        // Example usage of the function
        string s1 = "pale";
        string s2 = "pal";
        bool isOneEditAway = IsOneEditAway(s1, s2);
        Console.WriteLine(isOneEditAway); // Output: True
    }
}
