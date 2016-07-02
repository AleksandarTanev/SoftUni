namespace _08.ShapesVolume
{
    using System;

    public class VolumeCalculator
    {
        public static double CalculateVolume(TriangularPrism figure)
        {
            return 0.5 * figure.baseSide * figure.heightFromBaseSide * figure.length;
        }

        public static double CalculateVolume(Cube figure)
        {
            return figure.sideLength * figure.sideLength * figure.sideLength;
        }

        public static double CalculateVolume(Cylinder figure)
        {
            return figure.radius * figure.radius * Math.PI * figure.height;
        }
    }
}
