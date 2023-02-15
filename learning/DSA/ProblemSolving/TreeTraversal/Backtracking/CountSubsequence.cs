using System;
using System.Collections.Generic;
using System.Text;

namespace Backtracking
{
    internal class CountSubsequence
    {
        public int Solve(List<int> A, int B)
        {
            var sum = 0;
            return GetCountSubsequence(A,A.Count, B, sum, 0, 0);
        }

        private int GetCountSubsequence(List<int> A, int n,int B, int sum, int index, int subsequenceCount)
        {
            var count = 0;
            if (index == n)
            {
                if (sum <= 1000 && subsequenceCount == B)
                {
                    return 1;
                }
                
                return 0;
            }
            sum += A[index];
            count = count + GetCountSubsequence(A, A.Count, B, sum, index+1, subsequenceCount+1);
            return count;
        }
    }
}
