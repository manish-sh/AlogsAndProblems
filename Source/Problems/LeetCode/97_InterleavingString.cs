using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class InterleavingString
    {
        public static bool IsInterleave(string s1, string s2, string s3)
        {
            //if (Math.Abs(s1.Length - s2.Length) > 1 || s1.Length + s2.Length != s3.Length)
            //{
            //    return false;
            //}

            //var isInterLeave = true;
            //var s1Counter = 0;
            //var s2Counter = 0;
            //for (int counter = 0; counter < s3.Length;)
            //{
            //    var matchFound = false;
            //    while (s1.Length > s1Counter && s3[counter] == s1[s1Counter])
            //    {
            //        s1Counter++;
            //        counter++;
            //        matchFound = true;
            //    }

            //    while (s2.Length > s2Counter && s3[counter] == s2[s2Counter])
            //    {
            //        s2Counter++;
            //        counter++;
            //        matchFound = true;
            //    }

            //    if (!matchFound)
            //    {
            //        isInterLeave = false;
            //        break;
            //    }
            //}

            //return isInterLeave;

            if (s3.Length != s1.Length + s2.Length)
            {
                return false;
            }

            bool[] dp = new bool[s2.Length + 1];
            for (int s1Counter = 0; s1Counter <= s1.Length; s1Counter++)
            {
                for (int s2Counter = 0; s2Counter <= s2.Length; s2Counter++)
                {
                    if (s1Counter == 0 && s2Counter == 0)
                    {
                        dp[s2Counter] = true;
                    }
                    else if (s1Counter == 0)
                    {
                        dp[s2Counter] = dp[s2Counter - 1] && s2[s2Counter - 1] == s3[s1Counter + s2Counter - 1];
                    }
                    else if (s2Counter == 0)
                    {
                        dp[s2Counter] = dp[s2Counter] && s1[s1Counter - 1] == s3[s1Counter + s2Counter - 1];
                    }
                    else
                    {
                        dp[s2Counter] = (dp[s2Counter] && s1[s1Counter - 1] == s3[s1Counter + s2Counter - 1]) || (dp[s2Counter - 1] && s2[s2Counter - 1] == s3[s1Counter + s2Counter - 1]);
                    }
                }
            }

            return dp[s2.Length];
        }
    }
}
