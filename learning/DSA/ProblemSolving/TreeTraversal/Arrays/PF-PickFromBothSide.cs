using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class PF_PickFromBothSide
    {
        public int solve(List<int> A, int B)
        {
            // 5, -2, 3, 1, 2
            // B = 3
            // PF = 5, 3, 6, 7, 9
            // we have to pick 3 elements either 1 from start or e from end or any combination
            // case 1: pick 5 and 1,2 = sum = 8
            // case 2: pick 5, -2 and 2  = sum = 5
            // case 3: pick 5, -2, 3 = sum = 6
            // case 4: pick 3,1,2 = sum = 6
            // first 3 element
            // last 3 element
            // first 0 element and last 2 element
            // first 2 element and last 1 element
            

            List<int> pfSum = new List<int>();

            pfSum.Add(A[0]);
            for (var index = 1; index < A.Count; index++)
            {
                pfSum.Add(0);
                pfSum[index] = pfSum[index - 1] + A[index];
            }
            var maxSum = 0;

            int l = B, r = 0;



            while (B >= 0)
            {
                var subsum = r == 0? 0 : pfSum[A.Count -1] - pfSum[A.Count  - (r + 1)];
                var lsum = l == 0 ? 0 : pfSum[A.Count - 1] - pfSum[A.Count - (l+ 1)];
                var sum = subsum + lsum;
                maxSum = Math.Max(maxSum, sum);

                l--;r++;
                B--;
            }


            //for (int i = 0; i < B; i++)
            //{
            //    // 0 to B
            //    // N-B to n
            //    //
            //    var lastIndex = (B - i);
            //    var subsum = pfSum[A.Count-1] - pfSum[A.Count-1 - lastIndex];
            //    var sum = pfSum[i] + subsum;
            //    maxSum = Math.Max(maxSum, sum);

            //}
            return maxSum;
        }
    }
}
