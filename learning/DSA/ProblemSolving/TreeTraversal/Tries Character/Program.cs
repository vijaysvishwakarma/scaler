using System;
using System.Collections.Generic;
using System.Linq;

namespace Tries_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //    var words = new string[] { "damp", "dam", "ant", "ants" };
            //    var queries = new string[] { "dam", "ant" };

            //    TriesAlgorithm triesAlgorithm = new TriesAlgorithm();
            //    triesAlgorithm.solve(words, queries);

            //List<string> words = new List<string>() { "abcd", "aecd", "abaa", "abef", "acdcc", "acbcc" };
            //List<int> weights = new List<int>() { 2, 1, 3, 4, 6, 5 };
            //List<string> prefix = new List<string>() { "ab", "abc", "a" };

            //List<string> words = new List<string>() { "aaaa", "aacd", "abaa", "abaa", "aadcc" };
            //List<int> weights = new List<int>() { 3, 4, 1, 2, 6 };
            //List<string> prefix = new List<string>() { "aa", "aba", "abc" };

            //TriesAlgorithm triesAlgorithm = new TriesAlgorithm();
            //triesAlgorithm.solve(words, queries);
            //MaxFiveQueries maxFiveQueries = new MaxFiveQueries();
            //maxFiveQueries.solve1(words, weights, prefix);
            //var case1 = int.Parse(Console.ReadLine());
            //List<int> wordCount = new List<int>();
            //Console.ReadLine()
            //        .Split()
            //        .ToList()
            //        .ForEach(s => {
            //            wordCount.Add(int.Parse(s));
            //        });
            ////List<string> words = new List<string>();
            ////List<string> prefix = new List<string>();
            //List<int> wordWeight = new List<int>();
            //words = Console.ReadLine()
            //        .Split()
            //        .ToList();

            //        Console.ReadLine()
            //        .Split()
            //        .ToList()
            //        .ForEach(s => {
            //            wordWeight.Add(int.Parse(s));
            //        });
            //prefix = Console.ReadLine()
            //        .Split()
            //        .ToList();

            //********************************************************* Unique Prefix in Trie **************************

            UniquePrifixInTrie uniquePrifixInTrie = new UniquePrifixInTrie();
            //       List<string> inputString = new List<string> { "dog", "dove", "doge", "dogem" };
            // o/p  ["z", "dog", "du", "dov"]
            List<string> inputString = new List<string> { "zebra", "dog", "duck", "dove" };
            var result =  uniquePrifixInTrie.prefix(inputString);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
