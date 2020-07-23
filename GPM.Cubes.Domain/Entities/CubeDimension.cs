using System;

namespace GPM.Cubes.Domain.Entities
{
    public class CubeDimension
    {
        private double start;
        private double end;

        public CubeDimension(double center, double length)
        {
            start = center - length / 2;
            end = center + length / 2;
        }

        public bool Collides(CubeDimension cubeAxis) =>
            Difference(cubeAxis) >= 0;

        public double Difference(CubeDimension cubeAxis) =>
            Math.Max(0, Math.Min(end, cubeAxis.end) - Math.Max(start, cubeAxis.start));
    }
}