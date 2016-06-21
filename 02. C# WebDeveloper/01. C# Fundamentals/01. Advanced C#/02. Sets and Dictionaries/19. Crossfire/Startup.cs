namespace _19.Crossfire
{
    using System;

    class Startup
    {
        static void Main()
        {
            var matrixLength = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var rows = int.Parse(matrixLength[0]);
            var cols = int.Parse(matrixLength[1]);

            var matrix = new string[rows, cols];

            int count = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = count.ToString();
                    count++;
                }
            }

            string input = Console.ReadLine();
            int lastFilledRow = rows - 1;
            while (input != "Nuke it from orbit")
            {
                var shotParameters = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int impactRow = int.Parse(shotParameters[0]);
                int impactCol = int.Parse(shotParameters[1]);
                int impactRadius = int.Parse(shotParameters[2]);
                /*
                if (impactRow < 0 || impactRow >= rows)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (impactCol < 0 || impactCol >= cols)
                {
                    input = Console.ReadLine();
                    continue;
                }*/

                if (impactRow >= 0 && impactRow < rows)
                {
                    for (int col = 0; col <= impactRadius; col++)
                    {
                        if (impactCol + col < cols && impactCol + col >= 0)
                        {
                            matrix[impactRow, impactCol + col] = " ";
                        }

                        if (impactCol - col >= 0 && impactCol - col < cols)
                        {
                            matrix[impactRow, impactCol - col] = " ";
                        }
                    }
                }

                if (impactCol >= 0 && impactCol < cols)
                {
                    for (int row = 0; row <= impactRadius; row++)
                    {
                        if (impactRow + row < rows && impactRow + row >= 0)
                        {


                            matrix[impactRow + row, impactCol] = " ";
                        }

                        if (impactRow - row < rows && impactRow - row >= 0)
                        {
                            matrix[impactRow - row, impactCol] = " ";
                        }
                    }
                }

                bool thereIsChange = true;
                while (thereIsChange)
                {
                    thereIsChange = false;

                    for (int col = matrix.GetLength(1) - 1; col >=  1; col--)
                    {
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            if (matrix[row, col] != " " && matrix[row, col - 1] == " ")
                            {
                                matrix[row, col - 1] = matrix[row, col];
                                matrix[row, col] = " ";
                                thereIsChange = true;
                            }
                        }
                    }
                }
                
                thereIsChange = true;
                while (thereIsChange)
                {
                    thereIsChange = false;

                    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                    {
                        if (matrix[row, 0] == " " && matrix[row + 1, 0] != " ")
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                matrix[row, col] = matrix[row + 1, col];
                                matrix[row + 1, col] = " ";
                            }
                            thereIsChange = true;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(string[,] matrix)
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