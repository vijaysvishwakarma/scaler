using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class NobleNumber
    {
        public int solve(List<int> A)
        {
            //A.Sort((a, b) => { return a.CompareTo(b); });
            A.Sort();
            if (A[A.Count - 1] == 0)
                return 1;
            for (var i = 0; i < A.Count-1; i++)
            {
                if (A[i] != A[i + 1] && A[i] == A.Count-i-1)
                {
                    return 1;
                }

            }
            return -1;
        }
    }
}
