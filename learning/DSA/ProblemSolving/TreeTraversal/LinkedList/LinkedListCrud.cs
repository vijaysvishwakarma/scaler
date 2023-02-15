using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class LinkedListCrud
    {
        public class Node
        {
            public Node(int value)
            {
                Value = value;
            }
            public int Value { get; set; }
            public Node Next { get; set; }
        }
        static Node head;
        static int length;
        public static void insert_node(int position, int value)
        {
            // @params position, integer
            // @params value, integer
            if (position > 0 && position <= length + 1)
            {
                int count = 1;
                Node temp = head;
                while (temp != null && temp.Next != null && position != count)
                {
                    temp = temp.Next;
                    count++;
                    length++;
                }
                var new_node = new Node(value);
                new_node.Next = null;
                if (head == null)
                {
                    head = new_node;
                }
                else
                {
                    temp.Next = new_node;
                }
                length++;
            }
        }

        public static void delete_node(int position)
        {
            // @params position, integer
            if (position > 0 && position <= length + 1)
            {
                Node temp = head;
                var counter = 1;
                if (head == null) return;
                if (head.Next == null)
                {
                    head = null;
                    return;
                };

                if (position == 1)
                {

                    // Change head
                    head = temp.Next;
                    length--;
                    return;
                }
                while (temp != null && counter < position - 1)
                {
                    //prev = temp;
                    temp = temp.Next;
                    counter++;
                }
                if (temp == null)
                {
                    return;
                }
                if (temp.Next == null)
                {
                    return;
                }
                Node next = temp.Next.Next;

                // Unlink the deleted node from list
                temp.Next = next;
                length--;
            }
        }

        public static void print_ll()
        {
            // Output each element followed by a space
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
        }

    }
}
