using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tries_Character
{
    internal class MaxFiveQueries
    {
        class TrieNode
        {
            public bool isEnd;
            public Dictionary<char, TrieNode> nodes = new Dictionary<char, TrieNode>();
            public TrieNode()
            {
                isEnd = false;
            }
            public List<KeyValuePair<string, int>> topFiveWordWithWeight = new List<KeyValuePair<string, int>>(5);
        }
        public void solve1(List<string> words,List<int> weights, List<string> prefix)
        {
            TrieNode root = new TrieNode();
            List<int> result = new List<int>();

            List<KeyValuePair<string, int>> wordWithWeight = new List<KeyValuePair<string, int>>();
            for (var i = 0; i < words.Count; i++)
            {
                wordWithWeight.Add(new KeyValuePair<string, int>(words[i], weights[i]));
            }

            //var descendingList = myList.OrderByDescending(x => x.Value).ToList();

            var worddict = new Dictionary<int, string>();
            for (int i = 0; i < wordWithWeight.Count(); i++)
            {
                // Add to tries structure
              //  Add(wordWithWeight.ElementAt(i).Key, root, i);
                Add(wordWithWeight[i], root, i);
            }

            for (int i = 0; i < prefix.Count; i++)
            {
                var autocompleteWords = find(prefix[i], root);
                for(var j = autocompleteWords.Count - 1; j >= 0; j--)
                {
                    Console.Write(autocompleteWords[j].Key + " ");
                }
                if (autocompleteWords.Count == 0)
                {
                    Console.WriteLine("-1"+ " ");
                }
                else
                    Console.WriteLine();
            }
        }
        List<KeyValuePair<string, int>> find(string str, TrieNode r)
        {
            int n = str.Length;
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                char ch = str[i];
                if (!r.nodes.ContainsKey(ch))
                {
                    found = false;
                    break;
                }
                else
                {
                    found = true;
                    r = r.nodes[ch];
                }

            }
            if (found)
            {
                
                return r.topFiveWordWithWeight;
            }
            else
                return new List<KeyValuePair<string,int>>();
        }
        //void Add(string str, TrieNode r, int index)
        void Add(KeyValuePair<string, int> wordWithWeight, TrieNode root, int index)
        {
            int n = wordWithWeight.Key.Length;//str.Length;
            var curr = root;
            for (int i = 0; i < n; i++)
            {
                char ch = wordWithWeight.Key[i];
                if (!curr.nodes.ContainsKey(ch))
                {
                    TrieNode t = new TrieNode();
                    curr.nodes.Add(ch, t);
                }
                
                curr = curr.nodes[ch];

                if (curr.topFiveWordWithWeight.Count < 5)
                {
                    curr.topFiveWordWithWeight.Add(wordWithWeight);
                }
                else {
                    if (curr.topFiveWordWithWeight[0].Value < wordWithWeight.Value)
                    {
                        curr.topFiveWordWithWeight[0] = wordWithWeight;
                    }
                }
                curr.topFiveWordWithWeight.Sort((x, y) => x.Value.CompareTo(y.Value));
            }
            root.isEnd = true;
        }

    }
}
