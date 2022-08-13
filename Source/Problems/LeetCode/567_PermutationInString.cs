using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return false;
            }

            int[] s1CharCount = new int[26];
            int[] s2CharCount = new int[26];

            for (int i = 0; i < s1.Length; i++)
            {
                s1CharCount[s1[i] - 'a']++;
                s2CharCount[s2[i] - 'a']++;
            }

            int count = 0;
            for (int i = 0; i < 26; i++)
            {
                if (s1CharCount[i] == s2CharCount[i])
                    count++;
            }

            for (int counter = 0; counter < s2.Length - s1.Length; counter++)
            {
                if (count == 26)
                    break;

                int right = s2[counter + s1.Length] - 'a', left = s2[counter] - 'a';
                s2CharCount[right]++;

                if (s2CharCount[right] == s1CharCount[right])
                {
                    count++;
                }
                else if (s2CharCount[right] == s1CharCount[right] + 1)
                {
                    count--;
                }

                s2CharCount[left]--;
                if (s2CharCount[left] == s1CharCount[left])
                {
                    count++;
                }
                else if (s2CharCount[left] == s1CharCount[left] - 1)
                {
                    count--;
                }
            }

            return count == 26;
        }
    }
}
