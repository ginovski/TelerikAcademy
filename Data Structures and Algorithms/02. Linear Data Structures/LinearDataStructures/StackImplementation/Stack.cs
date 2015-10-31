using System;

namespace StackImplementation
{
    public class Stack<T>
    {
        private const int InitialSize = 4;

        private T[] data;
        private int index;

        public Stack()
        {
            this.index = 0;
            this.data = new T[InitialSize];
        }

        public int Count
        {
            get
            {
                return this.index;
            }
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public void Push(T item)
        {
            if (index >= this.Capacity)
            {
                this.Resize();
            }

            this.data[index] = item;
            this.index++;
        }

        public T Pop()
        {
            this.index--;
            return this.data[this.index];
        }

        public T Peek()
        {
            return this.data[this.index];
        }

        public bool Contains(T item)
        {
            foreach (var element in this.data)
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            this.data = new T[InitialSize];
        }

        private void Resize()
        {
            var cachedData = this.data;

            this.data = new T[this.Capacity * 2];
            for (int i = 0; i < cachedData.Length; i++)
            {
                this.data[i] = cachedData[i];
            }
        }
    }
}