namespace CubeIntersection
{
    public class CubeBuilder
    {
        private Point center;
        private double edgeLength;

        public static CubeBuilder Cube()
        {
            return new CubeBuilder();
        }

        public CubeBuilder WithCenter(double x, double y, double z)
        {
            center = new Point(x, y, z);
            return this;
        }

        public CubeBuilder WithEdgeLength(double length)
        {
            edgeLength = length;
            return this;
        }

        public Cube Build()
        {
            return new Cube(center, edgeLength);
        }
    }
}
