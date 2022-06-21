using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictionaryGeneric<TKey, TValue>
    {
        private struct Entry
        {
            public TValue Value;
            public int KeyHash;
        }
        private LinkedList<Entry>[] buckets;
        public MyDictionaryGeneric(int capacity)
        {
            buckets = new LinkedList<Entry>[capacity * 2];
        }
        public TValue GetValue(TKey key)
        {
            var hash =  key.GetHashCode();
            var bucketIndex = Math.Abs(hash % buckets.Length);

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
            return default(TValue);
        }
        public void Add(TKey key, TValue value)
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
        public void Remove(TKey key)
        {
            var hash = key.GetHashCode();
            var bucketIndex = Math.Abs(hash % buckets.Length);

            var bucket = buckets[bucketIndex];
            if(bucket != null)
            {
                var current = bucket.First;
                while(current != null)
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