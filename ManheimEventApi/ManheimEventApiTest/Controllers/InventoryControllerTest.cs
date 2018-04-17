using System.Web.Http.Results;
using ManheimEventApi.Controllers;
using Xunit;
using Moq;
using ManheimEventApi.Processors;
using ManheimEventApiTest.Helpers;

namespace ManheimEventApiTest.Controllers
{
    public class InventoryControllerTest : TestBase<InventoryController>
    {
        private Mock<IInventoryProcessor> InventoryProcessorMock { get; set; }

        public InventoryControllerTest()
        {
            InventoryProcessorMock = new Mock<IInventoryProcessor>();

            InstantiateClassUnderTest(InventoryProcessorMock.Object);
        }

        [Fact]
        public void InventoryController_Create_CallsInventoryProcessorAndReturnsOkResult()
        {         
            var unit = EventHelper.GetUnitEvent();

            var response = ClassUnderTest.Unit(unit).GetAwaiter().GetResult();

            InventoryProcessorMock.Verify(x => x.ProcessUnit(unit), Times.Once);
            Assert.IsType<OkResult>(response);
        }
    }
}
