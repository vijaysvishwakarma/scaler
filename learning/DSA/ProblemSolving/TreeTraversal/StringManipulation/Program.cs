using System;
using System.Collections.Generic;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var text = "the sky is blue";
            //ReverseWord reverseWord = new ReverseWord();
            //Console.WriteLine(reverseWord.solve(text));

            // tolower
            //ToLower toLower = new ToLower();
            //var inputData = new List<char>() { 'S', 'c', 'A', 'l', 'e', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y' };
            //var result = toLower.to_lower(inputData);
            //for (int i = 0; i < result.Count; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}


            LongestPalindrome longestPalindrome = new LongestPalindrome();
            var input = "abbcccbbbcaaccbababcbcabca";
            var result =  longestPalindrome.solve(input);
            Console.Write(result);

            Console.ReadLine();
        }
    }
}
