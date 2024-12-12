namespace AspMvcHtmlHelpersApp.Models
{
    public enum FlightType
    {
        Local,
        Region,
        Inter
    }
    public class Flight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FromCity { get; set; }

        public DateTime? FromDate { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public bool Activity {  get; set; }
        public FlightType Type { get; set; }

        public int Price { get; set; }
    }
}
