using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDArrays
{
    internal class Transpose
    {
        public List<List<int>> Solve(List<List<int>> A)
        {
            List<List<int>> B = new List<List<int>>();

            for (int i = 0; i < A[0].Count; i++)
            {
                var t = new List<int>(A[0].Count);
                for (int index = 0; index < A.Count; index++)
                {
                    t.Add(0);
                }
                B.Add(t);
                for (int j = 0; j < A.Count; j++)
                {
                    // Swap(A, i, j);
                    B[i][j] = A[j][i];
                }
            }
            return B;
            //for (int i = 0; i < A[0].Count; i++)
            //{
            //    for (int j = 0; j < A.Count; j++)
            //    {
            //        if (i < j)
            //        {
            //            int t = A[j][i];
            //            A[j][i] = A[i][j];
            //            A[i][j] = t;
            //        }
            //    }
            //}
            //return A;
        }

        private void Swap(List<List<int>> A, int i, int j)
        {
            var temp = A[i][j];
            A[i][j] = A[j][i];
            A[j][i] = temp;
        }
    }
}
