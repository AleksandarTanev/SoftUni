namespace _13.DrawingTool
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            IDrawable figure;

            if (input == "Square")
            {
                int a = int.Parse(Console.ReadLine());

                figure = new Square(a);
            }
            else
            {
                long a = long.Parse(Console.ReadLine());
                long b = long.Parse(Console.ReadLine());

                figure = new Rectangle(a, b);
            }

            var corDraw = new CorDraw(figure);
            corDraw.Draw();
        }
    }
}
