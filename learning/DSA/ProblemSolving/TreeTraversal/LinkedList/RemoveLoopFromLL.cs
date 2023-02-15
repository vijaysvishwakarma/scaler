using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class RemoveLoopFromLL
    {
		public ListNode solve(ListNode A)
		{
			ListNode slowPointer = A, fastPointer = A;
			while (fastPointer != null && fastPointer.next != null)
			{
				slowPointer = slowPointer.next;
				fastPointer = fastPointer.next.next;
				if (slowPointer == fastPointer)
				{
					slowPointer = A; // Pointing ‘slowPointer’ to Head Again.
					while (slowPointer.next != fastPointer.next)
					{
						slowPointer = slowPointer.next;
						fastPointer = fastPointer.next;
					}
					// Pointing the reference of last node in the cycle to null to break the cycle.
					fastPointer.next = null;
				}
			}
			return A;
		}
	}
}
