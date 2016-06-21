namespace _20.TheHeiganDance
{
    using System;

    class Startup
    {
        private static int playerRow = 7;
        private static int playerCol = 7;

        static void Main()
        {
            var matrix = new string[15, 15];

            double bossHP = 3000000;
            double playerHP = 18500;

            double damageToBossPerTurn = double.Parse(Console.ReadLine());

            bool cloudHit = false;
            string playerKilledBy = "";
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                bossHP -= damageToBossPerTurn;

                if (cloudHit)
                {
                    playerHP -= 3500;
                    if (playerHP <= 0)
                    {
                        playerKilledBy = "Plague Cloud";
                        break;
                    }
                    cloudHit = false;
                }

                if (bossHP <= 0)
                {
                    break;
                }

                string spell = input[0];
                int rowHit = int.Parse(input[1]);
                int rowCol = int.Parse(input[2]);

                ClearMatrix(matrix);
                MarkHitAreaInMatrix(matrix, rowHit, rowCol);

                //PrintMatrix(matrix);
                //Console.WriteLine();
                CheckAndMovePlayer(matrix);
                //PrintMatrix(matrix);
                //Console.WriteLine();
                if (matrix[playerRow, playerCol] == ".")
                {
                    if (spell == "Eruption")
                    {
                        playerHP -= 6000;
                        if (playerHP <= 0)
                        {
                            playerKilledBy = "Eruption";
                            break;
                        }
                    }
                    else if (spell == "Cloud")
                    {
                        playerHP -= 3500;
                        if (playerHP <= 0)
                        {
                            playerKilledBy = "Plague Cloud";
                            break;
                        }
                        cloudHit = true;
                    }
                }
            }

            if (bossHP <= 0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine("Heigan: {0:F2}", bossHP);
            }

            if (playerHP <= 0)
            {
                Console.WriteLine($"Player: Killed by {playerKilledBy}");
            }
            else
            {
                Console.WriteLine($"Player: {playerHP}");
            }

            Console.WriteLine($"Final position: {playerRow}, {playerCol}");
        }

        private static void CheckAndMovePlayer(string[,] matrix)
        {
            int matrixRows = matrix.GetLength(0);
            int matrixCols = matrix.GetLength(1);

            if (matrix[playerRow, playerCol] == ".")
            {
                if (playerRow - 1 >= 0 && matrix[playerRow - 1, playerCol] != ".")
                {
                    playerRow -= 1;
                }
                else if (playerCol + 1 < matrixCols && matrix[playerRow, playerCol + 1] != ".")
                {
                    playerCol += 1;
                }
                else if (playerRow + 1 < matrixRows && matrix[playerRow + 1, playerCol] != ".")
                {
                    playerRow += 1;
                }
                else if (playerCol - 1 >= 0 && matrix[playerRow, playerCol - 1] != ".")
                {
                    playerCol -= 1;
                }
            }
        }

        private static void MarkHitAreaInMatrix(string[,] matrix, int rowHit, int colHit)
        {
            int matrixRows = matrix.GetLength(0);
            int matrixCols = matrix.GetLength(1);

            if (rowHit >= 0 && rowHit < matrixRows)
            {
                if (colHit >= 0 && colHit < matrixCols)
                {
                    matrix[rowHit, colHit] = ".";
                }

                if (colHit - 1 >= 0 && colHit - 1 < matrixCols)
                {
                    matrix[rowHit, colHit - 1] = ".";
                }

                if (colHit + 1 >= 0 && colHit + 1 < matrixCols)
                {
                    matrix[rowHit, colHit + 1] = ".";
                }
            }

            if (rowHit - 1 >= 0 && rowHit - 1 < matrixRows)
            {
                if (colHit >= 0 && colHit < matrixCols)
                {
                    matrix[rowHit - 1, colHit] = ".";
                }

                if (colHit - 1 >= 0 && colHit - 1 < matrixCols)
                {
                    matrix[rowHit - 1, colHit - 1] = ".";
                }

                if (colHit + 1 >= 0 && colHit + 1 < matrixCols)
                {
                    matrix[rowHit - 1, colHit + 1] = ".";
                }
            }

            if (rowHit + 1 < matrixRows && rowHit + 1 >= 0)
            {
                if (colHit >= 0 && colHit < matrixCols)
                {
                    matrix[rowHit + 1, colHit] = ".";
                }

                if (colHit - 1 >= 0 && colHit - 1 < matrixCols)
                {
                    matrix[rowHit + 1, colHit - 1] = ".";
                }

                if (colHit + 1 >= 0 && colHit + 1 < matrixCols)
                {
                    matrix[rowHit + 1, colHit + 1] = ".";
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == playerRow && col == playerCol)
                    {
                        Console.Write("P" + " ");
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }

                }
                Console.WriteLine();
            }
        }

        private static void ClearMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = "S";
                }
            }
        }

    }
}
