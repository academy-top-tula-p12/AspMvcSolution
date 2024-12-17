namespace AspMvcViewComponentsApp.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? ToCity { get; set; }
        public DateTime Date { get; set; }
    }
}
