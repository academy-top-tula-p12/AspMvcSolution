namespace AspMvcModelsApp.Models
{
    public class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public Airline()
        {

        }
    }
}
