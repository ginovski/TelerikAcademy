namespace List
{
    using System;
    using System.Text;

    public class GenericList<T>
    {
        private const int InitialSize = 16;
        private T[] data;
        private int index;

        public int Count 
        {
            get
            {
                return index;
            }
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public GenericList()
        {
            this.data = new T[InitialSize];
        }

        public GenericList(int size)
        {
            this.data = new T[size];
        }

        public void Add(T element)
        {
            if (index >= this.Capacity)
            {
                Resize();
            }
            this.data[index] = element;
            index++;
        }

        public void Remove(int index)
        {
            //TODO: Implement remove method
        }

        public void Insert(int index)
        {
            //TODO: Implement insert method
        }

        public void Clear()
        {
            this.data = new T[InitialSize];
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Resize()
        {
            T[] newData = new T[this.Capacity * 2];

            for (int i = 0; i < this.Count; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        public T this [int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                return this.data[index];
            }
        }


 
    }
}
