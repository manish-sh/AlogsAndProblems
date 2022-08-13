using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            var hashedData = new HashSet<int>();
            foreach (int num in nums)
            {
                hashedData.Add(num);
            }

            var longestStreak = 0;
            foreach (int num in nums)
            {
                if (!hashedData.Contains(num - 1))
                {
                    var currentNum = num;
                    int currentStreak = 1;
                    while (hashedData.Contains(currentNum))
                    {
                        currentStreak++;
                        currentNum++;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }
    }
}
