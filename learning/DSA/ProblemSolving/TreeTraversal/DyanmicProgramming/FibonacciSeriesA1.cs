using System;
using System.Collections.Generic;
using System.Text;

namespace DyanmicProgramming
{
    internal class FibonacciSeriesA1
    {
        public int GetFibonacciSeriesNthValue(int n)
        {
            if (n <= 1)
                return n;
            int a = 0, b = 1;
            while (n > 1)
            {
                var temp = a;
                a = b;
                b = temp + a;
                n--;
            }
            return b;
        }
    }
}
