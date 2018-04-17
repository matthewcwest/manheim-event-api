namespace ManheimEventApi.Utilities
{
    public static class EventTypeExtension
    {
        public static bool CanProcess(this string eventType)
        {
            return eventType == "TEST.EVENT" ? false : true;
        }
    }
}