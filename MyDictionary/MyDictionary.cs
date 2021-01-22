using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        List<K> listOfKey;
        List<V> listOfValue;

        public MyDictionary()
        {
            listOfKey = new List<K>();
            listOfValue = new List<V>();
        }

        public void Add(K key, V value)
        {
            if (!listOfKey.Contains(key))
            {
                listOfKey.Add(key);
                listOfValue.Add(value);
            }
        }

        public int Count
        {
            get { return listOfKey.Count; }
        }

    }
}
