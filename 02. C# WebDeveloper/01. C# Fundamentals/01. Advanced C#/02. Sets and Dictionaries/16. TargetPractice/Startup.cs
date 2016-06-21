namespace _16.TargetPractice
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {
            var matrixLength = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var rows = int.Parse(matrixLength[0]);
            var cols = int.Parse(matrixLength[1]);

            var matrix = new string[rows, cols];

            var snake = Console.ReadLine().ToCharArray();

            var matrixFilling = new Stack<char>();
            while (matrixFilling.Count < rows*cols)
            {
                for (int i = snake.Length - 1; i >= 0; i--)
                {
                    matrixFilling.Push(snake[i]);
                }
            }

            for (int row = rows - 1; row >= 0; row--)
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    matrix[row, col] = matrixFilling.Pop().ToString();
                }

                if (row - 1 < 0)
                {
                    break;
                }

                row--;
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = matrixFilling.Pop().ToString();
                }
            }

            var shotParameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int impactRow = int.Parse(shotParameters[0]);
            int impactCol = int.Parse(shotParameters[1]);
            int impactRadius = int.Parse(shotParameters[2]);


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (((row - impactRow) * (row - impactRow)) + ((col - impactCol) * (col - impactCol)) <= (impactRadius * impactRadius))
                    {
                        matrix[row, col] = " ";
                    }
                }
            }

            bool thereIsChange = true;
            while (thereIsChange)
            {
                thereIsChange = false;

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] != " " && matrix[row + 1, col] == " ")
                        {
                            matrix[row + 1, col] = matrix[row, col];
                            matrix[row, col] = " ";
                            thereIsChange = true;
                        }
                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "");
                }
                Console.WriteLine();
            }
        }
    }
}
