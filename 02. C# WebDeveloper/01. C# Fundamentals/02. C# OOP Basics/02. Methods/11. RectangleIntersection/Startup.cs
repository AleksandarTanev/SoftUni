namespace _11.RectangleIntersection
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var rectangles = new Dictionary<string, Rectangle>();

            string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(tokens[0]);
            int m = int.Parse(tokens[1]);

            for (int i = 0; i < n; i++)
            {
                tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string id = tokens[0];
                double width = double.Parse(tokens[1]);
                double height = double.Parse(tokens[2]);
                double x = double.Parse(tokens[3]);
                double y = double.Parse(tokens[4]);

                rectangles.Add(id, new Rectangle(id, width, height, x, y));
            }

            for (int i = 0; i < m; i++)
            {
                tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                bool isThereIntersection = Rectangle.RectIntersect(rectangles[tokens[0]], rectangles[tokens[1]]);
                Console.WriteLine(isThereIntersection.ToString().ToLower());
            }
        }
    }


}
