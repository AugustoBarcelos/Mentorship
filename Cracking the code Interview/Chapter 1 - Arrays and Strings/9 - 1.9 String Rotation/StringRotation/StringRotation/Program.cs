/* STRING ROTATION: Assume you have a method isSubStrint which checks if one word is substring of another. Given two strings s1 and s2. 
 * write a code in c# to check if s2 is a roatio of s1 using only one call to isSubString (e.g. "waterbottle" is a rotation of "erbottlewat") */

public class StringRotation
{
    public static void Main(string[] args)
    {
        string s1 = "waterbottle";
        string s2 = "erbottlewat";
        bool isRotation = IsRotation(s1, s2);
        Console.WriteLine(isRotation);
    }

    private static bool IsRotation(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        string s1s1 = s1 + s1;
        return IsSubstring(s1s1, s2);
    }

    private static bool IsSubstring(string s1, string s2)
    {
        return s1.Contains(s2);
    }
}
