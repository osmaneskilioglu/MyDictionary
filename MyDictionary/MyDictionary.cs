using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        TKey[] tempkey;
        TValue[] tempvalue;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            tempkey = keys;
            tempvalue = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];


            for (int i = 0; i < tempkey.Length; i++)
            {
                keys[i] = tempkey[i];
                values[i] = tempvalue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


        }

        public TKey[] GetKeys
        {
            get { return keys; }
        }
        public TValue[] GetValues
        {
            get { return values; }
        }
        public int Length
        {
            get { return keys.Length; }
        }

    }
}
