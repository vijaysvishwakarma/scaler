using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    internal class VisitedNodes
    {
        public int solve(int A, List<List<int>> B)
        { 
        
        }

        bool BFS(int n, int e, int[] u, int[] v, int s, int d)
        {
            List<List<int>> g = new List<List<int>>(n+1);

            for (int i = 0; i < e; i++)
            {
                g[u[i]].Add(v[i]);
                g[v[i]].Add(u[i]);
            }

            Queue<int> q = new Queue<int>();
            q.Enqueue(s);
            bool[] visited = new bool[n+1];
            Array.Fill(visited, false);
            visited[s] = true;
            int[] lev = new int[n+1];
            Array.Fill(lev, -1);
                lev[s] = 0;
            int[] parent = new int[n+1];
            Array.Fill(parent, -1);
            parent[s] = 0;
                
            while(q.Count > 0)
            {
                int cv = q.Dequeue();
                for (int i = 0; i < g[cv].Count; i++)
                {
                    cv = g[cv][i];
                    if (visited[cv] == false)
                    {
                        visited[cv] = true;
                        q.Enqueue(cv);
                        lev[cv] = lev[cv] + 1;
                        parent[cv] = cv;
                    }
                }
            }
            return visited[d];
        }
    }
}
