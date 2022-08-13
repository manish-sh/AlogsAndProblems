using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class ContainsDuplicate
    {
        public static bool IfContainsDuplicate(int[] nums)
        {
            if (nums.Length < 2) return false;
            var hashedInt = new HashSet<int>();
            foreach (int num in nums)
            {
                if (hashedInt.Contains(num))
                    return true;
                hashedInt.Add(num);
            }

            return false;
        }
    }
}
