using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            var area = 0;

            var maxHeightIndex = 0;
            for (int counter = 0; counter < height.Length; counter++)
            {
                if (height[maxHeightIndex] <= height[counter])
                {
                    maxHeightIndex = counter;
                }
            }

            var maxHeight = height[0];
            for (int counter = 0; counter < maxHeightIndex; counter++)
            {
                if (maxHeight <= height[counter])
                {
                    maxHeight = height[counter];
                }
                else
                {
                    area += maxHeight - height[counter];
                }
            }

            maxHeight = height[height.Length - 1];
            for (int counter = height.Length - 1; counter > maxHeightIndex; counter--)
            {
                if (maxHeight < height[counter])
                {
                    maxHeight = height[counter];
                }
                else
                {
                    area += maxHeight - height[counter];
                }
            }
            return area;
        }
    }
}
