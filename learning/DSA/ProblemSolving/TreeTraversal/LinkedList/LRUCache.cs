using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class LRUCache
    {
        Dictionary<int, LinkedListNode<Entry>> map;
        LinkedList<Entry> list;
        int capacity;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            map = new Dictionary<int, LinkedListNode<Entry>>();
            list = new LinkedList<Entry>();
        }

        public int get(int key)
        {
            if (!map.ContainsKey(key))
                return -1;

            LinkedListNode<Entry> entryNode = map[key];
            list.Remove(entryNode);
            list.AddFirst(entryNode);
            return entryNode.Value.Value;
        }

        public void set(int key, int value)
        {
            LinkedListNode<Entry> entryNode = map.GetValueOrDefault(key, new LinkedListNode<Entry>(new Entry(key, value)));
            if (map.ContainsKey(key))
            {
                list.Remove(entryNode);
                map.Remove(key);
            }

            entryNode.Value.Value = value; // Update value
            map[key] = entryNode;
            list.AddFirst(entryNode); // Add to Head

            while (list.Count > capacity) // Truncate excess Nodes
            {
                Entry lastEntry = list.Last.Value;
                map.Remove(lastEntry.Key);
                list.RemoveLast(); // Remove Tail
            }
        }

        internal class Entry
        {
            public int Key { get; set; }
            public int Value { get; set; }

            public Entry(int key, int value)
            {
                this.Key = key;
                this.Value = value;
            }
        }
    }
}
