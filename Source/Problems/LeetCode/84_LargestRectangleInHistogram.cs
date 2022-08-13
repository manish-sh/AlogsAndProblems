using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class LargestRectangleInHistogram
    {
        public int LargestRectangleArea(int[] heights)
        {
            int area = 0;

            var leftSmallerIndex = GetLeftSmallerIndex(heights);
            var rightSmallerIndex = GetRighttSmallerIndex(heights);

            for (int counter = 0; counter < heights.Length; counter++)
            {
                area = Math.Max(area, (rightSmallerIndex[counter] - leftSmallerIndex[counter] - 1) * heights[counter]);
            }

            return area;
        }

        private int[] GetLeftSmallerIndex(int[] heights)
        {
            var result = new int[heights.Length];
            var stack = new Stack<int>();
            for (int counter = 0; counter < heights.Length; counter++)
            {
                while (stack.Count != 0 && heights[stack.Peek()] >= heights[counter])
                {
                    stack.Pop();
                }

                if (stack.Count == 0)
                {
                    result[counter] = -1;
                }
                else
                {
                    result[counter] = stack.Peek();
                }

                stack.Push(counter);
            }

            return result;
        }

        private int[] GetRighttSmallerIndex(int[] heights)
        {
            var result = new int[heights.Length];
            var stack = new Stack<int>();
            for (int counter = heights.Length - 1; counter >= 0; counter--)
            {
                while (stack.Count != 0 && heights[stack.Peek()] >= heights[counter])
                {
                    stack.Pop();
                }

                if (stack.Count == 0)
                {
                    result[counter] = heights.Length;
                }
                else
                {
                    result[counter] = stack.Peek();
                }

                stack.Push(counter);
            }

            return result;
        }

        public int LargestRectangleArea2(int[] heights)
        {
            int maxArea = 0;
            var stack = new Stack<int>();
            for (int i = 0; i <= heights.Length; i++)
            {               
                int height = i < heights.Length ? heights[i] : 0;
                while (stack.Count != 0 && heights[stack.Peek()] > height)
                {
                    var currHeight = heights[stack.Pop()];
                    var prevIndex = stack.Count == 0 ? -1 : stack.Peek();
                    maxArea = Math.Max(maxArea, currHeight * (i - 1 - prevIndex));
                }
                stack.Push(i);
            }

            return maxArea;
        }
    }
}
