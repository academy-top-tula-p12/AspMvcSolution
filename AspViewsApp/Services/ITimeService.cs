namespace AspViewsApp.Services
{
    public interface ITimeService
    {
        string GetTime();
    }

    public class LongTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToLongTimeString();
    }
}
