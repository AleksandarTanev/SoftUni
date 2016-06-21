﻿namespace _11.PoisonousPlants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var plants =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int[] days = new int[plants.Length];
            var proximityStack = new Stack<int>();

            proximityStack.Push(0);

            for (int i = 1; i < plants.Length; i++)
            {
                int maxDays = 0;
                while (proximityStack.Count > 0 && plants[proximityStack.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, days[proximityStack.Pop()]);
                }

                if (proximityStack.Count > 0)
                {
                    days[i] = maxDays + 1;
                }

                proximityStack.Push(i);
            }

            Console.WriteLine(days.Max());
        }
    }
}
