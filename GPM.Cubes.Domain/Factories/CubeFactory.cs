using GPM.Cubes.Domain.Entities;

namespace GPM.Cubes.Domain.Factories
{
    public class CubeFactory
    {
        private Vector _center;
        private double _dimension;

        public static CubeFactory Cube()
        {
            return new CubeFactory();
        }

        public CubeFactory WithCenterCoordinates(double x, double y, double z)
        {
            _center = new Vector(x, y, z);
            return this;
        }

        public CubeFactory WithCenter(Vector center)
        {
            _center = center;
            return this;
        }

        public CubeFactory WithDimension(double size)
        {
            _dimension = size;
            return this;
        }

        public Cube Build()
        {
            return new Cube(_center, _dimension);
        }
    }
}