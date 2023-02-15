using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    public class Heap
    {
        

        public List<int> heapData;
        private int size;
        public Heap(int size) {
            heapData = new List<int>(size);
            this.size = 0;
        }
        public void CreateMinHeap(List<int> A)
        {
            foreach (int element in A)
            {
                InsertToMinHeap(element);
            }
        }
        public void CreateMaxHeap(List<int> A)
        {
            foreach (int element in A)
            {
                InsertToMaxHeap(element);
            }
        }
        public void InsertToMinHeap(int element) {
            heapData.Add(element);
            int currentIndex = heapData.Count - 1;
            while (currentIndex > 0)
            {
                var parentIndex = (currentIndex - 1) / 2; ;
                if (heapData[currentIndex] < heapData[parentIndex])
                {
                    swap(currentIndex, parentIndex);
                    currentIndex = parentIndex;
                }
                else {
                    return;
                }
            
            }
        
        }

        public void InsertToMaxHeap(int element)
        {
            heapData.Add(element);
            int currentIndex = heapData.Count - 1;
            while (currentIndex > 0)
            {
                var parentIndex = (currentIndex - 1)/ 2;
                if (heapData[currentIndex] > heapData[parentIndex])
                {
                    swap(currentIndex, parentIndex);
                    currentIndex = parentIndex;
                }
                else
                {
                    return;
                }

            }

        }

        public int GetMinimumValueFromMinHeap()
        { 
            int minHeap = int.MaxValue;
            var size = heapData.Count;
            if (heapData.Count > 0)
            { 
                minHeap = heapData[0];
                // swap last element with minheap
                swap(0, size - 1);
                heapData.RemoveAt(size - 1);
                size--;

                int parentIndex = 0;

                while ((2 * parentIndex) + 1 < size)
                { 
                    var leftChildIIndex = (2 * parentIndex) + 1;
                    var rightChildIIndex = (2 * parentIndex) + 2;

                    int minElement = Math.Min(heapData[parentIndex], heapData[leftChildIIndex]);
                    if (rightChildIIndex < size)
                    {
                        minElement = Math.Min(minElement, heapData[rightChildIIndex]);
                    }
                    if (minElement == heapData[parentIndex])
                    {
                        break;
                    }
                    if (minElement == heapData[leftChildIIndex])
                    {
                        swap(parentIndex, leftChildIIndex);
                        parentIndex = leftChildIIndex;
                    }
                    
                    if (rightChildIIndex < size && minElement == heapData[rightChildIIndex]) {
                        swap(parentIndex, rightChildIIndex);
                        parentIndex = rightChildIIndex;
                    
                    }
                }
            }
            return minHeap;
        }

        public int GetMaximumValueFromMaxHeap()
        {
            int maxHeap = int.MinValue;
            if (heapData.Count > 0)
            {
                var size = heapData.Count;
                maxHeap = heapData[0];
                // swap last element with maxheap
                swap(0, size - 1);
                heapData.RemoveAt(size - 1);
                size--;

                int parentIndex = 0;

                while ((2 * parentIndex) + 1 < size)
                {
                    var leftChildIIndex = 2 * parentIndex + 1;
                    var rightChildIIndex = 2 * parentIndex + 2;

                    int maxElement = Math.Max(heapData[leftChildIIndex], heapData[parentIndex]);
                    if (rightChildIIndex < size)
                    {
                        maxElement = Math.Max(maxElement, heapData[rightChildIIndex]);
                    }
                    if (maxElement == heapData[parentIndex])
                    {
                        break;
                    }
                    if (maxElement == heapData[leftChildIIndex])
                    {
                        swap(parentIndex, leftChildIIndex);
                        parentIndex = leftChildIIndex;
                    }else if (rightChildIIndex < size && maxElement == heapData[rightChildIIndex])
                    {
                        swap(parentIndex, rightChildIIndex);
                        parentIndex = rightChildIIndex;

                    }
                }
            }
            return maxHeap;
        }

        private void swap(int currentIndex, int parentIndex)
        {
            var temp = heapData[currentIndex];
            heapData[currentIndex] = heapData[parentIndex];
            heapData[parentIndex] = temp;
        }
    }
}
