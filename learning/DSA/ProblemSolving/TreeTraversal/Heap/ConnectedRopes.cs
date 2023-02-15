using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    public class ConnectedRopes
    {
        public int Solve(List<int> A)
        {
            int result = 0;
            Heap minHeap = new Heap(0);
            minHeap.CreateMinHeap(A);
            int size = A.Count;
            for (int i = 0; i < size - 1; i++)
            {
                int firstMin = minHeap.GetMinimumValueFromMinHeap();
                int secondMin = minHeap.GetMinimumValueFromMinHeap();
                minHeap.InsertToMinHeap(firstMin + secondMin);
                result = result + firstMin + secondMin;

            }
            return result;
        }
    }
}
