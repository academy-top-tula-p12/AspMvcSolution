namespace AspMvcHtmlHelpersApp.Models
{
    public class ListViewModel
    {
        public string Title { get; set; }
        public IEnumerable<string> Items { get; set; }
        public bool Order { get; set; } = false;
    }
}
