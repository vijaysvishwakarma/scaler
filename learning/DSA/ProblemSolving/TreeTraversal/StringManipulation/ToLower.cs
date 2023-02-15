using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulation
{
    internal class ToLower
    {
        public List<char> to_lower(List<char> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] >= 'A' && A[i] <= 'Z')
                {
                    A[i] = (char)(A[i] + 32); 
                }
            }        
            return A;
        }
    }
}
