namespace _09.CustomListSorter.Sorters
{
    using System;

    using Models;

    public class Sorter
    {
        public static void Sort<T>(CustomList<T> collection)
            where T : IComparable
        {
            for (int i = 0; i < collection.Count; i++)
            {
                int j = i;
                while (j - 1 >= 0 && collection[j - 1].CompareTo(collection[j]) > 0)
                {
                    collection.Swap(j - 1, j);

                    j--;
                }
            }
        }
    }
}
