using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{

    internal class LargestNumberProduct
    {
        public List<int> solve(List<int> A)
        {
            List<int> result = new List<int>(3);
            var heap = new List<int>();
            if (A.Count == 2)
            {
                result.Add(-1);
                result.Add(-1);
                return result;
            }
            var mul = 1;
            for (var i = 0; i < 3; i++)
            {
                Insert(heap, A[i]);
                if (i < 2)
                {
                    result.Add(-1);
                }
                mul *= A[i];
            }
            result.Add(mul);
            for (var i = 3; i < A.Count; i++)
            {
                if (A[i] > heap[0])
                {
                    mul = mul / heap[0];
                    mul = mul * A[i];
                    heap[0] = A[i];
                    heapify(heap, 3, 0);
                }
                result.Add(mul);
            }

            return result;
        }
        void Insert(List<int> heap, int element)
        { 
            heap.Add(element);
            int index = heap.Count - 1;
            int parentIndex = (index - 1) / 2;
            while (index != 0 && heap[parentIndex] > heap[index])
            {
                // swap element
                var temp = heap[parentIndex];
                heap[parentIndex] = heap[index];
                heap[index] = temp;

                index = parentIndex;
                parentIndex = (index - 1) / 2;
            }
        }

        void heapify(List<int> heap, int n, int index) {
            var i = index;
            var l= 2*i + 1;
            var r = 2*i + 2;
            var position = index;
            var min = i;
            if (l < heap.Count && heap[min] > heap[l])
                min = l;
            if (r < heap.Count && heap[min] > heap[r])
                min = r;
            if (min != i)
            {
                int temp = heap[i];
                heap[i] = heap[min];
                heap[min] = temp;
                heapify(heap, n, min);
            }
        }
    }
}
