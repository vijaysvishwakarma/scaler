using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    public class HeapAdvance
    {
        public List<KeyValuePair<int,int>> heapData;
        private int size;
        public HeapAdvance(int size) {
            heapData = new List<KeyValuePair<int, int>>(size);
            this.size = 0;
        }
        public void CreateMinHeap(List<KeyValuePair<int,int>> A)
        {
            foreach (var element in A)
            {
                InsertToMinHeap(element);
            }
        }
        public void CreateMaxHeap(List<KeyValuePair<int, int>> A)
        {
            foreach (var element in A)
            {
                InsertToMaxHeap(element);
            }
        }
        public void InsertToMinHeap(KeyValuePair<int,int> element) {
            heapData.Add(element);
            int currentIndex = heapData.Count - 1;
            while (currentIndex > 0)
            {
                var parentIndex = (currentIndex - 1) / 2; ;
                if (heapData[currentIndex].Value < heapData[parentIndex].Value)
                {
                    swap(currentIndex, parentIndex);
                    currentIndex = parentIndex;
                }
                else {
                    return;
                }
            
            }
        
        }

        public void InsertToMaxHeap(KeyValuePair<int, int> element)
        {
            heapData.Add(element);
            int currentIndex = heapData.Count - 1;
            while (currentIndex > 0)
            {
                var parentIndex = (currentIndex - 1)/ 2;
                if (heapData[currentIndex].Value > heapData[parentIndex].Value)
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

        public KeyValuePair<int, int> GetMinimumValueFromMinHeap()
        { 
            //int minHeap = int.MaxValue;
            KeyValuePair<int,int> minHeap = new KeyValuePair<int, int>(int.MaxValue, 0);
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

                    int minElement = Math.Min(heapData[parentIndex].Value, heapData[leftChildIIndex].Value);
                    if (rightChildIIndex < size)
                    {
                        minElement = Math.Min(minElement, heapData[rightChildIIndex].Value);
                    }
                    if (minElement == heapData[parentIndex].Value)
                    {
                        break;
                    }
                    if (minElement == heapData[leftChildIIndex].Value)
                    {
                        swap(parentIndex, leftChildIIndex);
                        parentIndex = leftChildIIndex;
                    }
                    
                    if (rightChildIIndex < size && minElement == heapData[rightChildIIndex].Value) {
                        swap(parentIndex, rightChildIIndex);
                        parentIndex = rightChildIIndex;
                    
                    }
                }
            }
            return minHeap;
        }

        public KeyValuePair<int, int> GetMaximumValueFromMaxHeap()
        {
            KeyValuePair<int, int> maxHeap = new KeyValuePair<int, int>(int.MinValue, 0);
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

                    int maxElement = Math.Max(heapData[leftChildIIndex].Value, heapData[parentIndex].Value);
                    if (rightChildIIndex < size)
                    {
                        maxElement = Math.Max(maxElement, heapData[rightChildIIndex].Value);
                    }
                    if (maxElement == heapData[parentIndex].Value)
                    {
                        break;
                    }
                    if (maxElement == heapData[leftChildIIndex].Value)
                    {
                        swap(parentIndex, leftChildIIndex);
                        parentIndex = leftChildIIndex;
                    }else if (rightChildIIndex < size && maxElement == heapData[rightChildIIndex].Value)
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
