using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class DailyTemperature
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var result = new int[temperatures.Length];

            var stack = new Stack<int>();
            stack.Push(0);
            for (int counter = 1; counter < temperatures.Length; counter++)
            {
                if (stack.Count > 0 && temperatures[stack.Peek()] >= temperatures[counter])
                {
                    stack.Push(counter);
                    continue;
                }

                while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[counter])
                {
                    var index = stack.Pop();
                    result[index] = counter - index;
                }

                stack.Push(counter);
            }

            return result;
        }
    }
}
