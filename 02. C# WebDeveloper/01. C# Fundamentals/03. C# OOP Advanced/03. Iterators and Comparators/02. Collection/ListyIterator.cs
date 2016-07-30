using System.Collections;

namespace _02.Collection
{
    using System;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int currentIndexPosition;

        public ListyIterator(List<T> collection)
        {
            this.collection = collection;
            this.currentIndexPosition = 0;
        }

        public bool Move()
        {
            if (currentIndexPosition + 1 >= collection.Count)
            {
                return false;
            }

            currentIndexPosition++;
            return true;
        }

        public bool HasNext()
        {
            if (currentIndexPosition + 1 >= collection.Count)
            {
                return false;
            }

            return true;
        }

        public void Print()
        {
            if (this.collection.Count == 0)
            {
                throw new IndexOutOfRangeException("Invalid Operation!");
            }

            Console.WriteLine(this.collection[currentIndexPosition]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
