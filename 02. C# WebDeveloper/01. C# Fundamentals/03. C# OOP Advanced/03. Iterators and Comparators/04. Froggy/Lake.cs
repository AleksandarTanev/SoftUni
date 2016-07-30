namespace _04.Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        } 

        public IEnumerator<int> GetEnumerator()
        {
            var numbersIndexes = new Stack<int>();
            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 != 0)
                {
                    numbersIndexes.Push(i);
                    continue;
                }

                yield return this.stones[i];
            }

            while (numbersIndexes.Count > 0)
            {
                yield return this.stones[numbersIndexes.Pop()];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
