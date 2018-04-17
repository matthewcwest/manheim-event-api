using System.Threading.Tasks;
using Xunit;
using Moq;
using ManheimEventApi.Processors;
using ManheimEventApi.Utilities;
using ManheimEventApiTest.Helpers;
using ManheimEventApi.DataAccess;
using ManheimEventApi.Models.Units;

namespace ManheimEventApiTest.Processors
{
    public class InventoryProcessorTest : TestBase<InventoryProcessor>
    {
        private Mock<ITransformHelper> TransformHelperMock { get; set; }

        private Mock<IGenericRepository<Unit>> GenericRepositoryMock { get; set; }

        public InventoryProcessorTest()
        {
            TransformHelperMock = new Mock<ITransformHelper>();

            GenericRepositoryMock = new Mock<IGenericRepository<Unit>>();

            InstantiateClassUnderTest(TransformHelperMock.Object, GenericRepositoryMock.Object);
        }

        [Fact]
        public async Task InventoryProcessor_ProcessUnit_WithUnitEvent_GetsUnitAndPassesToUnitOfWork()
        {
            var unitEvent = EventHelper.GetUnitEvent();
            var unit = EntityHelper.GetUnit();

            TransformHelperMock.Setup(x => x.Transform(unitEvent)).Returns(unit).Verifiable();
            
            await ClassUnderTest.ProcessUnit(unitEvent);

            TransformHelperMock.Verify();
            GenericRepositoryMock.Verify(i => i.AddOrUpdate(unit), Times.Once);
            GenericRepositoryMock.Verify(i => i.SaveChangesAsync(), Times.Once);
        }
    }
}
