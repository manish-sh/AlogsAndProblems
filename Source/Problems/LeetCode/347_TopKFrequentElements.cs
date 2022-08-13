using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var result = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!result.ContainsKey(num))
                {
                    result[num] = 0;
                }

                result[num]++;
            }

            return result.OrderByDescending(a => a.Value).Take(k).Select(a => a.Key).ToArray();
        }
    }
}
