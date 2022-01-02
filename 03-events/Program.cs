using System;

namespace _03_events
{
    public delegate void EventHandler(string a);  
    class Program
    {
        public static void CatchEvent(string s)  
        {  
            Console.WriteLine("Method Calling");  
        }  
  
        static void Main(string[] args)  
        {  
            Operation o = new Operation();  
              
            o.Action("Event Calling");   
            o.xyz += new EventHandler(CatchEvent);  
             
            Console.ReadLine();  
        }  
    }
}
