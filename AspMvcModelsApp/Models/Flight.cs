namespace AspMvcModelsApp.Models
{
    public class Flight
    {
        static int globalId = 1;
        DateTime? dateTime;
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? ToCity { get; set; }
        public string? FromCity { get; set; }
        public int AirlineId { get; set; }
        public Airline? Airline { get; set; }
        public string? Date
        {
            get => dateTime?.ToShortDateString();
        }
        public string? Time
        {
            get => dateTime?.ToShortTimeString();
        }
        public DateTime? DateTime
        {
            private get => dateTime;
            set
            {
                dateTime = value;
            }
        }

        public Flight()
        {
            Id = globalId++;
        }

        public override string ToString()
        {
            return $"{Name}\n\tfrom: {FromCity}\n\tto: {ToCity}\n\tdate: {Date}, time: {Time}";
        }
    }
}
