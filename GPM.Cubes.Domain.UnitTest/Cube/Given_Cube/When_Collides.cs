using GPM.Cubes.Domain.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPM.Cubes.Domain.UnitTest.Cube.Given_Cube
{
    [TestClass]
    public class When_Collides
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest"), TestCategory("Cube"), TestCategory("Collision")]
        public void If_Cubes_Have_Same_Center_Then_Collide()
        {
            //ARRANGE
            var cube = CubeFactory
                .Cube()
                .WithCenterCoordinates(0, 0, 0)
                .WithDimension(1)
                .Build();

            //ACT
            var result = cube.Collides(cube);

            //ASSERT
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("UnitTest"), TestCategory("Cube"), TestCategory("Collision")]
        public void If_Cubes_Are_Near_Then_Collide()
        {
            //ARRANGE
            var firstCube = CubeFactory
                .Cube()
                .WithCenterCoordinates(0, 0, 0)
                .WithDimension(3)
                .Build();

            var secondCube = CubeFactory
               .Cube()
               .WithCenterCoordinates(4, 0, 0)
               .WithDimension(3)
               .Build();

            //ACT
            var result = firstCube.Collides(secondCube);

            //ASSERT
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("UnitTest"), TestCategory("Cube"), TestCategory("Collision")]
        public void If_Cubes_Touch_Then_Collide()
        {
            //ARRANGE
            var firstCube = CubeFactory
                .Cube()
                .WithCenterCoordinates(0, 0, 0)
                .WithDimension(1)
                .Build();

            var secondCube = CubeFactory
               .Cube()
               .WithCenterCoordinates(2, 0, 0)
               .WithDimension(1)
               .Build();

            //ACT
            var result = firstCube.Collides(secondCube);

            //ASSERT
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("UnitTest"), TestCategory("Cube"), TestCategory("Collision")]
        public void If_Cubes_Almost_Touch_Then_Not_Collide()
        {
            //ARRANGE
            var firstCube = CubeFactory
                .Cube()
                .WithCenterCoordinates(0, 0, 0)
                .WithDimension(1)
                .Build();

            var secondCube = CubeFactory
               .Cube()
               .WithCenterCoordinates(2.001, 0, 0)
               .WithDimension(1)
               .Build();

            //ACT
            var result = firstCube.Collides(secondCube);

            //ASSERT
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("UnitTest"), TestCategory("Cube"), TestCategory("Collision")]
        public void Collision_Is_Mutual()
        {
            //ARRANGE
            var firstCube = CubeFactory
                .Cube()
                .WithCenterCoordinates(0, 0, 0)
                .WithDimension(1)
                .Build();

            var secondCube = CubeFactory
               .Cube()
               .WithCenterCoordinates(1, 0, 0)
               .WithDimension(2)
               .Build();

            //ACT
            var firstCubeCollision = firstCube.Collides(secondCube);
            var secondCubeCollision = secondCube.Collides(firstCube);

            //ASSERT
            Assert.IsTrue(firstCubeCollision);
            Assert.IsTrue(secondCubeCollision);
        }

        [TestMethod]
        [TestCategory("UnitTest"), TestCategory("Cube"), TestCategory("Collision")]
        public void Not_Collision_Is_Mutual()
        {
            //ARRANGE
            var firstCube = CubeFactory
                .Cube()
                .WithCenterCoordinates(0, 0, 0)
                .WithDimension(1)
                .Build();

            var secondCube = CubeFactory
               .Cube()
               .WithCenterCoordinates(3, 3, 3)
               .WithDimension(1)
               .Build();

            //ACT
            var firstCubeCollision = firstCube.Collides(secondCube);
            var secondCubeCollision = secondCube.Collides(firstCube);

            //ASSERT
            Assert.IsFalse(firstCubeCollision);
            Assert.IsFalse(secondCubeCollision);
        }
    }
}