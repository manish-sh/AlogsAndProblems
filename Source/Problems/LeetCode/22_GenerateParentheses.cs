using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            return GenerateAllParenthesis(n).ToList();
        }

        private HashSet<string> GenerateAllParenthesis(int n)
        {
            var list = new HashSet<string>();
            if (n == 0)
            {
                list.Add("");
                return list;
            }

            if (n == 1)
            {
                list.Add("()");
                return list;
            }

            foreach (var str in GenerateAllParenthesis(n - 1))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    var newStr = str.Insert(i, "()");
                    if (!list.Contains(newStr))
                        list.Add(newStr);
                }
            }

            //(())(())
            return list;
        }
    }
}
