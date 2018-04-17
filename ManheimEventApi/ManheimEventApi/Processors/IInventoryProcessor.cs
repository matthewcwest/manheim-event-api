using System.Threading.Tasks;
using ManheimEventApi.Models.Units;

namespace ManheimEventApi.Processors
{
   public interface IInventoryProcessor
    {
        Task ProcessUnit(UnitEvent newEvent);
    }
}
