using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class MinimumWindowSubstring
    {
        public string MinWindow(string s, string t)
        {
            if (s.Length < t.Length)
            {
                return string.Empty;
            }

            var dictt = new Dictionary<char, int>();
            var dicts = new Dictionary<char, int>();
            for (int counter = 0; counter < t.Length; counter++)
            {
                if (!dictt.ContainsKey(t[counter]))
                {
                    dictt[t[counter]] = 0;
                }

                dictt[t[counter]]++;
            }

            int leftIndex = 0, rightIndex = t.Length;

            while (rightIndex < s.Length)
            {
                var cha = s[rightIndex];
                if (dicts.ContainsKey(cha))
                {
                    dicts[cha]++;
                }

                rightIndex++;
            }

            return string.Empty;
        }
    }
}
