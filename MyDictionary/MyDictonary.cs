using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictonary<TKey, TValue>
    {
        TKey[] key;
        TValue[] value;

        public MyDictonary()
        {
            key = new TKey[0];
            value = new TValue[0];
        }
        public void Add(TKey item1, TValue item2)
        {
            TKey[] tempArrayKey = key;
            TValue[] tempArrayValue = value;

            key = new TKey[key.Length + 1];
            value = new TValue[value.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                key[i] = tempArrayKey[i];
                value[i] = tempArrayValue[i];
            }

            key[key.Length - 1] = item1;
            value[value.Length - 1] = item2;

            Console.WriteLine(item1 + " numaralı " + item2 + " adlı kullanıcı sisteme başarıyla eklendi!");

        }
    }
}
