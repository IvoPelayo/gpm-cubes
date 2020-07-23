namespace GPM.Cubes.Domain.Entities
{
    public class Cube
    {
        public Vector Center { get; private set; } = new Vector(0, 0, 0);

        public double Dimension { get; private set; } = 1;

        public Cube()
        {
        }

        public Cube(Vector center, double size)
        {
            Center = center;
            Dimension = size;
        }

        public Cube(double x, double y, double z, double size)
        {
            Center = new Vector(x, y, z);
            Dimension = size;
        }

        public bool Collides(Cube cube)
        {
            throw new System.NotImplementedException();
        }

        public double Intersection(Cube cube)
        {
            throw new System.NotImplementedException();
        }
    }
}