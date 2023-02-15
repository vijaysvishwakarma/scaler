using System;
using System.Collections.Generic;
using System.Text;

namespace GreedyAlgorithms
{
    internal class GreedyAlgorithm
    {
        public int maxCost(List<KeyValuePair<int, int>> data)
        {
            int n = data.Count;
            var minHeap = new Heap(data.Count);
            data.Sort((x,y) => x.Key.CompareTo(y.Key));
            for (int i = 0; i < n; i++)
            {
                KeyValuePair<int, int> x = data[i];
                int day = x.Key;
                int payment = x.Value;
                if (day > minHeap.heapData.Count)
                {
                    minHeap.InsertToMinHeap(payment);
                }
                else if (payment < minHeap.heapData[0])
                {
                    minHeap.GetMaximumValueFromMaxHeap();
                    minHeap.InsertToMinHeap(payment);
                }

            }
            int ans = 0;
            while (minHeap.heapData.Count > 0)
            {
                ans = ans + minHeap.GetMinimumValueFromMinHeap();

            }
            return ans;
        }
    }
}
