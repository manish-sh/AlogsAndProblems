using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var stringBuilder = new StringBuilder();
            foreach (var lowerChar in s.ToLower())
            {
                if ((lowerChar >= 'a' && lowerChar <= 'z') || (lowerChar >= '0' && lowerChar <= '9'))
                {
                    stringBuilder.Append(lowerChar);
                }
            }

            var finalString = stringBuilder.ToString();
            for (int i = 0, j = finalString.Length - 1; i < j; i++, j--)
            {
                if (finalString[i] != finalString[j])
                    return false;
            }

            return true;
        }
    }
}
