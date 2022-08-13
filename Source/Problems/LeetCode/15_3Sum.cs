using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class ThreeSum
    {
        public IList<IList<int>> GetThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            var sortedArray = nums.OrderBy(num => num).ToArray();

            for (int counter = 0; counter < sortedArray.Length - 2; counter++)
            {
                if (counter > 0 && sortedArray[counter - 1] == sortedArray[counter])
                    continue;


                var left = counter + 1;
                var right = sortedArray.Length - 1;
                while (left < right)
                {
                    var sum = sortedArray[left] + sortedArray[right] + sortedArray[counter];
                    if (sum == 0)
                    {
                        var intermediateResult = new List<int>();
                        intermediateResult.Add(sortedArray[counter]);
                        intermediateResult.Add(sortedArray[left]);
                        intermediateResult.Add(sortedArray[right]);
                        result.Add(intermediateResult);
                        left++;

                        while (sortedArray[left] == sortedArray[left - 1] && left < right)
                        {
                            left++;
                        }
                    }

                    if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }
    }
}
