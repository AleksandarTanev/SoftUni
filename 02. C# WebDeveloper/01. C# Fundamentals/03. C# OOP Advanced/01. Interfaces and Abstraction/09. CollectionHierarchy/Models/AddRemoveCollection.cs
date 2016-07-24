namespace _09.CollectionHierarchy.Models
{
    using System.Collections.Generic;

    using Interfaces;

    public class AddRemoveCollection : IAddRemoveCollection
    {
        private List<string> collectionStrings;

        public AddRemoveCollection()
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
            int indexToRemove = this.collectionStrings.Count - 1;
            string removedItem = this.collectionStrings[indexToRemove];

            this.collectionStrings.RemoveAt(indexToRemove);

            return removedItem;
        }
    }
}
