using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDictionary
{
    class MyDict<T, D>
    {
        T[] items1;
        D[] items2;

        public MyDict()
        {
            items1 = new T[0];
            items2 = new D[0];
        }

        public void Add(T item1, D item2)
        {
            T[] temp1 = items1;
            D[] temp2 = items2;

            items1 = new T[items1.Length + 1];
            items2 = new D[items2.Length + 1];

            for (int i = 0; i < temp1.Length; i++)
            {
                items1[i] = temp1[i];
            }
            for (int i = 0; i < temp2.Length; i++)
            {
                items2[i] = temp2[i];
            }
            items1[items1.Length - 1] = item1;
            items2[items2.Length - 1] = item2;
        }
        public T[] Items1
        {
            get
            {
                return items1;
            }
        }
        public D[] Items2
        {
            get
            {
                return items2;
            }
        }
    }
}
