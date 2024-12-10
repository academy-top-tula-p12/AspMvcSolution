namespace AspMvcModelsApp.Models
{
    public class Airline
    {
        static int globalId = 1;
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public Airline()
        {
            Id = globalId++;
        }
    }
}
