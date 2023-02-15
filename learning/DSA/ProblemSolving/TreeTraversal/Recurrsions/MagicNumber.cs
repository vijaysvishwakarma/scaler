using System;
using System.Collections.Generic;
using System.Text;

namespace Recurrsions
{
    /// <summary>
    /// Given a number A, check if it is a magic number or not.
    /// A number is said to be a magic number if the sum of its digits is calculated till a single digit recursively by adding the sum of the digits after every addition.If the single digit comes out to be 1, then the number is a magic number.
    /// </summary>
    internal class MagicNumber
    {
        public int IsMagicNumber(int A)
        {
            var sum = 0;
            if (A > 9)
            {
                A = GetSumOfDigit(A);
                if (A > 9)
                    A = IsMagicNumber(A);
            }
            return A == 1 ? 1 : 0;
        }

        private int GetSumOfDigit(int A)
        {
            if (A < 9)
                return A;
            var sum = 0;
            while (A > 9)
            {
                var digit = A % 10;
                A = A / 10;
                sum = sum + digit;

            }
            return sum + A;
        }
    }
}
