using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }

                if (c == ')' || c == '}' || c == ']')
                {
                    if (!stack.Any())
                    {
                        return false;
                    }

                    var temp = stack.Pop();
                    if (!((temp == '(' && c == ')') || (temp == '{' && c == '}') || (temp == '[' && c == ']')))
                    {
                        return false;
                    }
                }
            }

            return !stack.Any();
        }
    }
}
