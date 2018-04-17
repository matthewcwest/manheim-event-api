using ManheimEventApi.Models.Offerings;
using ManheimEventApi.Models.Units;

namespace ManheimEventApi.Utilities
{
    public interface ITransformHelper
    {
        Offering Transform(OfferingEvent offering);

        Unit Transform(UnitEvent unit);
    }
}