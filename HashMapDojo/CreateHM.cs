using System;
using System.Collections;
using System.Collections.Generic;

namespace HashMapDojo
{
    public class CreateHM : IEnumerable
    {
        private int bucketSize = 16;
        public LinkedList<KeyValue>[] elements;

        public CreateHM()
        {
            elements = new LinkedList<KeyValue>[bucketSize];
            for (int i = 0; i < bucketSize; i++)
            {
                elements[i] = new LinkedList<KeyValue>();
            }
        }

        public void AddElement(string key, int value)
        {
            int position = GetHashCode(key);

            LinkedList<KeyValue> list = elements[position];
            KeyValue newKeyValue = new KeyValue(key, value);
            foreach (var arrayItem in list)
            {
                if (arrayItem.Key == key)
                {
                    throw new ArgumentException();
                }
            }
            list.AddLast(newKeyValue);
        }


        private int GetHashCode(string key)
        {
            var hashNumber = key.GetHashCode();
            return Math.Abs(hashNumber % bucketSize);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
