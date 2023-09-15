using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2.Classes
{
    public class isPermutationClass
    {
        public static bool IsPermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            int[] charCount = new int[256];

            for (int i = 0; i < str1.Length; i++)
            {
                int val = str1[i];

                charCount[val]++;
            }

            for (int i = 0; i < str2.Length; i++)
            {
                int val = str2[i];

                if (--charCount[val] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
