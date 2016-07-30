namespace _09.LinkedListTraversal
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyLinkedList<T> : IEnumerable<T>
        where T : IComparable
    {
        private LinkedListElement<T> firstElementOfTheList;
        private LinkedListElement<T> lastElementOfTheList;

        public MyLinkedList()
        {
            this.Count = 0;
        }

        public int Count { get; set; }

        public LinkedListElement<T> FirstElementOfTheList
        {
            get
            {
                return firstElementOfTheList;
            }

            set
            {
                firstElementOfTheList = value;
            }
        }

        public LinkedListElement<T> LastElementOfTheList
        {
            get
            {
                return lastElementOfTheList;
            }

            set
            {
                lastElementOfTheList = value;
            }
        }

        public void Add(T element)
        {
            if (this.Count == 0)
            {
                this.FirstElementOfTheList = new LinkedListElement<T>(null, element, null);
                this.LastElementOfTheList = this.FirstElementOfTheList;
            }
            else
            {
                var newElement = new LinkedListElement<T>(this.lastElementOfTheList, element, null);
                this.LastElementOfTheList.NextElement = newElement;
                this.lastElementOfTheList = newElement;
            }

            this.Count++;
        }

        public void Remove(T element)
        {
            LinkedListElement<T> elementSearch = this.FirstElementOfTheList;
            while (elementSearch != null)
            {
                if (elementSearch.Value.CompareTo(element) == 0)
                {
                    var previousElement = elementSearch.PreviousElement;
                    var nextElement = elementSearch.NextElement;

                    if (previousElement == null && nextElement == null)
                    {
                        this.FirstElementOfTheList = null;
                        this.LastElementOfTheList = null;
                    }
                    else if (previousElement == null)
                    {
                        nextElement.PreviousElement = null;
                        this.FirstElementOfTheList = nextElement;
                    }
                    else if (nextElement == null)
                    {
                        previousElement.NextElement = null;
                        this.LastElementOfTheList = previousElement;
                    }
                    else
                    {
                        previousElement.NextElement = nextElement;
                        nextElement.PreviousElement = previousElement;
                    }

                    this.Count--;
                    break;
                }

                elementSearch = elementSearch.NextElement;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListElement<T> element = this.FirstElementOfTheList;

            while (element != null)
            {
                yield return element.Value;
                element = element.NextElement;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
