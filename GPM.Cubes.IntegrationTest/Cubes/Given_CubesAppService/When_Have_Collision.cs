using GPM.Cubes.Application.Contracts;
using GPM.Cubes.Application.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPM.Cubes.IntegrationTest.Cubes.Given_CubesAppService
{
    [TestClass]
    public class When_Have_Collision
    {
        #region .: Properties :.

        private ICubeAppService _cubesAppService;

        #endregion .: Properties :.

        #region .: Given Scenario :.

        [TestInitialize]
        public void Init()
        {
            var config = new TestConfigurator();
            _cubesAppService = config.GetInstance<ICubeAppService>();
        }

        #endregion .: Given Scenario :.

        #region .: Test Methods :.

        [TestMethod]
        [TestCategory("IntegrationTest"), TestCategory("CubeAppService"), TestCategory("Collision")]
        public void If_Cubes_Have_Same_Center_Then_Collide()
        {
            //ARRANGE
            var cube = new CubeCoordinates
            {
                X = 0,
                Y = 0,
                Z = 0,
                Dimension = 1,
            };

            //ACT
            var result = _cubesAppService.HaveCollision(cube, cube);

            //ASSERT
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("IntegrationTest"), TestCategory("CubeAppService"), TestCategory("Collision")]
        public void If_Cubes_Are_Near_Then_Collide()
        {
            //ARRANGE
            var firstCube = new CubeCoordinates
            {
                X = 0,
                Y = 0,
                Z = 0,
                Dimension = 3,
            };

            var secondCube = new CubeCoordinates
            {
                X = 4,
                Y = 0,
                Z = 0,
                Dimension = 3,
            };

            //ACT
            var result = _cubesAppService.HaveCollision(firstCube, secondCube);

            //ASSERT
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("IntegrationTest"), TestCategory("CubeAppService"), TestCategory("Collision")]
        public void If_Cubes_Touch_Then_Collide()
        {
            //ARRANGE
            var firstCube = new CubeCoordinates
            {
                X = 0,
                Y = 0,
                Z = 0,
                Dimension = 1,
            };

            var secondCube = new CubeCoordinates
            {
                X = 2,
                Y = 0,
                Z = 0,
                Dimension = 1,
            };

            //ACT
            var result = _cubesAppService.HaveCollision(firstCube, secondCube);

            //ASSERT
            Assert.IsTrue(result);
        }

        [TestMethod]
        [TestCategory("IntegrationTest"), TestCategory("CubeAppService"), TestCategory("Collision")]
        public void If_Cubes_Almost_Touch_Then_Not_Collide()
        {
            //ARRANGE
            var firstCube = new CubeCoordinates
            {
                X = 0,
                Y = 0,
                Z = 0,
                Dimension = 1,
            };

            var secondCube = new CubeCoordinates
            {
                X = 2.001,
                Y = 0,
                Z = 0,
                Dimension = 1,
            };

            //ACT
            var result = _cubesAppService.HaveCollision(firstCube, secondCube);

            //ASSERT
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("IntegrationTest"), TestCategory("CubeAppService"), TestCategory("Collision")]
        public void Collision_Is_Mutual()
        {
            //ARRANGE
            var firstCube = new CubeCoordinates
            {
                X = 0,
                Y = 0,
                Z = 0,
                Dimension = 1,
            };

            var secondCube = new CubeCoordinates
            {
                X = 1,
                Y = 0,
                Z = 0,
                Dimension = 2,
            };

            //ACT
            var firstCubeCollision = _cubesAppService.HaveCollision(firstCube, secondCube);
            var secondCubeCollision = _cubesAppService.HaveCollision(firstCube, secondCube);

            //ASSERT
            Assert.IsTrue(firstCubeCollision);
            Assert.IsTrue(secondCubeCollision);
        }

        [TestMethod]
        [TestCategory("IntegrationTest"), TestCategory("CubeAppService"), TestCategory("Collision")]
        public void Not_Collision_Is_Mutual()
        {
            //ARRANGE
            var firstCube = new CubeCoordinates
            {
                X = 0,
                Y = 0,
                Z = 0,
                Dimension = 1,
            };

            var secondCube = new CubeCoordinates
            {
                X = 3,
                Y = 3,
                Z = 3,
                Dimension = 1,
            };

            //ACT
            var firstCubeCollision = _cubesAppService.HaveCollision(firstCube, secondCube);
            var secondCubeCollision = _cubesAppService.HaveCollision(firstCube, secondCube);

            //ASSERT
            Assert.IsFalse(firstCubeCollision);
            Assert.IsFalse(secondCubeCollision);
        }

        #endregion .: Test Methods :.
    }
}