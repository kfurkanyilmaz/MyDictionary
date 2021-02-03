using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "");
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Kadir");
            myDictionary.Add(2, "Furkan");
            myDictionary.Add(3, "Yılmaz");
            myDictionary.Key_Collection();
            myDictionary.Value_Collection();
        }
    }

    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            keys = new TKey[keys.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;


            TValue[] tempValues = values;
            values = new TValue[values.Length + 1];
            for (int j = 0; j < tempValues.Length; j++)
            {
                values[j] = tempValues[j];
            }
            values[values.Length - 1] = value;
        }

        public TKey[] Keys
        {
            get { return keys; }
        }

        public TValue[] Values
        {
            get { return values; }
        }


        public void Key_Collection()
        {
            foreach (TKey key in keys)
            {
                Console.WriteLine(key);
            }
        }

        public void Value_Collection()
        {
            foreach (TValue value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
