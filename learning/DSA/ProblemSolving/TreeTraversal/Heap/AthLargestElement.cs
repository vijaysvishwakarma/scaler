using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    internal class AthLargestElement
    {
        public List<int> Solve(int A, List<int> B)
        { 
            List<int> result = new List<int>();
            Heap minHeap = new Heap(0);
            for (int i = 0; i < A; i++)
            { 
                result.Add(-1);
                minHeap.InsertToMinHeap(B[i]);
            }

            var minimum = minHeap.GetMinimumValueFromMinHeap();
            result[A- 1] = minimum;
            for (int j = A; j < B.Count; j++)
            {
                if (B[j] > minimum)
                {
                       minHeap.InsertToMinHeap(B[j]);
                }
                else {
                    minHeap.InsertToMinHeap(minimum);
                }
                minimum = minHeap.GetMinimumValueFromMinHeap();
                result.Add(minimum);
            }
            return result;
        }
    }
}
