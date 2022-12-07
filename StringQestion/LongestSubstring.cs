using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQestion
{
    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = s.Length;  

            var list = new List<char>();

            int result = 0;

            for(int i = 0; i < length; i++)
            {
                for(int j = i; j < length; j++)
                {
                    if (list.Contains(s[j]))
                    {
                        list.Clear();
                        break;
                    }
                    else
                    {
                        list.Add(s[j]);
                        if(result < j-i + 1)
                        {
                            result = j-i + 1;
                        }
                    }
                }
            }
            return result;
        }
    }
}
