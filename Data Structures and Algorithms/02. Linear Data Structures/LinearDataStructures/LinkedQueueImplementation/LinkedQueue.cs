namespace LinkedQueueImplementation
{
    using System.Collections.Generic;

    public class LinkedQueue<T>
    {
        private LinkedList<T> elements;
        private int count;

        public LinkedQueue()
        {
            this.count = 0;
            this.elements = new LinkedList<T>();
        }

        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }

        public void Enqueue(T element)
        {
            this.elements.AddLast(element);
        }

        public T Dequeue()
        {
            T element = this.elements.First.Value;

            this.elements.RemoveFirst();

            return element;
        }

        public T Peek()
        {
            return this.elements.First.Value;
        }

        public bool Contains(T element)
        {
            return this.elements.Contains(element);
        }

        public void Clear()
        {
            this.elements.Clear();
        }
    }
}