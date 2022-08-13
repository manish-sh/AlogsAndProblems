using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class FindTheDuplicateNumber
    {
        public int FindDuplicate(int[] nums)
        {
            if (nums.Length < 2)
            {
                return -1;
            }

            var slowIndex = nums[0];
            var fastIndex = nums[0];

            do
            {
                slowIndex = nums[slowIndex];
                fastIndex = nums[nums[fastIndex]];
            }
            while (slowIndex != fastIndex);

            slowIndex = nums[0];
            while (slowIndex != fastIndex)
            {
                fastIndex = nums[fastIndex];
                slowIndex = nums[slowIndex];
            }

            return slowIndex;
        }
    }
}
