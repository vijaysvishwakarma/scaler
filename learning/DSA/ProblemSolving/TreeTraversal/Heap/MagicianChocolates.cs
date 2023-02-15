using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    public class MagicianChocolates
    {
        public int nchoc(int A, List<int> B)
        {
            var maxHeap = new Heap(B.Count);
            long total = 0;
            maxHeap.CreateMaxHeap(B);
            long m = 1000000007;

            for (int i = 0; i < A; i++)
            {
                int maxChoc = maxHeap.GetMaximumValueFromMaxHeap();
                maxHeap.InsertToMaxHeap(maxChoc / 2);
                total = (maxChoc % m + total % m) % m;
            }
            return (int)total;
        }
    }
}
