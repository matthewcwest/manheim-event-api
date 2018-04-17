using System.Threading.Tasks;
using System.Web.Http;
using ManheimEventApi.Logging;
using ManheimEventApi.Models.Units;
using ManheimEventApi.Processors;
using ManheimEventApi.Utilities;

namespace ManheimEventApi.Controllers
{
    public class InventoryController : ApiController
    {
        private readonly IInventoryProcessor _inventoryProcessor;

        public InventoryController(IInventoryProcessor inventoryProcessor)
        {
            _inventoryProcessor = inventoryProcessor;
        }

        [HttpPost]
        public async Task<IHttpActionResult> Unit(UnitEvent newEvent)
        {
            Logger.Info($"Received {newEvent.eventType}, href: {newEvent.body.href}");

            if (newEvent.eventType.CanProcess())
            {
                await _inventoryProcessor.ProcessUnit(newEvent);
            }

            return Ok();
        }
    }
}