namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            this.Sort(collection, 0, collection.Count - 1);
        }

        private void Sort(IList<T> collection, int lowIndex, int highIndex)
        {
            if (lowIndex >= highIndex)
            {
                return;
            }

            T pivot = collection[highIndex];
            int swapPlace = lowIndex;

            for (int i = lowIndex; i <= highIndex - 1; i++)
            {
                if (collection[i].CompareTo(pivot) <= 0)
                {
                    this.Swap(collection, swapPlace, i);
                    swapPlace += 1;
                }
            }

            this.Swap(collection, swapPlace, highIndex);

            this.Sort(collection, lowIndex, swapPlace - 1);
            this.Sort(collection, swapPlace + 1, highIndex);
        }

        private void Swap(IList<T> collection, int firstElementIndex, int secondElementIndex)
        {
            T cached = collection[firstElementIndex];
            collection[firstElementIndex] = collection[secondElementIndex];
            collection[secondElementIndex] = cached;
        }
    }
}