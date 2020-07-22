using GPM.Cubes.Application.Contracts;
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
        public void If_Two_Cubes_Have_Same_Center_Then_Collide()
        {
            //ARRANGE

            //ACT

            //ASSERT
            Assert.IsTrue(true);
        }

        #endregion .: Test Methods :.
    }
}