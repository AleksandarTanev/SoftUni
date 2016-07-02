namespace _13.DrawingTool
{
    public class CorDraw
    {
        private IDrawable figure;

        public CorDraw(IDrawable figure)
        {
            this.figure = figure;
        }

        public void Draw()
        {
            this.figure.Draw();
        }
    }
}
