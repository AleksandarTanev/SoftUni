namespace _15.RubikMatrix
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var matrixLength = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var rows = int.Parse(matrixLength[0]);
            var cols = int.Parse(matrixLength[1]);

            var matrix = new int[rows, cols];

            int count = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }

            var inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string commandType = command[1];

                if (commandType == "down")
                {
                    int colToChange = int.Parse(command[0]);
                    int moves = int.Parse(command[2]) % rows;

                    int[] tempArray = new int[rows];
                    int index = 0;
                    for (int row = rows - moves; row < rows; row++)
                    {
                        tempArray[index] = matrix[row, colToChange];
                        index++;
                    }

                    int restRows = 0;
                    while (index < rows)
                    {
                        tempArray[index] = matrix[restRows, colToChange];

                        index++;
                        restRows++;
                    }

                    for (int row = 0; row < rows; row++)
                    {
                        matrix[row, colToChange] = tempArray[row];
                    }
                }
                else if (commandType == "up")
                {
                    int colToChange = int.Parse(command[0]);
                    int moves = int.Parse(command[2]) % rows;

                    int[] tempArray = new int[rows];
                    int index = 0;
                    for (int row = moves; row < rows; row++)
                    {
                        tempArray[index] = matrix[row, colToChange];
                        index++;
                    }

                    int restRows = 0;
                    while (index < rows)
                    {
                        tempArray[index] = matrix[restRows, colToChange];

                        index++;
                        restRows++;
                    }

                    for (int row = 0; row < rows; row++)
                    {
                        matrix[row, colToChange] = tempArray[row];
                    }
                }
                else if (commandType == "right")
                {
                    int rowToChange = int.Parse(command[0]);
                    int moves = int.Parse(command[2]) % cols;

                    int[] tempArray = new int[cols];
                    int index = 0;
                    for (int col = cols - moves; col < cols; col++)
                    {
                        tempArray[index] = matrix[rowToChange, col];
                        index++;
                    }

                    int restCols = 0;
                    while (index < cols)
                    {
                        tempArray[index] = matrix[rowToChange, restCols];

                        index++;
                        restCols++;
                    }

                    for (int col = 0; col < cols; col++)
                    {
                        matrix[rowToChange, col] = tempArray[col];
                    }
                }
                else if (commandType == "left")
                {
                    int rowToChange = int.Parse(command[0]);
                    int moves = int.Parse(command[2]) % cols;

                    int[] tempArray = new int[cols];
                    int index = 0;
                    for (int col = moves; col < cols; col++)
                    {
                        tempArray[index] = matrix[rowToChange, col];
                        index++;
                    }

                    int restCols = 0;
                    while (index < cols)
                    {
                        tempArray[index] = matrix[rowToChange, restCols];

                        index++;
                        restCols++;
                    }

                    for (int col = 0; col < cols; col++)
                    {
                        matrix[rowToChange, col] = tempArray[col];
                    }
                }
            }

            count = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == count)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        int[] location = GetLocationOfCount(matrix, count);
                        matrix[location[0], location[1]] = matrix[row, col];
                        matrix[row, col] = count;

                        Console.WriteLine($"Swap ({row}, {col}) with ({location[0]}, {location[1]})");
                    }

                    count++;
                }
            }

           // PrintMatrix(matrix);
        }

        private static int[] GetLocationOfCount(int[,] matrix, int number)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == number)
                    {
                        return new []{row, col};
                    }
                }
            }

            return new[] {-1, -1};
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
