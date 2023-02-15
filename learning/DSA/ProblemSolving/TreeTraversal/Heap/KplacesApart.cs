using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    public class KplacesApart
    {
        public List<int> solve(List<int> A, int B)
        { 
            List<int> ans = new List<int>();
            Heap minHeap = new Heap(A.Count);
            for (int i = 0; i <= B; i++)
            { 
                minHeap.InsertToMinHeap(A[i]);
            }
            ans.Add(minHeap.GetMinimumValueFromMinHeap());

            for (int i = B+1; i < A.Count; i++)
            {
                minHeap.InsertToMinHeap(A[i]);
                ans.Add(minHeap.GetMinimumValueFromMinHeap());
            }

            while(minHeap.heapData.Count > 0)
            {
                ans.Add(minHeap.GetMinimumValueFromMinHeap());
            }

            return ans;
        }
    }
}
