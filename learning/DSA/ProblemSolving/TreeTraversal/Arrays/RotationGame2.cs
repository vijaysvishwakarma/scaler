using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    /*
    1,2,3,4,5
reverse array A
rotation n-1 reverse 

    sg-1
        5,4,3,2,1
    sg-2
        1,2,3,4,5
    sg-3
        5,4,3,2,1
B = 3
o/p: 3,4,5,1,2
B = 2
o/p: 1 -> 5,1,2,3,4
    1 -> 4,5,1,2,3
Revers: 
	5,4,3,2,1

Step2: index 0 to B-1
	reverse
	3,4,5,2,1
Step2: index B to n-1
	reverse
Ste3: 3,4,5,1,2
	
Reverse(start, end, Array)
    3,1,4,2
    1,2,3,4
   o/p 2 = 3,4,1,2
 */
    internal class RotationGame2
    {
        public void solve(int[] A, int B)
        {
            var n = A.Length;
            if (n == 1)
                Console.WriteLine(A[0]);
            B = B % n;
            reverse(0, n-1, A);
            reverse(0, B-1, A);
            reverse(B, n-1, A);

            foreach (var i in A)
            {
                Console.WriteLine(i + " ");
            }
        }
        void reverse(int s, int e, int[] A)
        {
            while (s < e)
            {
                var temp = A[s];
                A[s] = A[e];
                A[e] = temp;
                s++;e--;
            }
        }
    }
}
