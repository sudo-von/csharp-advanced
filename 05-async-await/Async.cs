using System;
using System.Threading.Tasks;

namespace _05_async_await{
    public class Async
    {
        public int Get10()
        {
            return 10;
        }
        public async Task DoWorkAsync()
        {
            //Func delegate, the last parameter is the return type, there can be 0-16 other parameters
            Func<int> ten = Get10;
            int a = await Task.Run(ten);
            int b = await Task.Run(new Func<int>(Get10));
            int c = await Task.Run(() => { return 10; });
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}