using System;

namespace _03_events
{
    public class Operation  
    {  
        public event EventHandler xyz;
        public void Action(string a)  
        {  
            if (xyz != null)  
            {  
                xyz(a);  
                Console.WriteLine(a);   
            }  
            else  
            {  
                Console.WriteLine("Not Registered");   
            }  
        }  
    }  
}