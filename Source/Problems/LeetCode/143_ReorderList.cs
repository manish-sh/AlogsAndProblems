using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class ReorderList
    {
        public void ReorderTheList(ListNode head)
        {
            int listLength = 0;
            var listNode = head;
            while (listNode != null)
            {
                listLength++;
                listNode = listNode.next;
            }

            var middleNode = head;
            for (int counter = 0; counter < listLength / 2; counter++)
            {
                middleNode = middleNode.next;
            }

            var reverseHeadNode = ReverseList(middleNode.next);
            middleNode.next = null;

            listNode = head;
            while (listNode != null && reverseHeadNode != null)
            {
                var nextNode = listNode.next;
                listNode.next = reverseHeadNode;
                listNode = reverseHeadNode;
                reverseHeadNode = nextNode;
            }
        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode listNode = null;
            ListNode currentNode = head;
            while (currentNode != null)
            {
                var nextNode = currentNode.next;
                currentNode.next = listNode;
                listNode = currentNode;
                currentNode = nextNode;
            }

            return listNode;
        }
    }
}
