using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    internal class RunningMedian
    {
        public List<int> Solve(List<int> A)
        {
            Heap leftMaxHeap = new Heap(0);
            Heap rightMinHeap = new Heap(0);
            List<int> result = new List<int>();
            leftMaxHeap.InsertToMaxHeap(A[0]);
            result.Add(A[0]);

            for (int i = 1; i < A.Count; i++)
            {
                var maxHeap = leftMaxHeap.heapData[0];
                if (A[i] > maxHeap)
                {
                    rightMinHeap.InsertToMinHeap(A[i]);

                }
                else {
                    leftMaxHeap.InsertToMaxHeap(A[i]);
                }

                if (leftMaxHeap.heapData.Count < rightMinHeap.heapData.Count)
                {
                    var leftMin = rightMinHeap.GetMinimumValueFromMinHeap();
                    leftMaxHeap.InsertToMaxHeap(leftMin);
                }
                else if (leftMaxHeap.heapData.Count - rightMinHeap.heapData.Count > 1){
                    rightMinHeap.InsertToMinHeap(leftMaxHeap.GetMaximumValueFromMaxHeap());
                }

                int size = i + 1;
                if (size == 1)
                {
                    result.Add(A[0]);
                }
                else {
                    int median = leftMaxHeap.GetMaximumValueFromMaxHeap();
                    result.Add(median);
                    leftMaxHeap.InsertToMaxHeap(median);
                }
            }
            return result;
        
        }
    }
}
