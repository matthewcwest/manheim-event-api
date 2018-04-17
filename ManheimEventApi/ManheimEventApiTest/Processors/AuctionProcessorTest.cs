using System.Threading.Tasks;
using Xunit;
using Moq;
using ManheimEventApi.Processors;
using ManheimEventApi.Utilities;
using ManheimEventApiTest.Helpers;
using ManheimEventApi.DataAccess;
using ManheimEventApi.Models.Offerings;

namespace ManheimEventApiTest.Processors
{
    public class AuctionProcessorTest : TestBase<AuctionProcessor>
    {
        private Mock<ITransformHelper> TransformHelperMock { get; set; }

        private Mock<IGenericRepository<Offering>> GenericRepositoryMock { get; set; }

        public AuctionProcessorTest()
        {
            TransformHelperMock = new Mock<ITransformHelper>();

            GenericRepositoryMock = new Mock<IGenericRepository<Offering>>();

            InstantiateClassUnderTest(TransformHelperMock.Object, GenericRepositoryMock.Object);
        }

        [Fact]
        public async Task AuctionProcessor_ProcessOffering_WithOfferingEvent_GetsOfferingAndPassesToUnitOfWork()
        {
            var offeringEvent = EventHelper.GetOfferingEvent();
            var offering = EntityHelper.GetOffering();

            TransformHelperMock.Setup(x => x.Transform(offeringEvent)).Returns(offering).Verifiable();          

            await ClassUnderTest.ProcessOffering(offeringEvent);

            TransformHelperMock.Verify();
            GenericRepositoryMock.Verify(i => i.AddOrUpdate(offering), Times.Once);
            GenericRepositoryMock.Verify(i => i.SaveChangesAsync(), Times.Once);
        }
    }
}
