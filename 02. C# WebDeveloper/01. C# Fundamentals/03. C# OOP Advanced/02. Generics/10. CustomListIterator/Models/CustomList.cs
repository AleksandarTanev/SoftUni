using System.Collections;

namespace _10.CustomListIterator.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;

    public class CustomList<T> : IMyList<T>
        where T : IComparable
    {
        public CustomList()
        {
            this.Collection = new List<T>();
        }

        private List<T> Collection { get; set; }
        public int Count => this.Collection.Count;

        public void Add(T element)
        {
            this.Collection.Add(element);
        }

        public T Remove(int index)
        {
            T element = this.Collection[index];
            this.Collection.RemoveAt(index);

            return element;
        }

        public bool Contains(T element)
        {
            if (this.Collection.Contains(element))
            {
                return true;
            }

            return false;
        }

        public void Swap(int index1, int index2)
        {
            T temp = this.Collection[index1];
            this.Collection[index1] = this.Collection[index2];
            this.Collection[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            int count = this.Collection.Count(c => c.CompareTo(element) > 0);

            return count;
        }

        public T Max()
        {
            T max = this.Collection.Max();

            return max;
        }

        public T Min()
        {
            T min = this.Collection.Min();

            return min;
        }

        public void Print()
        {
            foreach (var item in this.Collection)
            {
                Console.WriteLine(item);
            }
        }

        public T this[int i]
        {
            get { return this.Collection[i]; }
        }
    }
}
