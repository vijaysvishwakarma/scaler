using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class MergeTwoArray
    {
        /// <summary>
        ///   A = 1 3 5 4 6
        ///   B = 2 4 7 8 9 10 11
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public List<int> Solve(List<int> A, List<int> B)
        {
            var totalRecord = A.Count + B.Count;
            List<int> result = new List<int>(totalRecord);
            A.Sort();
            B.Sort();
            var l = 0;
            var r = 0;
            while (l < A.Count && r < B.Count)
            {
                if (A[l] < B[r])
                {
                    result.Add(A[l]);
                    l++;

                }
                else
                {
                    result.Add(B[r]);
                    r++;
                }
            }
            while (l < A.Count)
            { 
                result.Add(A[l]);
                l++;
            }
            while (r < B.Count)
            {
                result.Add(B[r]);
                r++;
            }
            return result;
        }
    }
}
