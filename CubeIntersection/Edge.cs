using System;

namespace CubeIntersection
{
    public class Edge
    {
        private double start;
        private double end;

        public Edge(double center, double length)
        {
            start = center - length / 2.0;
            end = center + length / 2.0;
        }

        public double Overlap(Edge edge) =>
            Math.Max(0, Difference(edge));

        public bool Collides(Edge edge) =>
            Difference(edge) >= 0;

        private double Difference(Edge edge) =>
            Math.Min(end, edge.end) - Math.Max(start, edge.start);
    }
}
