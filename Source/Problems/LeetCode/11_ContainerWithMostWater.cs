using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0, right = height.Length - 1;
            while (left < right)
            {
                if (height[left] < height[right])
                {
                    maxArea = Math.Max(maxArea, height[left] * (right - left));
                    left++;
                }
                else if (height[left] > height[right])
                {
                    maxArea = Math.Max(maxArea, height[right] * (right - left));
                    right--;
                }
                else
                {
                    maxArea = Math.Max(maxArea, height[left] * (right - left));
                    left++;
                    right--;
                }
            }

            return maxArea;
        }
    }
}
