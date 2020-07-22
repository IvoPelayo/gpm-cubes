using GPM.Cubes.Application.Contracts;
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
        public void If_Cubes_Are_Equal_Then_Return_Total_Volume()
        {
            //ARRANGE

            //ACT

            //ASSERT
            Assert.IsTrue(true);
        }

        #endregion .: Test Methods :.
    }
}