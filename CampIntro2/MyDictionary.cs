using System;
using System.Collections.Generic;
using System.Text;

namespace CampIntro2
{
    class MyDictionary<K,V>
    {
        K[] keys;
        K[] _tempArray;
        V[] values;
        V[] _tempArray2;
        

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K KeyItem , V ValueItem)
        {
            //Anahtarın eklenmesi
            _tempArray = keys;
            keys = new  K[keys.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                keys[i] = _tempArray[i];

            }
            keys[keys.Length - 1] = KeyItem;

            //Değerin Eklenmesi
            _tempArray2 = values;
            values = new V[values.Length + 1];
            for (int i = 0; i < _tempArray2.Length; i++)
            {
                values[i] = _tempArray2[i];

             }
            values[values.Length - 1] = ValueItem;
        }
        private int _count;

        public int Count
        {
            get { return keys.Length; }

        }
    }
}
