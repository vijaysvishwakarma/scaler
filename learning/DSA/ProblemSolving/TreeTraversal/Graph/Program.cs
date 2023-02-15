using System;
using System.Collections.Generic;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            VisitedNodes visitedNodes = new VisitedNodes();
            List<List<int>> nodes = new List<List<int>>();
            nodes[0] = new List<int>() {1,2 };
            nodes[1] = new List<int>() {2,3 };
            nodes[2] = new List<int>() {3,4 };
            nodes[3] = new List<int>() {4,5 };
            visitedNodes.solve(5, nodes);
        }
    }
}
