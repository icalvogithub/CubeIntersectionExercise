using System.Collections.Generic;
using Xunit;
using CubeIntersection;
using FluentAssertions;

namespace CubeIntersectionTest
{
    public class CubeIntersectionVolumeCalculationTest
    {        
        [Theory]
        [MemberData(nameof(GetCubesData))]
        public void IntersectionVolumeWith_IntersectingCubes_ReturnsCorrectCalculation(
            double xA, double yA, double zA, double lengthA,
            double xB, double yB, double zB, double lengthB,
            double expectedVolumeCalculation)
        {
            var cubeA = CubeBuilder.Cube().WithCenter(xA, yA, zA).WithEdgeLength(lengthA).Build();
            var cubeB = CubeBuilder.Cube().WithCenter(xB, yB, zB).WithEdgeLength(lengthB).Build();

            cubeA.IntersectionVolumeWith(cubeB).Should().Be(expectedVolumeCalculation);
        }

        public static IEnumerable<object[]> GetCubesData()
        {
            return new List<object[]>() 
            {
                new object[] { 0, 0, 0, 2, 3, 3, 3, 2, 0 }, // Not touching and not intersecting cubes
                new object[] { 0, 0, 0, 2, 2, 0, 0, 2, 0 }, // Touching and not intersecting cubes
                new object[] { 0, 0, 0, 2, 0, 0, 1, 2, 4 }, // Cubes with same width and height
                new object[] { 0, 0, 0, 2, 0, 1, 0, 2, 4 }, // Cubes with same width and depth
                new object[] { 0, 0, 0, 2, 1, 0, 0, 2, 4 }, // Cubes with same height and depth
                new object[] { 0, 0, 0, 2, 0, 0, 0, 2, 8 }, // Cubes completely overlapped
                new object[] { 0, 0, 0, 2, 0, 0, 0, 1, 1 }, // Cube contains Cube

            };
        }
    }
}
