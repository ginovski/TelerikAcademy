namespace HashTableImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private const int InitialSize = 16;

        private int count;
        private LinkedList<KeyValuePair<K, T>>[] data;

        public HashTable()
        {
            this.count = 0;
            this.data = new LinkedList<KeyValuePair<K, T>>[InitialSize];
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[K key]
        {
            get
            {
                return this.Find(key);
            }
        }

        public void Add(K key, T value)
        {
            int hash = key.GetHashCode();
            hash = Math.Abs(hash % this.Capacity);

            if (this.data[hash] == null)
            {
                this.data[hash] = new LinkedList<KeyValuePair<K, T>>();
            }

            this.data[hash].AddLast(new KeyValuePair<K, T>(key, value));
            this.count++;
        }

        public T Find(K key)
        {
            int hash = key.GetHashCode();
            hash = Math.Abs(hash % this.Capacity);

            var hashList = this.data[hash];
            foreach (var pair in hashList)
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }

            throw new KeyNotFoundException();
        }

        public IEnumerable<K> Keys()
        {
            var keys = new List<K>();

            foreach (var hashList in this.data)
            {
                foreach (var pair in hashList)
                {
                    keys.Add(pair.Key);
                }
            }

            return keys;
        }

        public void Remove(K key)
        {
            int hash = key.GetHashCode();
            hash = Math.Abs(hash % this.Capacity);

            var hashList = this.data[hash];
            KeyValuePair<K, T> pairToRemove = new KeyValuePair<K, T>();
            foreach (var pair in hashList)
            {
                if (pair.Key.Equals(key))
                {
                    pairToRemove = pair;
                }
            }

            hashList.Remove(pairToRemove);
        }

        public void Clear()
        {
            this.data = new LinkedList<KeyValuePair<K, T>>[InitialSize];
        }

        private void Resize()
        {
            var cachedData = this.data;
            var newData = new LinkedList<KeyValuePair<K, T>>[this.Capacity * 2];

            this.data = newData;

            foreach (var hashList in cachedData)
            {
                foreach (var pair in hashList)
                {
                    this.Add(pair.Key, pair.Value);
                }
            }
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var hashList in data)
            {
                foreach (var pair in hashList)
                {
                    yield return pair;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}