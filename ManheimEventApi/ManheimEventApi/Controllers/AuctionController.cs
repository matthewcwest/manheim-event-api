using System.Threading.Tasks;
using System.Web.Http;
using ManheimEventApi.Logging;
using ManheimEventApi.Models.Offerings;
using ManheimEventApi.Processors;
using ManheimEventApi.Utilities;

namespace ManheimEventApi.Controllers
{
    public class AuctionController : ApiController
    {
        private readonly IAuctionProcessor _auctionProcessor;

        public AuctionController(IAuctionProcessor auctionProcessor)
        {
            _auctionProcessor = auctionProcessor;
        }

        [HttpPost]
        public async Task<IHttpActionResult> Offering(OfferingEvent newEvent)
        {        
                Logger.Info($"Received {newEvent.eventType}, href: {newEvent.body.href}");

                if (newEvent.eventType.CanProcess())
                {
                    await _auctionProcessor.ProcessOffering(newEvent);
                }

                return Ok();                      
        }
    }
}