namespace _09.LinkedListTraversal
{
    public class LinkedListElement<T>
    {
        private LinkedListElement<T> previousElement;
        private T value;
        private LinkedListElement<T> nextElement;

        public LinkedListElement(LinkedListElement<T> previousElement, T value, LinkedListElement<T> nextElement)
        {
            this.PreviousElement = previousElement;
            this.Value = value;
            this.NextElement = nextElement;
        }

        public LinkedListElement<T> PreviousElement
        {
            get
            {
                return previousElement;
            }

            set
            {
                previousElement = value;
            }
        }

        public T Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public LinkedListElement<T> NextElement
        {
            get
            {
                return nextElement;
            }

            set
            {
                nextElement = value;
            }
        }
    }
}
