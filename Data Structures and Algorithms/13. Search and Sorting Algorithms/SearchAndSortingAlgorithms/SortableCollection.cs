namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private static Random randomGenerator = new Random();

        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            foreach (var itemInCollection in this.items)
            {
                if (itemInCollection.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            int minIndex = 0;
            int maxIndex = this.items.Count - 1;

            while (minIndex <= maxIndex)
            {
                int middleIndex = minIndex + ((maxIndex - minIndex) / 2);

                if (this.items[middleIndex].Equals(item))
                {
                    return true;
                }
                else if (this.items[middleIndex].CompareTo(item) < 0)
                {
                    minIndex = middleIndex + 1;
                }
                else
                {
                    maxIndex = middleIndex - 1;
                }
            }

            return false;
        }

        /// <summary>
        ///   Fisher-Yates shuffle algorithm works in O(n) complexity
        /// </summary>
        public void Shuffle()
        {
            for (int i = this.items.Count - 1; i >= 0; i--)
            {
                int randomIndex = randomGenerator.Next(0, i);

                T cached = this.items[i];
                this.items[i] = this.items[randomIndex];
                this.items[randomIndex] = cached;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}