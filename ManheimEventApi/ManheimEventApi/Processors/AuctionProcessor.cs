using System;
using System.Threading.Tasks;
using ManheimEventApi.Logging;
using ManheimEventApi.Models.Offerings;
using ManheimEventApi.Utilities;
using ManheimEventApi.DataAccess;

namespace ManheimEventApi.Processors
{
    public class AuctionProcessor : IAuctionProcessor
    {
        private readonly ITransformHelper _transformHelper;

        private readonly IGenericRepository<Offering> _genericRepository;

        public AuctionProcessor(ITransformHelper transformHelper, IGenericRepository<Offering> genericRepository)
        {
            _transformHelper = transformHelper;
            _genericRepository = genericRepository;
        }

        public async Task ProcessOffering(OfferingEvent newEvent)
        {
            try
            {
                var offering = _transformHelper.Transform(newEvent);

                _genericRepository.AddOrUpdate(offering);

                await _genericRepository.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                Logger.Error($"An error occured attempting to process {newEvent.eventType}");
                Logger.Error($"Class: {nameof(AuctionProcessor)}, Method: {nameof(ProcessOffering)}");
                Logger.Error(ex);
                throw;
            }
        }
    }
}