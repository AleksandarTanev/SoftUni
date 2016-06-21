namespace _21.ParkingSystem
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {
            var parking = new Dictionary<int, HashSet<int>>();

            int[] matrixParams = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int totalRows = matrixParams[0];
            int totalCols = matrixParams[1];

            var input = Console.ReadLine();
            while (input != "stop")
            {
                var inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int entryRow = int.Parse(inputArray[0]);
                int targetRow = int.Parse(inputArray[1]);
                int targetCol = int.Parse(inputArray[2]);

                if (!IsPlaceOccupied(parking, targetRow, targetCol))
                {
                    OccupyPlace(parking, targetRow, targetCol);
                    int distance = Math.Abs(entryRow - targetRow);
                    distance += targetCol + 1;
                    Console.WriteLine(distance);
                }
                else
                {
                    targetCol = TryFindEmptySpace(parking[targetRow], totalCols, targetCol);

                    if (targetCol == 0)
                    {
                        Console.WriteLine($"Row {targetRow} full");
                    }
                    else
                    {
                        OccupyPlace(parking, targetRow, targetCol);
                        int distance = Math.Abs(entryRow - targetRow);
                        distance += targetCol + 1;
                        Console.WriteLine(distance);
                    }

                }

                input = Console.ReadLine();
            }

            
        }

        private static int TryFindEmptySpace(HashSet<int> hashSet, int totalNumberOfCols, int targetCol)
        {
            int targetColIndex = 0;
            int minDistance = int.MaxValue;

            if (hashSet.Count == totalNumberOfCols - 1)
            {
                return targetColIndex;
            }
            else
            {
                for (int i = 1; i < totalNumberOfCols; i++)
                {
                    int currentDistance = Math.Abs(targetCol - i);
                    if (!hashSet.Contains(i) && currentDistance < minDistance)
                    {
                        targetColIndex = i;
                        minDistance = currentDistance;
                    }
                }

                return targetColIndex;
            }
        }

        private static bool IsPlaceOccupied(Dictionary<int, HashSet<int>> parking, int targetRow, int targetCol)
        {
            return parking.ContainsKey(targetRow) && parking[targetRow].Contains(targetCol);
        }

        private static void OccupyPlace(Dictionary<int, HashSet<int>> parking, int targetRow, int targetCol)
        {
            if (!parking.ContainsKey(targetRow))
            {
                parking[targetRow] = new HashSet<int>();
            }

            parking[targetRow].Add(targetCol);
        }
    }
}
