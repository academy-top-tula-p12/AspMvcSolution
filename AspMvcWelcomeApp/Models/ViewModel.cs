namespace AspMvcWelcomeApp.Models
{
    public class ViewModel
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }

        public List<string> Products { get; set; } = new();
        public string? Footer { get; set; }
    }
}
