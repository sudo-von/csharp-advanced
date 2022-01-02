using System;

namespace _02_delegates
{

    public class DelegateA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called DelegateA.MethodA() with parameter: " + message);
        }
    }

    public class DelegateB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called DelegateB.MethodB() with parameter: " + message);
        }
    }
}