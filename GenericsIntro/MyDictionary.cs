using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<K,V>
    {
        K[] Key;
        V[] Value;
        public MyDictionary()
        {
            Key = new K[0];
            Value = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKey = Key;
            V[] tempValue = Value;

            Key = new K[Key.Length + 1];
            Value = new V[Value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                Key[i] = tempKey[i];
                Value[i] = tempValue[i];
            }
            Key[Key.Length - 1] = key;
            Value[Value.Length - 1] = value;
        }
        public int Length
        {
            get { return Key.Length; }
        }
    }
}
