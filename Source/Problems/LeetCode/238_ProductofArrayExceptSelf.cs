using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class ProductofArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            result[0] = 1;
            for (int counter = 1; counter < nums.Length; counter++)
            {
                result[counter] = nums[counter - 1] * result[counter - 1];
            }

            var multiplier = 1;
            for (int counter = nums.Length - 1; counter > 0; counter--)
            {
                multiplier *= nums[counter];
                result[counter - 1] = result[counter - 1] * multiplier;
            }

            return result;
        }
    }
}
