namespace _06.TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TruckTour
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<PetrolPump> petrolPumps = new Queue<PetrolPump>();

            for (int i = 0; i < n; i++)
            {
                long[] input = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                petrolPumps.Enqueue(new PetrolPump() {AmountOfPetrol = input [0], DistanceToNextPumn = input[1]});
            }

            int index = 0;
            while (index < petrolPumps.Count)
            {
                long currentPetrolAmount = 0;
                bool circledAll = true;

                for (int i = 0; i < petrolPumps.Count; i++)
                {
                    var currentPump = petrolPumps.Dequeue();
                    petrolPumps.Enqueue(currentPump);

                    currentPetrolAmount += currentPump.AmountOfPetrol;
                    currentPetrolAmount -= currentPump.DistanceToNextPumn;

                    if (currentPetrolAmount < 0)
                    {
                        circledAll = false;
                    }
                }

                if (circledAll)
                {
                    break;
                }

                petrolPumps.Enqueue(petrolPumps.Dequeue());

                index++;
            }

            Console.WriteLine(index);
        }
    }
}