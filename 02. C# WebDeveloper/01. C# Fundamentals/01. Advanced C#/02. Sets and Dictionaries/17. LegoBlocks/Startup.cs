namespace _17.LegoBlocks
{
    using System;
    using System.Linq;

    class LegoBlocks
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] firstBlock = new int[n][];
            int[][] secondBlock = new int[n][];

            for (int i = 0; i < n; i++)
            {
                firstBlock[i] =
                    Array.ConvertAll(
                        Console.ReadLine().Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries),
                        int.Parse);
            }

            for (int i = 0; i < n; i++)
            {
                secondBlock[i] =
                    Array.ConvertAll(
                        Console.ReadLine().Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries),
                        int.Parse);
                Array.Reverse(secondBlock[i]);
            }


            int rowLength = firstBlock[0].Length + secondBlock[0].Length;
            bool flagAllMatch = true;

            for (int i = 1; i < n; i++)
            {
                if (firstBlock[i].Length + secondBlock[i].Length != rowLength)
                {
                    flagAllMatch = false;
                }
            }

            int sumCells = 0;
            if (flagAllMatch == false)
            {
                for (int i = 0; i < n; i++)
                {
                    sumCells += firstBlock[i].Length + secondBlock[i].Length;
                }

                Console.WriteLine("The total number of cells is: " + sumCells);
                return;
            }


            int[][] newBlock = new int[n][];

            for (int i = 0; i < newBlock.Length; i++)
            {
                newBlock[i] = firstBlock[i].Concat(secondBlock[i]).ToArray();
            }

            foreach (var item in newBlock)
            {
                Console.WriteLine("[{0}]", string.Join(", ", item));
            }



        }
    }
}