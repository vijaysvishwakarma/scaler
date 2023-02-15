using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class Equilibrium
    {
        public int solve(List<int> A)
        {
            List<int> pfSum = new List<int>();
            
            pfSum.Add(A[0]);
            for (var index = 1; index < A.Count; index++)
            {
                pfSum.Add(0);
                pfSum[index] = pfSum[index - 1] + A[index];
            }

            int leftSum = 0, rightSum = 0, count = 0, minIndex = int.MaxValue;
            for (int i = 0; i < A.Count; i++)
            {
                if (i == 0)
                    leftSum = 0;
                else
                {
                    leftSum = pfSum[i - 1];
                }
                rightSum = pfSum[A.Count - 1] - pfSum[i];
                if (leftSum == rightSum)
                {
                    if (minIndex > i)
                        minIndex = i;

                    count++;
                }
            }
            return count == 0?  -1 : minIndex;
        }
    }
}
