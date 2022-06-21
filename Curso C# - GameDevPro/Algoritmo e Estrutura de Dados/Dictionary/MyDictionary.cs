using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class MyDictionary
    {
        private struct Entry
        {
            public int Value;
            public int KeyHash;
        }

        private LinkedList<Entry>[] buckets;
        public MyDictionary(int capacity)
        {
            buckets = new LinkedList<Entry>[capacity * 2];
        }
        public int GetValue(string key)
        {   
            var hash = key.GetHashCode();
            var bucketIndex = Math.Abs(hash) % buckets.Length;

            var bucket = buckets[bucketIndex];
            if(bucket != null)
            {
                foreach (var entry in bucket)
                {
                    if(entry.KeyHash == hash)
                    {
                        return entry.Value;
                    }
                }
            }
            return -1;
        }
        public void Add(string key, int value)
        {
            var hash = key.GetHashCode();
            var bucketIndex = Math.Abs(hash % buckets.Length);

            var bucket = buckets[bucketIndex];
            if(bucket == null)
            {
                bucket = new LinkedList<Entry>();
                buckets[bucketIndex] = bucket;
            }

            bucket.AddLast(new Entry
            {
                Value = value,
                KeyHash = hash
            });
        }
        public void Remove(string key)
        {
            var hash = key.GetHashCode();
            var bucketIndex = Math.Abs(hash % buckets.Length);

            var bucket = buckets[bucketIndex];
            if(bucket != null)
            {
                var current = bucket.First;
                while (current != null)
                {
                    if(current.Value.KeyHash == hash)
                    {
                        bucket.Remove(current);
                        break;
                    }
                }
            }
        }
    }
}