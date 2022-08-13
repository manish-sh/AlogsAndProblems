using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    internal class CopyListWithRandomPointer
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            var newHead = new Node(head.val);
            var oldNode = head.next;
            var newNode = newHead;
            var counter = 0;
            var OldDict = new Dictionary<Node, int>();
            var newDict = new Dictionary<int, Node>();
            OldDict.Add(head, counter);
            while (oldNode != null)
            {
                newNode.next = new Node(oldNode.val);
                newDict.Add(counter, newNode);
                counter++;
                OldDict.Add(oldNode, counter);
                newNode = newNode.next;
                oldNode = oldNode.next;
            }

            newDict.Add(counter, newNode);
            newNode = newHead;
            oldNode = head;
            while (newNode != null)
            {
                if (oldNode.random != null)
                {
                    newNode.random = newDict[OldDict[oldNode.random]];
                }

                newNode = newNode.next;
                oldNode = oldNode.next;
            }


            return newHead;
        }
    }
}
