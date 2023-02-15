using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringManipulation
{
    public class ReverseWord
    {
        public string solve(string A)
        {
            var reverseData = reverse(A);
            var data = string.Empty;
            foreach (var item in reverseData.Split(" "))
            {
                // Console.Write(reverse(item) + " ");
                data = string.Concat(data, reverse(item) + " ");
            }
            return data;
        }
        private string reverse(string str)
        {
            int s = 0, e = str.Length -1;
            var data = str.ToCharArray();
            while (s < e)
            {
                var temp = data[s];
                data[s] = data[e];
                data[e] = temp;
                s++;
                e--;
            }
            return String.Concat(data);
        }
    }
}
