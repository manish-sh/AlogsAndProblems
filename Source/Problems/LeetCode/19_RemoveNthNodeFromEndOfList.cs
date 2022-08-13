using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var listNode = head;
            var toBeDeleted = head;
            var counter = 0;
            while (listNode != null)
            {
                if (counter > n)
                {
                    toBeDeleted = toBeDeleted.next;
                }

                listNode = listNode.next;
                counter++;
            }

            if (counter < n)
            {
                head = head.next;
            }
            else
            {
                toBeDeleted.next = toBeDeleted.next.next;
            }

            return head;
        }
    }
}
