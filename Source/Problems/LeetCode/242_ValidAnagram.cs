using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var charDictionary = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!charDictionary.ContainsKey(c))
                {
                    charDictionary[c] = 0;
                }

                charDictionary[c] = charDictionary[c] + 1;
            }

            foreach (char c in t)
            {
                if (!charDictionary.ContainsKey(c))
                {
                    return false;
                }

                charDictionary[c] = charDictionary[c] - 1;
                if (charDictionary[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
