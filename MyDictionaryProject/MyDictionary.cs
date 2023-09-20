using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryProject
{
    internal class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey item, TValue item2)
        {
            TKey[] TempKeys = keys;
            TValue[] TempValues = values;

            keys = new TKey[keys.Length + 1];

            for (int i = 0; i < TempKeys.Length; i++)
            {
                keys[i] = TempKeys[i];
            }

            keys[keys.Length - 1] = item;

            values = new TValue[keys.Length + 1];

            for (int i = 0; i < TempValues.Length; i++)
            {
                values[i] = TempValues[i];
            }

            values[keys.Length - 1] = item2;

            Console.WriteLine("{0}: {1}", item, item2);
        }
    }
}
