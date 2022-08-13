using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var characters = new Dictionary<char, int>();
            int maxLength = 0;
            int leftPointer = 0, rightPointer = 0;
            while (rightPointer < s.Length)
            {
                if (!characters.ContainsKey(s[rightPointer]))
                {
                    characters[s[rightPointer]] = 0;
                }

                characters[s[rightPointer]]++;
                while (characters[s[rightPointer]] > 1)
                {
                    characters[s[leftPointer]]--;
                    leftPointer++;
                }

                if (rightPointer - leftPointer >= maxLength)
                    maxLength = rightPointer - leftPointer + 1;

                rightPointer++;
            }

            return maxLength;
        }
    }
}
