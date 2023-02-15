using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class ListCycle
    {
        public ListNode detectCycle(ListNode a)
        {
            ListNode slow = a;
            ListNode fast = a;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    ListNode A = a;
                    ListNode B = slow;
                    while (B != A)
                    {
                        B = B.next;
                        A = A.next;
                    }
                    return A;
                }
            }
            return null;
        }
    }
}
