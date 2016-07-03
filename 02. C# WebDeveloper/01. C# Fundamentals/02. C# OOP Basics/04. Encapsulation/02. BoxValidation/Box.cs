namespace _02.BoxValidation
{
    using System;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get
            {
                return length;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative. ");
                }

                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative. ");
                }

                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative. ");
                }

                height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Volume()
        {
            double result = Length * Width * Height;

            return result;
        }

        public double LateralSurfaceArea()
        {
            double result = 2 * Length * Height + 2 * Width * Height;

            return result;
        }

        public double SurfaceArea()
        {
            double result = 2 * Length * Height + 2 * Width * Height + +2 * Width * Length;

            return result;
        }
    }
}
