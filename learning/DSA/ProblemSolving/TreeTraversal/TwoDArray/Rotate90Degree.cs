using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDArrays
{
    internal class Rotate90Degree
    {
        public void Solve(List<List<int>> A)
        {
            for (int i = 0; i < A[0].Count; i++)
            {
                for (int j = 0; j < A.Count; j++)
                {
                    if (i < j)
                    {
                        int t = A[j][i];
                        A[j][i] = A[i][j];
                        A[i][j] = t;
                    }
                }
            }
            // reverse
            for (int i = 0; i < A.Count; i++)
            {
                int k = 1;

                for (int j = 0; j < A.Count; j++)
                {
                    if (k > A.Count / 2)
                        break;

                    int t = A[i][j];
                    A[i][j] = A[i][A.Count - k];
                    A[i][A.Count - k] = t;
                    k++;
                }
            }
        
        }
    }
}
