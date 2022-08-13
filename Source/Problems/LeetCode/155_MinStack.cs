using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class StackNode
    {
        public int Value { get; set; }
        public StackNode Next { get; set; }
        public int MinValue { get; set; }
    }

    internal class MinStack
    {
        private StackNode _head = null;
        public MinStack()
        {

        }

        public void Push(int val)
        {
            if (_head == null)
            {
                _head = new StackNode
                {
                    Value = val,
                    MinValue = val
                };
            }
            else
            {
                var tempNode = new StackNode();
                tempNode.Value = val;
                tempNode.MinValue = Math.Min(_head.MinValue, val);
                tempNode.Next = _head;
                _head = tempNode;
            }
        }

        public void Pop()
        {
            if (_head != null)
            {
                var temp = _head;
                _head = _head.Next;                
            }
        }

        public int Top()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return _head.Value;
        }

        public int GetMin()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return _head.MinValue;
        }
    }
}
