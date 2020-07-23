using GPM.Cubes.Application.Contracts;
using GPM.Cubes.Application.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPM.Cubes.IntegrationTest.Cubes.Given_CubesAppService
{
    [TestClass]
    public class When_Get_Intersection
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
        [TestCategory("IntegrationTest"), TestCategory("CubeAppService"), TestCategory("Intersection")]
        public void If_Cubes_Have_Same_Center_Then_Intersection_Equals_Smaller_Cube_Volume()
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
                X = 0,
                Y = 0,
                Z = 0,
                Dimension = 2,
            };

            //ACT
            var result = _cubesAppService.GetIntersection(firstCube, secondCube);

            //ASSERT
            Assert.AreEqual(firstCube, result); // TODO: VolumeCalculator
            Assert.AreNotEqual(secondCube, result);
        }

        [TestMethod]
        [TestCategory("IntegrationTest"), TestCategory("CubeAppService"), TestCategory("Intersection")]
        public void If_Cubes_Are_Equal_Then_Intersection_Is_Equal_To_Volume()
        {
            //ARRANGE
            var cube = new CubeCoordinates
            {
                X = 0,
                Y = 0,
                Z = 0,
                Dimension = 3,
            };

            //ACT
            var result = _cubesAppService.HaveCollision(cube, cube);

            //ASSERT
            Assert.AreEqual(cube, result); // TODO: VolumeCalculator
        }

        [TestMethod]
        [TestCategory("IntegrationTest"), TestCategory("CubeAppService"), TestCategory("Intersection")]
        public void If_Cubes_Only_Touch_Then_Intersection_Is_Zero()
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
            var result = _cubesAppService.GetIntersection(firstCube, secondCube);

            //ASSERT
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [TestCategory("IntegrationTest"), TestCategory("CubeAppService"), TestCategory("Intersection")]
        public void If_Cubes_Dont_Touch_Then_Volume_Is_Zero()
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
                X = 4,
                Y = 0,
                Z = 0,
                Dimension = 1,
            };

            //ACT
            var result = _cubesAppService.GetIntersection(firstCube, secondCube);

            //ASSERT
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [TestCategory("IntegrationTest"), TestCategory("CubeAppService"), TestCategory("Intersection")]
        public void Intersection_Is_Mutual()
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
            var firstCubeIntersection = _cubesAppService.GetIntersection(firstCube, secondCube);
            var secondCubeIntersection = _cubesAppService.GetIntersection(firstCube, secondCube);

            //ASSERT
            Assert.AreEqual(firstCubeIntersection, secondCubeIntersection);
        }

        #endregion .: Test Methods :.
    }
}