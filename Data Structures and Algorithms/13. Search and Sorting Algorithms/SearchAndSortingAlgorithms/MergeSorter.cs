namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            this.Sort(collection, 0, collection.Count - 1);
        }

        public void Sort(IList<T> collection, int left, int right)
        {
            if (right <= left)
            {
                return;
            }

            int middle = (left + right) / 2;
            this.Sort(collection, left, middle);
            this.Sort(collection, middle + 1, right);

            this.Merge(collection, left, middle, right);
        }

        private void Merge(IList<T> collection, int left, int middle, int right)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;

            T[] leftArray = new T[leftSize];
            T[] rightArray = new T[rightSize];

            for (int i = 0; i < leftSize; i++)
            {
                leftArray[i] = collection[left + i];
            }

            for (int i = 0; i < rightSize; i++)
            {
                rightArray[i] = collection[i + middle + 1];
            }

            int leftMergeIndex = 0;
            int rightMergeIndex = 0;
            int collectionIndex = left;

            while (leftMergeIndex < leftSize && rightMergeIndex < rightSize)
            {
                if (leftArray[leftMergeIndex].CompareTo(rightArray[rightMergeIndex]) <= 0)
                {
                    collection[collectionIndex] = leftArray[leftMergeIndex];

                    leftMergeIndex++;
                }
                else
                {
                    collection[collectionIndex] = rightArray[rightMergeIndex];

                    rightMergeIndex++;
                }

                collectionIndex++;
            }

            while (leftMergeIndex < leftSize)
            {
                collection[collectionIndex] = leftArray[leftMergeIndex];

                leftMergeIndex++;
                collectionIndex++;
            }

            while (rightMergeIndex < rightSize)
            {
                collection[collectionIndex] = rightArray[rightMergeIndex];

                rightMergeIndex++;
                collectionIndex++;
            }
        }
    }
}