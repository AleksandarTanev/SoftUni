namespace _09.CollectionHierarchy.Models
{
    using System.Collections.Generic;

    using Interfaces;

    public class MyList : IMyList
    {
        private List<string> collectionStrings;

        public MyList()
        {
            this.collectionStrings = new List<string>();
        }

        public int Add(string item)
        {
            int indexOfInsert = 0;
            this.collectionStrings.Insert(indexOfInsert, item);

            return indexOfInsert;
        }

        public string Remove()
        {
            int indexToRemove = 0;
            string removedItem = this.collectionStrings[indexToRemove];

            this.collectionStrings.RemoveAt(indexToRemove);

            return removedItem;
        }

        public int Used()
        {
            return this.collectionStrings.Count;
        }
    }
}
