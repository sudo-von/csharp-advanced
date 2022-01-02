using System;

namespace _01_indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var integerIndexer = new IntegerIndexer();
            integerIndexer[0] = 1;
            Console.WriteLine(integerIndexer[0]);
            var stringIndexer = new StringIndexer();
            stringIndexer[0] = "Hello";
            Console.WriteLine(stringIndexer[0]);
            var genericIndexer = new GenericIndexer<int>();
            genericIndexer[0] = 100;
            genericIndexer[1] = 25;
            genericIndexer[2] = 34;
            genericIndexer[3] = 42;
            genericIndexer[4] = 12;
            genericIndexer[5] = 18;
            genericIndexer[6] = 2;
            genericIndexer[7] = 95;
            genericIndexer[8] = 75;
            genericIndexer[9] = 53;
            for (int i = 0; i < genericIndexer.Length;i++)
                Console.WriteLine(genericIndexer[i]);
        }
    }
}
