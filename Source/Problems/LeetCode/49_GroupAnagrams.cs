using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class GroupAnagrams
    {
        public IList<IList<string>> GetGroupedAnagrams(string[] strs)
        {
            var groupedAnagrams = new List<IList<string>>();
            var dictGroupedAnagrams = new Dictionary<string, IList<string>>();
            groupedAnagrams.Add(new List<string> { strs[0] });
            for (int counter = 1; counter < strs.Length; counter++)
            {
                bool anagramFound = false;
                foreach (var anagrams in groupedAnagrams)
                {
                    if (anagrams.Any() && IsAnagram(strs[counter], anagrams.First()))
                    {
                        anagrams.Add(strs[counter]);
                        anagramFound = true;
                        break;
                    }
                }

                if (!anagramFound)
                {
                    groupedAnagrams.Add(new List<string> { strs[counter] });
                }
            }

            return groupedAnagrams;
        }

        public IList<IList<string>> GetGroupedAnagrams1(string[] strs)
        {
            var dictGroupedAnagrams = new Dictionary<string, IList<string>>();
            dictGroupedAnagrams[new String(strs[0].OrderBy(s => s).ToArray())] = new List<string> { strs[0] };
            for (int counter = 1; counter < strs.Length; counter++)
            {
                var sortedString = new String(strs[counter].OrderBy(s => s).ToArray());
                if (dictGroupedAnagrams.ContainsKey(sortedString))
                {
                    dictGroupedAnagrams[sortedString].Add(strs[counter]);
                }
                else
                {
                    dictGroupedAnagrams[sortedString] = new List<string> { strs[counter] };
                }
            }

            return dictGroupedAnagrams.Values.ToList();
        }

        private bool IsAnagram(string s, string t)
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
