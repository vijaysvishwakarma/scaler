using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class RandomListNode
    {
        public int label;
        public RandomListNode next, random;
        public RandomListNode(int x) { this.label = x; }
    };

    internal class Deepcopy

    {
        public RandomListNode copyRandomList(RandomListNode head)
        {
            RandomListNode curr = head;
            RandomListNode temp;
            //insert next nodes of clone in between
            while (curr != null)
            {
                temp = curr.next;
                curr.next = new RandomListNode(curr.label);
                curr.next.next = temp;
                curr = temp;
            }
            curr = head;
            while (curr != null)
            {
                curr.next.random = curr.random != null ? curr.random.next : curr.random;
                curr = curr.next.next;
            }
            RandomListNode original = head;
            RandomListNode copy = head.next;
            temp = copy;
            while (original != null && copy != null)
            {
                original.next = original.next.next;
                copy.next = copy.next != null ? copy.next.next : copy.next;
                original = original.next;
                copy = copy.next;
            }
            return temp;
        }

}
