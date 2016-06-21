namespace _18.RadioBunnies
{
    using System;


    class Startup
    {
        public static string[,] lair;
        public static int playerStatus = 0; // 0 - alive and in the lair; 1 - alive and out side of the lair; 2 - dead
        public static int playerRow;
        public static int playerCol;

        public static int playerLastRow;
        public static int playerLastCol;

        static void Main()
        {
            int[] matrixParams = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int matrixRows = matrixParams[0];
            int matrixCols = matrixParams[1];

            lair = new string[matrixRows, matrixCols];

            string inputRow;
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                inputRow = Console.ReadLine();

                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    lair[row, col] = inputRow[col].ToString();

                    if (lair[row, col] == "P")
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            playerLastRow = playerRow;
            playerLastCol = playerCol;

            string commands = Console.ReadLine();



            for (int i = 0; i < commands.Length; i++)
            {
                if (playerStatus == 0)
                {
                    MovePlayer(commands[i]);
                }

                if (playerStatus != 2)
                {
                    SpreadBunnies();
                    if (playerStatus == 2)
                    {
                        playerLastRow = playerRow;
                        playerLastCol = playerCol;
                    }
                }
                else
                {
                    SpreadBunnies();
                }

                if (playerStatus == 1 || playerStatus == 2)
                {
                    break;
                }
            }


            PrintLair();
            PrintPlayerCoordinates();


        }


        static void MovePlayer(char command)
        {
            lair[playerRow, playerCol] = ".";
            int playerNewRow = playerRow;
            int playerNewCol = playerCol;

            if (command == 'U')
            {
                playerNewRow = playerNewRow - 1;
                if (playerNewRow < 0)
                {
                    playerStatus = 1;
                    playerLastRow = playerRow;
                    playerLastCol = playerCol;
                    return;
                }
            }
            else if (command == 'D')
            {
                playerNewRow = playerNewRow + 1;
                if (playerNewRow >= lair.GetLength(0))
                {
                    playerStatus = 1;
                    playerLastRow = playerRow;
                    playerLastCol = playerCol;
                    return;
                }
            }
            else if (command == 'L')
            {
                playerNewCol = playerNewCol - 1;
                if (playerNewCol < 0)
                {
                    playerStatus = 1;
                    playerLastRow = playerRow;
                    playerLastCol = playerCol;
                    return;
                }

            }
            else if (command == 'R')
            {
                playerNewCol = playerNewCol + 1;
                if (playerNewCol >= lair.GetLength(1))
                {
                    playerStatus = 1;
                    playerLastRow = playerRow;
                    playerLastCol = playerCol;
                    return;
                }
            }

            string lairNewPositionStatus = lair[playerNewRow, playerNewCol];

            if (lairNewPositionStatus == "B")
            {
                playerStatus = 2;
                playerLastRow = playerNewRow;
                playerLastCol = playerNewCol;
                return;
            }

            lair[playerNewRow, playerNewCol] = "P";
            playerRow = playerNewRow;
            playerCol = playerNewCol;

        }

        static void PrintLair()
        {
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    Console.Write(lair[row, col]);
                }
                Console.WriteLine();
            }
        }

        static void PrintPlayerCoordinates()
        {
            if (playerStatus == 2)
            {
                Console.WriteLine("dead: {0} {1}", playerLastRow, playerLastCol);
            }
            else
            {
                Console.WriteLine("won: {0} {1}", playerLastRow, playerLastCol);
            }

        }

        static void SpreadBunnies()
        {

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (lair[row, col] == "B")
                    {
                        SpreadOneBunny(row, col);
                    }
                }
            }

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (lair[row, col] == "V")
                    {
                        lair[row, col] = "B";
                    }
                }
            }


        }

        // V - about to become a bunny
        static void SpreadOneBunny(int row, int col)
        {
            int newRow;
            int newCol;

            // row - 1
            newRow = row - 1;
            if (newRow >= 0)
            {
                if (lair[newRow, col] == ".")
                {
                    lair[newRow, col] = "V";
                }
                else if (lair[newRow, col] == "P")
                {
                    if (playerStatus == 0)
                    {
                        playerStatus = 2;
                    }
                    lair[newRow, col] = "V";
                }
            }

            // row + 1
            newRow = row + 1;
            if (newRow < lair.GetLength(0))
            {
                if (lair[newRow, col] == ".")
                {
                    lair[newRow, col] = "V";
                }
                else if (lair[newRow, col] == "P")
                {
                    if (playerStatus == 0)
                    {
                        playerStatus = 2;
                    }
                    lair[newRow, col] = "V";
                }
            }

            // col - 1
            newCol = col - 1;
            if (newCol >= 0)
            {
                if (lair[row, newCol] == ".")
                {
                    lair[row, newCol] = "V";
                }
                else if (lair[row, newCol] == "P")
                {
                    if (playerStatus == 0)
                    {
                        playerStatus = 2;
                    }
                    lair[row, newCol] = "V";
                }
            }

            // col + 1
            newCol = col + 1;
            if (newCol < lair.GetLength(1))
            {
                if (lair[row, newCol] == ".")
                {
                    lair[row, newCol] = "V";
                }
                else if (lair[row, newCol] == "P")
                {
                    if (playerStatus == 0)
                    {
                        playerStatus = 2;
                    }
                    lair[row, newCol] = "V";
                }
            }
        }
    }
}
