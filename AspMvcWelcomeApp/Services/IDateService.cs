namespace AspMvcWelcomeApp.Services
{
    public interface IDateService
    {
        string GetDate();
    }

    public class DateLongService : IDateService
    {
        public string GetDate()
        {
            return DateTime.Now.ToLongDateString();
        }
    }
}
