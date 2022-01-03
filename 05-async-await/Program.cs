using System;
using System.Threading.Tasks;

namespace _05_async_await
{  
    class Program
    {
        static void Main(string[] args)
        {
            Task t = (new Async()).DoWorkAsync();
            t.Wait();
            Console.ReadLine();
        }
    }
}
