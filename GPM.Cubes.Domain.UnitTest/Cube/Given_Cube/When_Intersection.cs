using GPM.Cubes.Domain.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GPM.Cubes.Domain.UnitTest.Cube.Given_Cube
{
    [TestClass]
    public class When_Intersection
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest"), TestCategory("Cube"), TestCategory("Intersection")]
        public void If_Cubes_Have_Same_Center_Then_Intersection_Equals_Smaller_Cube_Volume()
        {
            //ARRANGE
            var firstCube = CubeFactory
                .Cube()
                .WithCenterCoordinates(0, 0, 0)
                .WithDimension(1)
                .Build();

            var secondCube = CubeFactory
                .Cube()
                .WithCenterCoordinates(0, 0, 0)
                .WithDimension(2)
                .Build();

            //ACT
            var result = firstCube.Intersection(secondCube);

            //ASSERT
            Assert.AreEqual(GetCubeVolume(firstCube), result);
            Assert.AreNotEqual(GetCubeVolume(secondCube), result);
        }

        [TestMethod]
        [TestCategory("UnitTest"), TestCategory("Cube"), TestCategory("Intersection")]
        public void If_Cubes_Are_Equal_Then_Intersection_Is_Equal_To_Volume()
        {
            var cube = CubeFactory
               .Cube()
               .WithCenterCoordinates(0, 0, 0)
               .WithDimension(1)
               .Build();

            //ACT
            var result = cube.Intersection(cube);

            //ASSERT
            Assert.AreEqual(GetCubeVolume(cube), result);
        }

        [TestMethod]
        [TestCategory("UnitTest"), TestCategory("Cube"), TestCategory("Intersection")]
        public void If_Cubes_Only_Touch_Then_Intersection_Is_Zero()
        {
            var firstCube = CubeFactory
               .Cube()
               .WithCenterCoordinates(0, 0, 0)
               .WithDimension(1)
               .Build();

            var secondCube = CubeFactory
                .Cube()
                .WithCenterCoordinates(1, 0, 0)
                .WithDimension(1)
                .Build();

            //ACT
            var result = firstCube.Intersection(secondCube);

            //ASSERT
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [TestCategory("UnitTest"), TestCategory("Cube"), TestCategory("Intersection")]
        public void If_Cubes_Dont_Touch_Then_Volume_Is_Zero()
        {
            var firstCube = CubeFactory
              .Cube()
              .WithCenterCoordinates(0, 0, 0)
              .WithDimension(1)
              .Build();

            var secondCube = CubeFactory
                .Cube()
                .WithCenterCoordinates(4, 0, 0)
                .WithDimension(1)
                .Build();

            //ACT
            var result = firstCube.Intersection(secondCube);

            //ASSERT
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [TestCategory("UnitTest"), TestCategory("Cube"), TestCategory("Intersection")]
        public void Intersection_Is_Mutual()
        {
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
            var firstCubeIntersection = firstCube.Intersection(secondCube);
            var secondCubeIntersection = secondCube.Intersection(firstCube);

            //ASSERT
            Assert.AreEqual(firstCubeIntersection, secondCubeIntersection);
        }

        private double GetCubeVolume(Entities.Cube cube)
        {
            return Math.Pow(cube.Dimension, 3);
        }
    }
}