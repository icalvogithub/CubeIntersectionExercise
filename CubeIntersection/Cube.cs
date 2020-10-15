namespace CubeIntersection
{
    public class Cube
    {
        private Edge width;
        private Edge height;
        private Edge depth;

        public Cube(Point center, double edgeLength)
        {
            width = new Edge(center.X, edgeLength);
            height = new Edge(center.Y, edgeLength);
            depth = new Edge(center.Z, edgeLength);
        }

        public double IntersectionVolumeWith(Cube cube) =>
                width.Overlap(cube.width)
                * height.Overlap(cube.height)
                * depth.Overlap(cube.depth);

        public bool CollidesWith(Cube cube) =>
                width.Collides(cube.width)
                || height.Collides(cube.height)
                || depth.Collides(cube.depth);
    }
}
