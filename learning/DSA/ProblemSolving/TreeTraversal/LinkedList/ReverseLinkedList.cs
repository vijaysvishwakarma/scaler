using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class ReverseLinkedList
    {
        public ListNode Solve(ListNode A)
        {
            ListNode head = A;
            ListNode temp = head;
            ListNode prev = head;
            ListNode prevNext = temp;
            ListNode first = head;
            
            // n1->n2->n3->null
            //   p    np     temp
            // n1->n2->null
            // p np

            if (head.next == null)
                return head;
            temp = temp.next;
            while (temp != null)
            {
                prevNext = temp;
                temp = temp.next;
                prevNext.next = prev;
                prev = prevNext;
                //prevNext = temp;
               // prev = prev.next;
            }
            first.next = null;
            head = prevNext;
            return head;
        }
    }
}
