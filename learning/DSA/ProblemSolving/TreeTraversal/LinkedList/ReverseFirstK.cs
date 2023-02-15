using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class ReverseFirstK
    {
        public ListNode Solve(ListNode head, int k)
        {   
            if (head == null || k == 0)
                return head;
            ListNode h2 = null, temp = null;
            var h1 = head;
            var count = k;
            while (h1 != null && k > 0)
            { 
                temp = h1;
                h1 = h1.next;
                temp.next = h2;
                h2 = temp;
                k--;
            }
            //head.next = h1;
            head.next = Solve(h1, count);
            return h2;
        }
    }
}
