using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    /*
    1,2,3,4,5
reverse array A
rotation n-1 reverse 
B = 3
o/p: 3,4.5,1,2

Revers: 
	5,4,3,2,1

Step2: index 0 to B-1
	reverse
	3,4,5,2,1
Step2: index B to n-1
	reverse
Ste3: 3,4,5,1,2
	
Reverse(start, end, Array)
 */
    internal class RotationGame1
    {
        public void solve(int[] A, int B)
        {
            var n = A.Length;
            if (n == 1)
                Console.WriteLine(A[0]);
            B = B % n;
            while (B > 0)
            {
                var lastElement = A[n - 1];
                var index = n;
                    while (index >= 2)
                    {
                        A[index - 1] = A[index - 2];
                        index--;
                    }
                    A[0] = lastElement;
                B--;
            }

            foreach (var i in A)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
