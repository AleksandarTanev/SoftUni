namespace _05.SequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    class SequenceWithQueue
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            Queue<double>  queueOfNumbers = new Queue<double>();

            string result = n.ToString();

            queueOfNumbers.Enqueue(n);
            int count = 1;

            while (true)
            {
                double s = queueOfNumbers.Dequeue();

                queueOfNumbers.Enqueue(s + 1);
                count++;
                result += " " + (s + 1);
                if (count == 50)
                {
                    break;
                }

                queueOfNumbers.Enqueue((2 * s) + 1);
                count++;
                result += " " + ((2 * s) + 1);
                if (count == 50)
                {
                    break;
                }

                queueOfNumbers.Enqueue(s + 2);
                count++;
                result += " " + (s + 2);
                if (count == 50)
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}