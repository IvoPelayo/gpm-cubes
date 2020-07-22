namespace GPM.Cubes.Domain.Entities
{
    public class Cube
    {
        public Vector Center { get; private set; } = new Vector(0, 0, 0);

        public float Dimension { get; private set; } = 1;

        public Cube()
        {
        }

        public Cube(Vector center, float size)
        {
            Center = center;
            Dimension = size;
        }

        public Cube(float x, float y, float z, float size)
        {
            Center = new Vector(x, y, z);
            Dimension = size;
        }
    }
}