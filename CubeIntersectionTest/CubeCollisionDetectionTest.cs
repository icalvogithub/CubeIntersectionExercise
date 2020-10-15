using Xunit;
using CubeIntersection;
using FluentAssertions;

namespace CubeIntersectionTest
{
    public class CubeCollisionDetectionTest
    {
        [Fact]
        public void CollidesWith_NotCollidingCubes_ReturnsFalse()
        {
            var cubeA = CubeBuilder.Cube().WithCenter(0, 0, 0).WithEdgeLength(2).Build();
            var cubeB = CubeBuilder.Cube().WithCenter(3, 3, 3).WithEdgeLength(2).Build();

            cubeA.CollidesWith(cubeB).Should().BeFalse();
        }

        [Fact]
        public void CollidesWith_TouchingCubes_ReturnsTrue()
        {
            var cubeA = CubeBuilder.Cube().WithCenter(0, 0, 0).WithEdgeLength(2).Build();
            var cubeB = CubeBuilder.Cube().WithCenter(2, 0, 0).WithEdgeLength(2).Build();

            cubeA.CollidesWith(cubeB).Should().BeTrue();
        }

        [Fact]
        public void CollidesWith_CollidingCubes_ReturnsTrue()
        {
            var cubeA = CubeBuilder.Cube().WithCenter(0, 0, 0).WithEdgeLength(2).Build();
            var cubeB = CubeBuilder.Cube().WithCenter(1, 0, 0).WithEdgeLength(2).Build();

            cubeA.CollidesWith(cubeB).Should().BeTrue();
        }
    }
}
