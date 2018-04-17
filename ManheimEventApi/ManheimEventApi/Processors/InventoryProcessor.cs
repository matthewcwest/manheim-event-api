using System;
using System.Threading.Tasks;
using ManheimEventApi.Logging;
using ManheimEventApi.Models.Units;
using ManheimEventApi.Utilities;
using ManheimEventApi.DataAccess;

namespace ManheimEventApi.Processors
{
    public class InventoryProcessor : IInventoryProcessor
    {
        private readonly ITransformHelper _transformHelper;

        private readonly IGenericRepository<Unit> _genericRepository;

        public InventoryProcessor(ITransformHelper transformHelper, IGenericRepository<Unit> genericRepository)
        {
            _transformHelper = transformHelper;
            _genericRepository = genericRepository;
        }

        public async Task ProcessUnit(UnitEvent newEvent)
        {
            try
            {
                var unit = _transformHelper.Transform(newEvent);

                _genericRepository.AddOrUpdate(unit);

                await _genericRepository.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                Logger.Error($"An error occured attempting to process {newEvent.eventType}");
                Logger.Error($"Class: {nameof(InventoryProcessor)}, Method: {nameof(ProcessUnit)}");
                Logger.Error(ex);
                throw;
            }
        }
    }
}