using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQestion
{
    public class StringMultiply
    {
        public static int CharToInt(char ch)
        {
            return ch - '0';
        }
        public static string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
            {
                return "0";
            }
            var solution = new int[num1.Length + num2.Length];
            for (int num1Index = num1.Length - 1; num1Index >= 0; --num1Index)
            {
                for (int num2Index = num2.Length - 1; num2Index >= 0; --num2Index)
                {
                    var currentIndex = num1Index + num2Index + 1;
                    var value = CharToInt(num1[num1Index]) * CharToInt(num2[num2Index]);
                    solution[currentIndex] += value;
                    if (solution[currentIndex] > 9)
                    {
                        var carry = solution[currentIndex] / 10;
                        solution[currentIndex - 1] += carry;
                        var digit = solution[currentIndex] % 10;
                        solution[currentIndex] = digit;
                    }
                }
            }
            var zeroIndex = 0;
            while (zeroIndex < solution.Length && solution[zeroIndex] == 0)
            {
                ++zeroIndex;
            }
            var result = new StringBuilder();
            for (int index = zeroIndex; index < solution.Length; ++index)
            {
                result.Append(solution[index]);
            }
            return result.ToString();
        }
    }
}
