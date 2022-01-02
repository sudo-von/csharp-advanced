using System;

namespace _01_indexers{
    public class GenericIndexer<T>
    {
        private T[] list; 

        public GenericIndexer()
        {
            list = new T[10];
        }

        public GenericIndexer(int length)
        {
            list = new T[length];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 &&  index >= list.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                    return list[index];
            }

            set
            {
                if (index < 0 ||  index >= list.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                list[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return list.Length;
            }
        }
    }
}