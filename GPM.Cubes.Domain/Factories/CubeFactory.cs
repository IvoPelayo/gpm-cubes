using GPM.Cubes.Domain.Entities;

namespace GPM.Cubes.Domain.Factories
{
    public class CubeFactory
    {
        private Vector _center;
        private float _dimension;

        public static CubeFactory Cube()
        {
            return new CubeFactory();
        }

        public CubeFactory WithCenterCoordinates(float x, float y, float z)
        {
            _center = new Vector(x, y, z);
            return this;
        }

        public CubeFactory WithCenter(Vector center)
        {
            _center = center;
            return this;
        }

        public CubeFactory WithDimension(float size)
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