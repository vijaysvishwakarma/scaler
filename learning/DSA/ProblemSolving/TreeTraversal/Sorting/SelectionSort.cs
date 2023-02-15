using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class SelectionSort
    {
        public void Solve(List<int> A)
        {
            var min = 0; var index =0;
            for (int i = 0; i < A.Count; i++)
            {
                min = A[i]; index = i;
                for (int j = i; j < A.Count; j++)
                {
                    if (min > A[j])
                    {
                        min = A[j];
                        index = j;  
                    }
                }
                Swap(A, i, index);
            }
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
        }

        public void Swap(List<int> A, int i, int j)
        {
            var temp = A[i];
            A[i] = A[j];
            A[j] = temp;    
        }
    }
}
