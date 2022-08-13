using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            var node1 = head;
            var node2 = head;

            while (node2 != null && node2.next != null)
            {
                node1 = node1.next;
                node2 = node2.next.next;

                if (node2 == node1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
