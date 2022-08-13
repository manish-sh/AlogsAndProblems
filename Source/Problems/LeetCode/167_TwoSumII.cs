using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;

            for (int counter = numbers.Length; counter > left; counter--)
            {
                if (target >= numbers[left])
                {
                    while (numbers[right] > target || numbers[right] + numbers[left] > target)
                    {
                        counter--;
                        right--;
                    }
                }

                while (numbers[left] + numbers[right] < target)
                {
                    left++;
                }

                if (numbers[left] + numbers[right] == target)
                    break;

                right--;
            }
            if (left > right)
            {
                return new int[] { right + 1, left + 1 };
            }

            return new int[] { left + 1, right + 1 };
        }

        public int[] TwoSum1(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    break;
                }
                else if (sum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return new int[] { left + 1, right + 1 };
        }
    }
}
