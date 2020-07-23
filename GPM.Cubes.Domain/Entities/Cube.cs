namespace GPM.Cubes.Domain.Entities
{
    public class Cube
    {
        public Vector Center { get; private set; } = new Vector(0, 0, 0);

        public double Dimension { get; private set; } = 1;

        public CubeDimension _XAxis { get; private set; }
        public CubeDimension _YAxis { get; private set; }
        public CubeDimension _ZAxis { get; private set; }

        private void SetCubeDimensions()
        {
            _XAxis = new CubeDimension(Center.X, Dimension);
            _YAxis = new CubeDimension(Center.Y, Dimension);
            _ZAxis = new CubeDimension(Center.Z, Dimension);
        }

        public Cube()
        {
            SetCubeDimensions();
        }

        public Cube(Vector center, double size)
        {
            Center = center;
            Dimension = size;

            SetCubeDimensions();
        }

        public Cube(double x, double y, double z, double size)
        {
            Center = new Vector(x, y, z);
            Dimension = size;

            SetCubeDimensions();
        }

        public bool Collides(Cube cube) => Intersection(cube) > 0;

        public double Intersection(Cube cube)
        {
            return _XAxis.Difference(cube._XAxis) *
                   _YAxis.Difference(cube._YAxis) *
                   _ZAxis.Difference(cube._ZAxis);
        }
    }
}