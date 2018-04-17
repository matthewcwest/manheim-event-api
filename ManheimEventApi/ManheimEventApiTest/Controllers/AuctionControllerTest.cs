using System.Web.Http.Results;
using ManheimEventApi.Controllers;
using Moq;
using Xunit;
using ManheimEventApi.Processors;
using ManheimEventApiTest.Helpers;

namespace ManheimEventApiTest.Controllers
{
    public class AuctionControllerTest : TestBase<AuctionController>
    {
        private Mock<IAuctionProcessor> AuctionProcessorMock { get; set; }

        public AuctionControllerTest()
        {
            AuctionProcessorMock = new Mock<IAuctionProcessor>();

            InstantiateClassUnderTest(AuctionProcessorMock.Object);
        }
        
        [Fact]
        public void AuctionController_CreateOffering_CallsAuctionProcessor()
        {
            var offering = EventHelper.GetOfferingEvent();

            var response = ClassUnderTest.Offering(offering).GetAwaiter().GetResult();

            AuctionProcessorMock.Verify(x => x.ProcessOffering(offering), Times.Once);
            Assert.IsType<OkResult>(response);
        }
    }
}
