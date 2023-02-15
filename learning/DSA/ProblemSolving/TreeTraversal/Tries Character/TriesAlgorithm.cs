using System;
using System.Collections.Generic;
using System.Text;

namespace Tries_Character
{
    class Node {
        public bool isEnd;
        public Dictionary<char, Node> nodes = new Dictionary<char, Node>();
        public Node()
        {
            isEnd = false;
        }
    }
    internal class TriesAlgorithm
    {
        public void solve(string[] words, string[] queries) {
            Node root = new Node();
            for (int i = 0; i < words.Length; i++)
            {
                Add(words[i], root);
            }

            for (int i = 0; i < queries.Length; i++)
            {
                Console.Write(find(queries[i], root));
            }
            Console.ReadLine();
        }
        bool find(string str, Node r) {
        int n = str.Length;
            for (int i = 0; i < n; i++)
            {        
                    char ch = str[i];
                if (!r.nodes.ContainsKey(ch)) {

                    return false;
                }
                else {
                    r = r.nodes[ch];
                }

            }
            return r.isEnd;
        
        }
        void Add(string str, Node r)
        { 
        
            int n = str.Length;
            for (int i = 0; i < n; i++)
            {
                char ch = str[i];
                if (!r.nodes.ContainsKey(ch))
                {
                    Node t = new Node();
                    r.nodes.Add(ch, t);
                    r = r.nodes[ch];

                }
                else {
                    r = r.nodes[ch];     
                }
              
            }
            r.isEnd = true;
        }
        
    }
}
