namespace _09.CollectionHierarchy.Models
{
    using System.Collections.Generic;

    using Interfaces;

    public class AddCollection : IAddCollection
    {
        private List<string> collectionStrings;

        public AddCollection()
        {
            this.collectionStrings = new List<string>();
        }

        public int Add(string item)
        {
            this.collectionStrings.Add(item);

            int index = this.collectionStrings.Count - 1;
            return index;
        }
    }
}
