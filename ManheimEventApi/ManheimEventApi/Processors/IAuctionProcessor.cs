using System.Threading.Tasks;
using ManheimEventApi.Models.Offerings;

namespace ManheimEventApi.Processors
{
   public interface IAuctionProcessor
    {
        Task ProcessOffering(OfferingEvent newEvent);
    }
}
