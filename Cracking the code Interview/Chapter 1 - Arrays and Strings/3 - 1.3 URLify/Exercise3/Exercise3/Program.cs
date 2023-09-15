// URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end to hold additional characters, and that you are given the "true" lenght of the string.

static void URLify(char[] str, int trueLength)
{
    int spaceCount = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ') 
        {
            spaceCount++;
        }
    }

    int index = trueLength + spaceCount *2;

    for(int i = trueLength -1; i>-0; i--)
    {
        if (str[i] == ' ')
        {
            str[--index] = '0';
            str[--index] = '1';
            str[--index] = '2';
        }
        else
        {
            str[--index] = str[i];
        }
    }
}