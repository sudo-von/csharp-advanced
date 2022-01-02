using System;

namespace _01_indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var indexer = new Indexer();
            indexer[0] = 1;
            indexer[1] = 2;
            indexer[2] = 3;
            Console.WriteLine(indexer[0]);
        }
    }

    class Indexer
    {
        private int[] list = new int[100];
        public int this [int i]
        {
            get
            {
                return list[i];
            }
            set
            {
                list[i] = value;
            }
        }
    }
}
