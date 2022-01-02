using System;

namespace _02_delegates
{
    public delegate void MyDelegate(string msg);
    public delegate T add<T>(T param1, T param2);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = DelegateA.MethodA;
            del("Hello World");

            MyDelegate del2 = DelegateB.MethodB;
            del2.Invoke("Hello World");

            MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del3("Hello World");

            /* Passing delegate as method. */
            InvokeDelegate(del3);

            /* Multicast delegate. */
            MyDelegate multicastDelegate = del + del2;
            multicastDelegate("Hello World from multicast delegate");

            /* Generic delegates. */
            add<int> sum = Sum;
            Console.WriteLine(sum(10, 20));

            add<string> con = Concat;
            Console.WriteLine(con("Hello ","World!!"));
        }

        static void InvokeDelegate(MyDelegate del)
        {
            del("Hello World");
        }

        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
