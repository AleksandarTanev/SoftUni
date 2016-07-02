
namespace _13.DrawingTool
{
    using System;

    public class Rectangle : IDrawable
    {
        public long a;
        public long b;

        public Rectangle(long a, long b)
        {
            this.a = a;
            this.b = b;
        }

        public void Draw()
        {
            for (int i = 0; i < b; i++)
            {
                string line = "|";
                for (int j = 0; j < a; j++)
                {
                    if (i != 0 && i != b - 1)
                    {
                        line += " ";
                    }
                    else
                    {
                        line += "-";
                    }

                }
                line += "|";

                Console.WriteLine(line);
            }
        }
    }
}
