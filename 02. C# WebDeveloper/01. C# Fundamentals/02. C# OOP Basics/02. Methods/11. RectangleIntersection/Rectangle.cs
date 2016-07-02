namespace _11.RectangleIntersection
{
    public class Rectangle
    {
        public string id;

        public double width;
        public double height;

        public double x;
        public double y;

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public static bool RectIntersect(Rectangle a, Rectangle b)
        {
            if (a.x > b.x + b.width || a.y > b.y + b.height)
            {
                return false;
            }
            else if (a.x >= b.x && a.y >= b.y)
            {
                return true;
            }
            else if (a.x + a.width >= b.x && a.y + a.height >= b.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
