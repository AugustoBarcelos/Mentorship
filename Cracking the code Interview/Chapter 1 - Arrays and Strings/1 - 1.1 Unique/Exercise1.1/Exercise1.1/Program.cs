//1.1 - IS UNIQUE - Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?

static bool IsUnique(string str)
{
    for (int i = 0; i < str.Length - 1; i++)
    {
        for (int j = i + 1; j < str.Length; j++)
        {
            if (str[i] == str[j])
            {
                return false;
            }
        }
    }

    return true;
}