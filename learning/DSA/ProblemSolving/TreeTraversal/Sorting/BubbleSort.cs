using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class BubbleSort
    {
        public void Solve(List<int> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A.Count - 1 - i; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        Swap(A, j, j + 1);
                    }
                }
            }
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
        }
        private void Swap(List<int> A, int i, int j)
        {
            var temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
    }
}
