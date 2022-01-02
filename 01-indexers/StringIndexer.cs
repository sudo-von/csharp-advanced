using System;

namespace _01_indexers
{
    public class StringIndexer
    {
        private string[] list = new string[10];
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= list.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return list[index];
            }

            set
            {
                if (index < 0 || index >= list.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                list[index] = value;
            }
        }

        public string this[string name]
        {
            get
            {
                foreach (string str in list){
                    if(str.ToLower() == name.ToLower())        
                        return str;
                    }
                        
                return null;
            }
        }
    }
}