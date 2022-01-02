using System;

namespace _01_indexers
{
    public class IntegerIndexer
    {
        private int[] list = new int[100];
        public int this [int index]
        {
            get
            {
                if (index < 0 || index >= list.Length)
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
    }
}