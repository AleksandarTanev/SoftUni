namespace _03.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class MyStack<T> : IEnumerable<T>
    {
        private List<T> collection;

        public MyStack()
        {
            this.collection = new List<T>();
        }

        public T Pop()
        {
            int lastIndex = this.collection.Count - 1;

            if (lastIndex == -1)
            {
                throw new IndexOutOfRangeException("No elements");
            }

            T element = this.collection[lastIndex];
            this.collection.RemoveAt(lastIndex);

            return element;
        }

        public void Push(T element)
        {
            this.collection.Add(element);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.collection.Count - 1; i >= 0; i--)
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
