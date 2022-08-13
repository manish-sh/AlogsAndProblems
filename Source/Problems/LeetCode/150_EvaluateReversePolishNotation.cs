using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class EvaluateReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();
            foreach (var token in tokens)
            {
                if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    if (stack.Count < 2)
                    {
                        throw new InvalidDataException("Expression is not valid");
                    }

                    var a = stack.Pop();
                    var b = stack.Pop();
                    switch (token)
                    {
                        case "+":stack.Push(b + a);
                            break;
                        case "-":
                            stack.Push(b - a);
                            break;
                        case "*":
                            stack.Push(b * a);
                            break;
                        case "/":
                            stack.Push(b / a);
                            break;
                    }
                }
                else
                {
                    stack.Push(Convert.ToInt32(token));
                }
            }

            if (stack.Count != 1)
            {
                throw new InvalidDataException("Expression is not valid");
            }

            return stack.Pop();
        }
    }
}
