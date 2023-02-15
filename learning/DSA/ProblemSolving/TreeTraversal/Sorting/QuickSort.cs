using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class QuickSorting
    {
        public void Solve(List<int> A)
        {
            int s = 0, e = A.Count-1;
            QuickSort(A, s, e);
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
        }
        private void QuickSort(List<int> A, int s, int e)
        {
            if (s >= e) return;

            int p = partition(A, s, e);
            QuickSort(A, s, p-1);
            QuickSort(A, p + 1, e);

        }
        private int partition(List<int> A, int s, int e)
        { 
            int l = s + 1, r = e;

            while (l <= r)
            {
                if (A[l] <= A[s])
                {
                    l++;
                }
                else if (A[r] > A[s])
                {
                    r--;
                }
                else {
                    swap(A, l, r);
                    l++;r--;
                }
            
            }
            swap(A, s, r);
            return r;
        }
        private void swap(List<int> A, int l, int r)
        {
            var temp = A[l];
            A[l] = A[r];
            A[r] = temp;
        }
    }
}
