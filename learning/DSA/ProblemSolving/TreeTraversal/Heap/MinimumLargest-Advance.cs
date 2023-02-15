using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heap
{
    internal class MinimumLargest_Advance
    {
        public int solve(List<int> A, int B)
        {
            var nextState = new int[A.Count];
            var minHeap = new HeapAdvance(A.Count);
            for (int i = 0; i < A.Count; i++)
            {
                minHeap.InsertToMinHeap(new KeyValuePair<int, int>( i, A[i] + A[i]));
                nextState[i] = A[i];
            }

            
            var counter = 0;
            while (counter < B)
            {

                var minValueFromHeap = minHeap.GetMinimumValueFromMinHeap();
                nextState[minValueFromHeap.Key] = minValueFromHeap.Value;
                minHeap.InsertToMinHeap(new KeyValuePair<int, int>(minValueFromHeap.Key, nextState[minValueFromHeap.Key] + A[minValueFromHeap.Key]));
                counter++;
            }
            return nextState.Max();
        }
    }
}
