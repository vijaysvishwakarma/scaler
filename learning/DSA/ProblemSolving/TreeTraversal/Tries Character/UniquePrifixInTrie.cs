using System;
using System.Collections.Generic;
using System.Text;

namespace Tries_Character
{
    internal class UniquePrifixInTrie
    {
        class TrieNode
        {
            public Dictionary<char, TrieNode> Nodes = new Dictionary<char, TrieNode>();
            public bool IsEnd;
            public int UniquePrefixFound;
            public TrieNode()
            {
                IsEnd = false;
                UniquePrefixFound = 0;
            }

        }
        public List<string> prefix(List<string> A)
        {
            var result = new List<string>();
            if (A.Count == 0)
            {
                return result;
            }
            var root = new TrieNode();
            // Add
            foreach (var word in A)
            {
                AddInTree(word, root);
            }
            // Search
            foreach (var word in A)
            {
                result.Add(Search(word, root));
            }
            return result;
        }

        void AddInTree(string word, TrieNode root)
        {
            var wordLength = word.Length;
            var currNode = root;
            for (var i = 0; i < wordLength; i++)
            {
                var ch = word[i];
                if (!currNode.Nodes.ContainsKey(ch))
                {
                    var newNode = new TrieNode();
                    currNode.Nodes.Add(ch, newNode);
                }
                else
                {
                    currNode.Nodes[ch].UniquePrefixFound += 1;
                }
                currNode = currNode.Nodes[ch];
            }
            root.IsEnd = true;
        }
        string Search(string word, TrieNode root)
        {
            var wordLength = word.Length;
            var res = "";
            var currNode = root;
            for (var i = 0; i < wordLength; i++)
            {
                var ch = word[i];
                if (!currNode.Nodes.ContainsKey(ch))
                {
                    return string.Empty;
                }
                else if (currNode.Nodes[ch].UniquePrefixFound > 0)
                {
                    res += ch;
                }
                if (currNode.Nodes[ch].UniquePrefixFound == 0)
                {
                    res += ch;
                    break;
                }
             //   res += ch;
                currNode = currNode.Nodes[ch];
            }
            return res;
        }
    }
}
