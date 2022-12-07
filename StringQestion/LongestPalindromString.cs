using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQestion
{
    public class LongestPalindromString
    {
        bool IsPalindrom(string s , int i, int j)
        {
            while (i <= j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++; j--;
            }
            return true;
        }

        public string LongestPalindrome(string s)
        {
            var length = s.Length;
            int max = 0;
            int start = 0;

            for(int i = 0; i < length; i++)
            {
                for(int j = i; j < length; j++)
                {
                    if (IsPalindrom(s, i, j))
                    {
                        if (j - i + 1 > max)
                        {
                            max = j - i + 1;
                            start = i;
                        }
                    }
                }
            }
            var result = s.Substring(start,max);

            return result;
        }
    }
}
