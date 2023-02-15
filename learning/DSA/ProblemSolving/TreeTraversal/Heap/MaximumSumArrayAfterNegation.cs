using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    public class MaximumSumArrayAfterNegation
    {
        public int Solve(List<int> A, int B) {
            Heap minHeap = new Heap(A.Count);
            minHeap.CreateMinHeap(A);
            var counter = B;
            while (counter > 0)
            { 
                var minValue = minHeap.GetMinimumValueFromMinHeap();
                minHeap.InsertToMinHeap(-minValue);
                counter--;
            }

            var sum = 0;
            foreach (var data in minHeap.heapData)
            {
                sum += data;
            }
            return sum;
        }
    }
}
