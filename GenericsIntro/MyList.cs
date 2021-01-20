using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        // constructor
        public MyList()
        {
                
        }
        public void Add(T item) 
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
