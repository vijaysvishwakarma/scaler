using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedListCrud.insert_node(1, 23);
            LinkedListCrud.insert_node(2, 24);
            LinkedListCrud.insert_node(3, 25);
            LinkedListCrud.insert_node(4, 26);
            LinkedListCrud.insert_node(6, 27);
            LinkedListCrud.print_ll();
            Console.WriteLine();
            LinkedListCrud.delete_node(2);
            LinkedListCrud.delete_node(3);
            LinkedListCrud.delete_node(4);
            LinkedListCrud.print_ll();
            Console.WriteLine("deleted {2, 3}");
            LinkedListCrud.delete_node(4);
            LinkedListCrud.print_ll();
            Console.WriteLine();
            LinkedListCrud.delete_node(4);
            LinkedListCrud.print_ll();
            Console.WriteLine();
            Console.ReadLine();
            /*
            ListNode head = new ListNode(10);
            head.next = new ListNode(12);
            head.next.next = new ListNode(13);
            head.next.next.next = new ListNode(14);

            //ReverseLinkedList  reverseLinkedList = new ReverseLinkedList();
            //var result = reverseLinkedList.Solve(head);

            ReverseFirstK reverseFirstK = new ReverseFirstK();
            var result = reverseFirstK.Solve(head, 2);

            while (result != null)
            {
                Console.WriteLine("Node value" + result.val);
                result = result.next;
            }*/
        }
    }
}
