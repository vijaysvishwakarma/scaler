using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    internal class FindUnique
    {
        public int Solve(List<int> A)
        {
            var result = 0;
            for (int i = 0; i < A.Count; i++)
            {
                result = result ^ A[i];
            }
            return result;
        }

    }
}
